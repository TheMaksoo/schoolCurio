colorList = ["groen", "blauw", "geel", "rood", "paars", "oranje"]
badColor = input("Voer een van de kleuren in: ")

#Gebruik patroon 3.4 om het programma verder af te maken
#Je moet alle kleuren uit de lijst printen, _behalve_ de ingevoerde "slechte kleur"
for color in colorList:
  if color != badColor:
    print(color)
    



#Voorbeeld-output, wanneer "geel" de input zou zijn:
#groen
#blauw
#rood
#paars
#oranje