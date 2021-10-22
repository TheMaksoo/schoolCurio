import csv
report = open("weekcheckH6\\report.txt", "w")
animalsfile = open("weekcheckH6\\animals.csv", "r", encoding="UTF-8")
animalsDict = csv.DictReader(animalsfile)
animalsList = list(animalsDict)

totalWorth = float(0)
totalAnimals = 0
totalAnimalsOfCountry = 0

country = input("Country of Origin:")

for animal in animalsList:
    totalAnimals += 1
    totalWorth += float(animal["import_value"])
    if animal["country_of_origin"] == country:
        report.write(f"name: {animal['animal']}\n")
        totalAnimalsOfCountry += 1

report.write(f"total worth: {round(totalWorth, 2)}\n")
report.write(f"Average worth: {round(totalWorth / totalAnimals, 2)}\n")
report.write(f"Animals from {country}: {totalAnimalsOfCountry}\n")
animalsfile.close()
report.close()