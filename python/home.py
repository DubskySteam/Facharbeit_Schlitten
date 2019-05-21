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
from tinkerforge.bricklet_joystick import BrickletJoystick
from tinkerforge.bricklet_oled_128x64 import BrickletOLED128x64
from tinkerforge.bricklet_rotary_poti import BrickletRotaryPoti
from tinkerforge.bricklet_distance_ir import BrickletDistanceIR
from tinkerforge.bricklet_linear_poti import BrickletLinearPoti


#Initial Setup

HOST = "localhost"
PORT = 4223

posx = 0
posy = 0

UIDdcb = ""
UIDoled = "yqm"
UIDstepper = ""
UIDjoystick = "wah"
UIDpoti = ""
UIDropoti = ""

#Funktionen

def up_oled(line, text):
    oled.write_line(line, 0, text)
    return


#Callbacks

def cb_pressed():
    oled.write_line(2,10,"Gedrückt")
    oled.clear_display()


def cb_released():
    oled.write_line(2,10,"Losgelassen")
    oled.clear_display()

def cb_dcb_velocity(velocity, dcb):
    if velocity == 32000:
        print("Max. Geschwindigkeit erreicht")
    elif velocity == 28000:
        print("fast Max. Geschwindigkeit erreicht")

#Hauptfunktion

if __name__ == "__main__":
 
    ipcon = IPConnection()
    oled = BrickletOLED128x64(UIDoled, ipcon)
    joystick = BrickletJoystick(UIDjoystick, ipcon)

    ipcon.connect(HOST, PORT)

    oled.clear_display()
    up_oled(2, "Einstellungen")
    up_oled(3, "werden gesetzt")

    time.sleep(2)

    oled.clear_display()
    up_oled(2, "Callbacks")
    up_oled(3, "werden registriert")

    joystick.register_callback(joystick.CALLBACK_PRESSED, cb_pressed)
    joystick.register_callback(joystick.CALLBACK_RELEASED, cb_pressed)

    time.sleep(2)
    oled.clear_display()

    while True:
        posx, posy = joystick.get_position()
        oled.write_line(2, 2, str(posx))
        oled.write_line(3, 2, str(posy))
        time.sleep(0.1)
        oled.clear_display()

    input("taste drücken")
    oled.clear_display()
    ipcon.disconnect()