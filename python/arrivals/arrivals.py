import csv
arrivalFile = open("\arrivals\arrivals.csv", "r", encoding="UTF-8")
arrivalInfo = csv.DictReader(arrivalFile)
arrivalList = list(arrivalInfo)

for arrival in arrivalList:
    print(f"At {arrival['arrival']} a {arrival['airline']} flight from the city of {arrival['origin']} has landed, carrying {arrival['passengers']} passengers.")

arrivalFile.close()