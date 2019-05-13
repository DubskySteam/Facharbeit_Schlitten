# Facharbeit_Schlitten

## Ziel der Facharbeit

Ein ursprünglich als Kameraschlitten gedachtes System soll so umfunktioniert werden, dass dieser Schlitten vo einem Objekt bzw. einer Hand einen gewissen Abstand hält. Zusätzlich sollen wichtige / interessante Informationen auf einem OLED DIsplay angezeigt werden.

## Benutze APIs

###### API - Python:   [Tinkerforge API Bindings](https://www.tinkerforge.com/de/doc/Software/API_Bindings_Python.html#api-referenz-und-beispiele)
###### API - VB.Net:   [Tinkerforge API Bindings](https://www.tinkerforge.com/de/doc/Software/API_Bindings_VBNET.html#api-bindings-vbnet)


**Python Verzeichnis:**
```
- main.py - Brain.exe
- oled.py - Gibt Infos auf einem 128x64 OLED Display aus.
- poti.py - Potis werden zur Regelung vom DC & StepperBrick genutzt.
- stepper.py - Regelt den StepperBrick, welcher den Schlitten fährt.
```

**VB.Net Verzeichnis:**
```
- facharbeit.sln - Visual Studio Projekt
```
