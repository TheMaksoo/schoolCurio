import csv
import os
contractFile = open("contractchecker\\contracts.csv", "r", encoding="UTF-8")
contractDict = csv.DictReader(contractFile)
contractList = list(contractDict)

isFound = False
isRunning = True

os.system("cls")
print("1 = Statistieken\n2 = ContractChecker\n")
choice = input("Maak een keuze: 1 of 2:\n")

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


contractFile.close()