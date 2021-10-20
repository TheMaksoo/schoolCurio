from airplaneData import *

#Start program
print("Welkom bij HangarParkeerder3000")
isRunning = True
code = False
inputHangar = False

while isRunning:
  print("-------------------------------------------------")
  print("Deze vliegtuigen wachten om geparkeerd te worden:")

  for planeinfo in planeLandedList:
    if planeinfo['hangar'] == 0:
      print(f"type: {planeinfo['type']} \ncode: {planeinfo['code']} \n")

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
  
  while(inputHangar == False):
    try:
      inputHangar = input("\nVoer nummer in: ")
      inputHangar = int(inputHangar)
    except:
      print("Voer een geldig nummer in!")
      inputHangar = False

  for plane in planeLandedList:
    if plane['code'].lower() == inputCode.lower() and plane['hangar'] == 0:
      plane['hangar'] = inputHangar

      for hangarinfo in hangarList:
        if hangarinfo['num'] == inputHangar:
          hangarinfo['occupied'] = True
          print(f"\nOk, we parkeren {inputCode.upper()} in hangar {inputHangar}!\n")

  result = input("Druk op enter om door te gaan of typ 'X' om te stoppen...\n")
  if result.lower() == "X":
    isRunning = False

  