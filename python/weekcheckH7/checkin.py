from datetime import datetime
from datetime import timedelta
import csv
import os

bookingsFile = open("weekcheckH7\\bookings_DX28.csv", "r", encoding="UTF-8")
bookingsDict = csv.DictReader(bookingsFile)
bookingsList = list(bookingsDict)

checkingFile = open("weekcheckH7\\checked_in.txt", "w")

flight = bookingsList[1]["flight_id"]
now = datetime.now()
deadline = now + timedelta(minutes=2)

os.system('cls')
print(f"Welkom bij de incheckbalie!")
print(f"Inchecken voor vlucht: {flight}")
print(f"Inchecken sluit om: {deadline.strftime('%H:%M:%S')}")
print(f"Het is nu: {now.strftime('%H:%M:%S')}")
input(f"\n\nDruk op enter om door te gaan...")
os.system('cls')

isRunning = True
passengerFound = False

stop = ''

while isRunning:
    awnser = ''

    num = input("Booking id: ")
    os.system('cls')

    for passenger in bookingsList:
        if passenger["booking_id"] == num:
            passengerinfo = passenger
            print(f"Controleer gegevens:")
            print(f"{passengerinfo['flight_id']} | {passengerinfo['booking_id']} | {passengerinfo['gender']} | {passengerinfo['name']}")
            awnser = input("Inchecken? Ja / Nee\n")
            passengerFound = True
            
    if passengerFound == False:
        print("Passagier niet gevonden.")

    if awnser.lower() == "ja":
        os.system('cls')
        print(f"Passagier {passengerinfo['name']} is ingechecked voor vlucht {passengerinfo['flight_id']}!")
        checkingFile.write(f"{passengerinfo['booking_id']}\n")
        passengerFound = False
        passengerinfo = ''

    if awnser.lower() == "nee":
        os.system('cls')
        print("passagier wordt niet ingechecked.")
 
    print("----------------------------")
    stop = input("Druk op enter om door te gaan of typ 'X'\n")
    os.system('cls')
    if(stop.lower() == 'x' or datetime.now() > deadline):
        isRunning = False

print("Check-in gesloten. Houdoe!")

bookingsFile.close()
checkingFile.close()