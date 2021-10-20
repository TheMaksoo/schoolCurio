
from data import *

#Start program
print("Welkom bij HangarParkeerder6000")
isRunning = True

while isRunning:
  print("-------------------------------------------------")
  print("Deze vliegtuigen wachten om geparkeerd te worden:\n")

  #!! Loop over planesLanded, print alleen wanneer de hangar 0 is (dat betekent dat het vliegtuig nog _niet_ in een hangar staat).
  for planeinfo in planeLandedList:
    if planeinfo['hangar'] == 0:
      print(f"type: {planeinfo['type']} \ncode: {planeinfo['code']} \n")

  #Vraag de gebruiker om een vliegtuigcode in te voeren.
  code = False
  while code == False:
    inputCode = input("\nVoer code in: ")
    for planeinfo in planeLandedList:
      if inputCode.lower() == planeinfo['code'].lower():
        code = True
    if code != True:
      print("Voer een geldige code in.")

  print("\nDeze hangars zijn nog vrij:")

  for hangarinfo in hangarList:
    if hangarinfo['occupied'] == False:
      print(f"Hangar: {hangarinfo['num']}")
  
  #Vraag de gebruiker om een hangarnummer in te voeren. Blijf de vraag herhalen zolang nog geen geldig nummer is ingevoerd. Sla het nummer op in de variabele "hangar".
  inputHangar = False
  while(inputHangar == False):
    try:
      inputHangar = input("\nVoer nummer in: ")
      inputHangar = int(inputHangar)
    except:
      print("Voer een geldig nummer in!")
      inputHangar = False

  #Tip: pas eventueel deze variabelen aan naar je eigen namen:
  

  #Zoek het gekozen vliegtuig, en stel de hangar in op het gekozen nummer.
  for plane in planeLandedList:
    if plane['code'].lower() == inputCode.lower() and plane['hangar'] == 0:
      plane['hangar'] = inputHangar

      for hangarinfo in hangarList:
        if hangarinfo['num'] == inputHangar:
          hangarinfo['occupied'] = True
          print(f"\nOk, we parkeren {inputCode.upper()} in hangar {inputHangar}!\n")
          
  

  

  #!! Zorg dat het programma stopt als de gebruik een 'X' heeft ingevoerd
  result = input("Druk op enter om door te gaan of typ 'X' om te stoppen...\n")
  if result.lower() == "X":
    isRunning = False


  #Einde