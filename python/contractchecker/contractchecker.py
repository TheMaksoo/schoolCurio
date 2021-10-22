import csv
import os
contractFile = open("contractchecker\\contracts.csv", "r", encoding="UTF-8")
contractDict = csv.DictReader(contractFile)
contractList = list(contractDict)

isFound = False

os.system("cls")
print("1 = Statistieken\n 2 = ContractChecker")
choice = input("\nMaak een keuze: 1 of 2:\n")

os.system("cls")
if choice == "1":
    count = len(contractList)
    print(f"aantal contracten: {count}")

elif choice == "1":
    id = input("Voer een contract-nummer in: ")

    for contract in contractList:
        if contract["contract_id"] == id:
            isFound = True
            break

    os.system("cls")

    if isFound:
        print(f"{contract['contract_id']} | {contract['company']}")
    else:
        print(f"Contract met nummer {id} niet gevonden!")


contractFile.close()