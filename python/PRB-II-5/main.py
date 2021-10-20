carList = [
  {
    "brand": "Volvo",
    "year": 1998,
    "needsRepair": True
  },
  {
    "brand": "Toyota",
    "year": 1993,
    "needsRepair": False
  },
  {
    "brand": "Fiat",
    "year": 2007,
    "needsRepair": True
  },
  {
    "brand": "Honda",
    "year": 2011,
    "needsRepair": False
  },
]
print("----------------Car list----------------")
#!! Schrijf hieronder je for-loop voor opdracht 9.2
for car in carList:
  print(car["brand"])



print("-------------Cars past 2000-------------")
#!! Schrijf hieronder je for-loop voor opdracht 9.3
for car in carList:
  if car["year"] >= 2000:
    print(car["brand"])



print("----------Cars needing repairs----------")
#!! Schrijf hieronder je for-loop voor opdracht 9.4
for car in carList:
  if car["needsRepair"] == True:
    print(car["brand"])



#Einde