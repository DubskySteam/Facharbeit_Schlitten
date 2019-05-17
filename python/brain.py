#!/usr/bin/env python

import tkinter
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
from tinkerforge.bricklet_oled_128x64 import BrickletOLED128x64
from tinkerforge.bricklet_rotary_poti import BrickletRotaryPoti
from tinkerforge.bricklet_distance_ir import BrickletDistanceIR
from tinkerforge.bricklet_linear_poti import BrickletLinearPoti

#Initial Setup

HOST = "localhost"
PORT = 4223

UIDdcb = "xRz"
UIDoled = ""
UIDstepper = ""
UIDpoti = ""
UIDropoti = ""

#Funktionen

def updt_oled(line, text):
    oled.clear_display()
    oled.write_line(line, 0, text)
    return

def outbreak():
    stepper.disable()
    dcb.disable()

#Callbacks

def cb_dcb_velocity(velocity, dcb):
    if velocity == 32000:
        print("Max. Geschwindigkeit erreicht")
    elif velocity == 28000:
        print("fast Max. Geschwindigkeit erreicht")

if __name__ == "__main__":
 
    window = Tk()
    window.title("Facharbeit - Schlitten")
    window.geometry('720x420')
    window.mainloop()

    ipcon = IPConnection()
    dcb = BrickDC(UIDdcb, ipcon)
    oled = BrickletOLED128x64(UIDoled, ipcon)
    poti = BrickletRotaryPoti(UIDropoti, ipcon)
    stepper = BrickStepper(UIDstepper, ipcon)

    ipcon.connect(HOST, PORT)

    oled.clear_display()
    updt_oled(1, "Einstellungen")
    updt_oled(2, "werden gesetzt")

    dcb.set_pwm_frequency(10000)
    dcb.set_acceleration(5000)

    stepper.set_step_mode(8)
    stepper.set_motor_current(1000)
    stepper.set_max_velocity(3000)
    stepper.set_speed_ramping(500, 5000)

    time.sleep(1)

    oled.clear_display()
    updt_oled(1, "Callbacks")
    updt_oled(2, "werden registriert")

    dcb.register_callback(dcb.CALLBACK_VELOCITY_REACHED,
                         lambda x: cb_dcb_velocity(x, dcb))