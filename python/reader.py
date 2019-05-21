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
from tinkerforge.bricklet_oled_128x64 import BrickletOLED128x64
from tinkerforge.bricklet_rotary_poti import BrickletRotaryPoti
from tinkerforge.bricklet_distance_ir import BrickletDistanceIR
from tinkerforge.bricklet_linear_poti import BrickletLinearPoti

#Initial Setup

HOST = "localhost"
PORT = 4223

ctrl_status = "Ausgeschaltet"
ctrl_velofan = "28000"
ctrl_velostepper = "1500"
ctrl_accstepper = "700"
ctrl_hz_fan = "6769"

UIDdcb = "xRz"
UIDoled = "yqm"
UIDstepper = ""
UIDpoti = ""
UIDropoti = ""

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


#Callbacks

def cb_dcb_velocity(velocity, dcb):
    if velocity == 32000:
        print("Max. Geschwindigkeit erreicht")
    elif velocity == 28000:
        print("fast Max. Geschwindigkeit erreicht")

if __name__ == "__main__":

    ipcon = IPConnection()
    oled = BrickletOLED128x64(UIDoled, ipcon)

    ipcon.connect(HOST, PORT)

    oled.clear_display()
    o_write(1,5, "Einstellungen")
    o_write(1,5, "werden gesetzt")

    time.sleep(1)

    oled.clear_display()
    o_write(1,5, "Callbacks")
    o_write(1,3, "werden registriert")

    updt_oled()

    input("")
    o_clear()
    ipcon.disconnect()