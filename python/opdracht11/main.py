import csv
arrivalFile = open("arrivals\\arrivals.csv", "r", encoding="UTF-8")
arrivalInfo = csv.DictReader(arrivalFile)
arrivalList = list(arrivalInfo)

flights = 0
passengers = 0
for arrival in arrivalList:
    flights += 1
    passengers += int(arrival['passengers'])
    print(f"At {arrival['arrival']} a {arrival['airline']} flight from the city of {arrival['origin']} has landed, carrying {arrival['passengers']} passengers.")

print("--------------")
print(f"Flights: {flights}")
print(f"Passengers: {passengers}")
print(f"Average passengers: {passengers / flights}")

arrivalFile.close()