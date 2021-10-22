import csv
import os
from datetime import datetime
from datetime import timedelta

maintenanceFile = open("weekcheckH8\\maintenance.csv", "r", encoding="UTF-8")
maintenanceDict = csv.DictReader(maintenanceFile)
maintenanceList = list(maintenanceDict)

isRunning = True

while isRunning == True:
    print("1 .Toon vliegtuigen die in de komende X maanden onderhoud nodig hebben")
    print("2. Toon het Y-aantal laatst onderhouden vliegtuigen")
    choice = input("keuze 1 or 2: ")

    os.system("cls")
    if choice == "1":
        rawmonth = ''
        months = 0
        today = datetime.now()

        while months is int(0):
            try:
                rawmonths = input("Hoeveel maanden vooruit: ")
                months = int(rawmonths)
            except ValueError:
                print("Error geen geldig nummer.")

        check_date = today + timedelta(days=months*30)
            
        for checkupdata in maintenanceList:
            end = datetime.strptime(checkupdata["checkup_before"], "%d/%m/%Y")
            if end < check_date and end > today:
                print(f"{checkupdata['plane_id']} | {checkupdata['checkup_before']}")
    
    if choice == "2":
        rawamount = ''
        amount = 0
        data_sorted = sorted(maintenanceList, key=lambda plane: datetime.strptime(plane["last_checkup"], "%d/%m/%Y"), reverse=True)

        while amount is int(0):
            try:
                rawamount = input("Hoeveel vliegtuigen  tonen: ")
                amount = int(rawamount)
            except ValueError:
                print("Error geen geldig nummer.")

        for i in range(amount):
            plane = data_sorted[i]
            print(f"{plane['plane_id']} | {plane['last_checkup']}")
    
    stop = input("Type X om te stoppen. of Enter om door te gaan.")
    if stop.lower() == "x":
        isRunning = False