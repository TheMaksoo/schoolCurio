import csv
import os
from datetime import datetime
from datetime import timedelta

contractFile = open("contractchecker2\\contracts.csv", "r", encoding="UTF-8")
contractDict = csv.DictReader(contractFile)
contractList = list(contractDict)

isFound = False
isRunning = True

os.system("cls")
print("1 = Statistieken\n2 = ContractChecker\n3 = toon contracter die binnen 6 maanden verlopen.")
choice = input("Maak een keuze: 1 of 2 of 3:\n")

os.system("cls")
if choice == "1":
    count = len(contractList)
    print(f"aantal contracten: {count}")

elif choice == "2":
    while isRunning == True:
        id = input("Voer een contract-nummer in: ")

        for contract in contractList:
            if contract["contract_id"] == id:
                isFound = True
                break

        os.system("cls")

        if isFound:
            print(f"{contract['contract_id']} | {contract['company']} | {contract['contract_end']}")
            isFound = False
        else:
            print(f"Contract met nummer {id} niet gevonden!")

        stop = input("Type X om te stoppen. of Enter om door te gaan.")
        if stop.lower() == "x":
            isRunning = False

elif choice == "3":
    today = datetime.now()
    check_date = today + timedelta(days=180)
    for contract in contractList:
        end = datetime.strptime(contract["contract_end"], "%d/%m/%Y")
        if end < check_date and end > today:
            print(f"{contract['contract_end']}|{contract['contract_id']} | {contract['company']} ")


contractFile.close()