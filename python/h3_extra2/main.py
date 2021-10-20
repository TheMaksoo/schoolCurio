# Dit programma wordt een "willekeurig letter-rader"

# De code hieronder kiest een willekeurige letter uit de lijst
import random
letterList = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
randomLetter = random.choice(letterList)

## Initialiseer variabele letter
letter = ""

## Schrijf een while-loop die blijft gaan zolang letter niet gelijk is aan randomLetter
while letter != randomLetter:
  letter = input("kies een letter:\n")
  ## In de while-loop vraag je om input, die stop je in de variabele letter
  

print("You guessed it!")