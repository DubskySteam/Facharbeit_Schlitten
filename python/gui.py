#!/usr/bin/env python

import sys, os, time, ctypes, math
import tkinter

from tkinter import *
from tkinter import Menu

#Variablen

status = "Offline"
velocitystepper = 0
velocityfan = 28000

#___________

def status_ae():
    status = "Online"
    lbl_status.configure(text='Status: ' + status)
    return

def updt_fan(velo):
    lbl_velocity_fan.configure(text='Lüfter: ' + str(velo) + ' > (' + str((velo/32000)*100) + '%)' ) 
    return


window = Tk()

window.title('Facharbeit - Schlitten')
window.geometry('720x420')
mbar = Menu(window) #mbar >> Menübar

mbaradd = Menu(mbar, tearoff=0)
mbaradd.add_command(label='Starten') 
mbaradd.add_separator()
mbaradd.add_command(label='Stoppen')
mbar.add_cascade(label='Grundfunktionen', menu=mbaradd)

lbl_status = Label(window, text='Status: ' + status)
lbl_status.grid(column=0, row= 0)

lbl_velocity_stpr = Label(window, text='Geschwindigkeit: ' + str(velocitystepper))
lbl_velocity_stpr.grid(column=0, row= 2)

lbl_velocity_fan = Label(window, text='Lüfter: ' + str(velocityfan) + ' > (' + str((velocityfan/32000)*100) + '%)' )
lbl_velocity_fan.grid(column=0, row= 3)

window.config(menu=mbar)
window.mainloop()