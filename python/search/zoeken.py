import csv
import os
contractFile = open("contractchecker\\contracts.csv", "r", encoding="UTF-8")
contractDict = csv.DictReader(contractFile)
contractList = list(contractDict)

isFound = False

id = input("Voer een contract-nummer in: ")

for contract in contractList:
    if contract["contract_id"] == id:
        isFound = True
        breakS

os.system("cls")

if isFound:
    print(f"{contract['contract_id']} | {contract['company']}")
else:
    print(f"Contract met nummer {id} niet gevonden!")
