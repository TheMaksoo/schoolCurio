pilotList = ["Bob", "John", "Fred", "Marie", "Jack", "Bill"]
isRunning = True
nameToGreet = ""

nameToGreet = input("\nVoer een naam in (of 'X' om te stoppen):\n")
if(nameToGreet == "X"):
  isRunning = False

while isRunning == True:
  for pilot in pilotList:
    if nameToGreet.lower() == pilot.lower():
      print(f"Hi {pilot}!\nNice to see you again!")
      isRunning = False
    else:
      print(pilot)

# Maak op de regel hieronder een while-loop die doorgaat zolang 'isRunning' waar is
#Maak op de regel hieronder een for-loop die alle piloten doorloopt.
#In de for-loop plaats je een if-statement dat checkt of 'nameToGreet' gelijk is aan de naam waar de loop is (als dat zo is, print dan een uitgebreid bericht, anders print alleen de naam)