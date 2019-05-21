#!/usr/bin/env python

import tinkerforge
import os
import sys
import math
import time
import ctypes
import urllib.request

from tkinter import *
from tinkerforge.ip_connection import IPConnection
from tinkerforge.brick_dc import BrickDC
from tinkerforge.brick_stepper import BrickStepper
from tinkerforge.bricklet_joystick import BrickletJoystick
from tinkerforge.bricklet_distance_ir import BrickletDistanceIR
from tinkerforge.bricklet_oled_128x64 import BrickletOLED128x64
from tinkerforge.bricklet_rotary_poti import BrickletRotaryPoti
from tinkerforge.bricklet_distance_ir import BrickletDistanceIR
from tinkerforge.bricklet_linear_poti import BrickletLinearPoti

#Initial Setup

HOST = "localhost"
PORT = 4223

ctrl_status = "Ausgeschaltet"
ctrl_velofan = ""
ctrl_velostepper = ""
ctrl_accstepper = ""
ctrl_hz_fan = ""

ropo_pos = 0

UIDdcb = "xRz"
UIDoled = "yqm"
UIDstepper = ""
UIDpoti = ""
UIDropoti = ""
UIDjoystick = "wah"
UIDirsensor = ""

#Funktionen

def updt_oled():
    oled.clear_display()
    oled.write_line(0, 5, "[ Einstellungen ]")
    oled.write_line(1, 0, "--------------------------")
    oled.write_line(2, 0, "Status: " + ctrl_status)
    oled.write_line(4, 0, "Luefter: " + ctrl_velofan)
    oled.write_line(5, 0, "Stepper:" + ctrl_velostepper)
    oled.write_line(6, 0, "Stepper:" + ctrl_accstepper + " - acc")
    oled.write_line(7, 0, "Frequenz:" + ctrl_hz_fan)
    return


def o_clear():
    oled.clear_display()

def o_write(zeile,pos,text):
    oled.write_line(zeile,pos,text)

def outbreak():
    stepper.disable()
    dcb.disable()

#Callbacks

def cb_dcb_velocity(velocity, dcb):
    if velocity == 32000:
        print("Callback _> Lüftergeschwindigkeit = 32000")
    elif velocity >= 28000:
        print("Callback _> Lüftergeschwindigkeit >= 28000")
    elif velocity >= 22000:
        print("Callback _> Lüftergeschwindigkeit >= 22000")

def cb_stepper_undervoltage():
    stepper.disable()
    dcb.disable()
    o_clear()
    o_write(4,3, "Spannungsabfall")
    ipcon.disconnect()

def cb_rotary_fancontrol(position):
    dcb.set_max_velocity(213 * position)

def cb_linearpoti_controller(position):
    if position >= 50:
        stepper.enable()
    else:
        stepper.disable()

def cb_irsensor_distance(distance):
    if distance <= 150:
        stepper.drive_forward()
    elif distance >= 200:
        stepper.stop()
    else:
        print("Puffer erreicht")

if __name__ == "__main__":

    ipcon = IPConnection()
    dcb = BrickDC(UIDdcb, ipcon)
    oled = BrickletOLED128x64(UIDoled, ipcon)
    poti = BrickletLinearPoti(UIDpoti, ipcon)
    ropoti = BrickletRotaryPoti(UIDropoti, ipcon)
    stepper = BrickStepper(UIDstepper, ipcon)
    joystick = BrickletJoystick(UIDjoystick, ipcon)
    irsensor = BrickletDistanceIR(UIDirsensor, ipcon)

    ipcon.connect(HOST, PORT)

    o_clear()
    o_write(1,5, "Einstellungen")
    o_write(1,5, "werden gesetzt")

    ctrl_hz_fan = 5000
    dcb.set_pwm_frequency(5000)
    dcb.set_acceleration(5000)

    ctrl_velostepper = 3000
    ctrl_accstepper = 1000
    stepper.set_step_mode(8)
    stepper.set_motor_current(1000)
    stepper.set_max_velocity(3000)
    stepper.set_speed_ramping(1000, 50000)
    stepper.set_current_position(0)

    time.sleep(1)

    o_clear()
    o_write(1,5, "Callbacks")
    o_write(1,3, "werden registriert")

    dcb.register_callback(dcb.CALLBACK_VELOCITY_REACHED,
                         lambda x: cb_dcb_velocity(x, dcb))
    stepper.register_callback(BrickStepper.CALLBACK_UNDER_VOLTAGE, cb_stepper_undervoltage)
    ropoti.register_callback(BrickletRotaryPoti.CALLBACK_POSITION, cb_rotary_fancontrol)
    poti.register_callback(BrickletLinearPoti.CALLBACK_POSITION, cb_linearpoti_controller)
    irsensor.register_callback(BrickletDistanceIR.CALLBACK_DISTANCE, cb_irsensor_distance)

    o_clear()
    o_write(1,6, "Bricks")
    o_write(1,3, "werden aktiviert")

    stepper.enable()
    dcb.enable()

    time.sleep(1)

    ctrl_status = "Angeschaltet"
    updt_oled()

    input("")