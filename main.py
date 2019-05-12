import tinkerforge
import os
import time
import sys
import ctypes
import urllib.request
import oled
import poti
import stepper

from tinkerforge.ip_connection import IPConnection
from tinkerforge.brick_dc import BrickDC

#Initial Setup

HOST = "localhost"
PORT = 4223
UIDdcb = "xRz"



if __name__ == "__main__":
    
    ipcon = IPConnection
    dcb = BrickDC(UIDdcb, ipcon)

    dcb.set_pwm_frequency(10000)
    dcb.set_acceleration(5000)
    dcb.set_velocity(32767)