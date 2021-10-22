import csv
import os
contractFile = open("contractchecker\\contracts.csv", "r", encoding="UTF-8")
contractDict = csv.DictReader(contractFile)
contractList = list(contractDict)

os.system("cls")
print("1 = Statistieken\n 2 = ContractChecker")
choice = input("\nMaak een keuze: 1 of 2:\n")

os.system("cls")
if choice == "1":
    count = len(contractList)
    print(f"aantal contracten: {count}")

elif choice == "1":
    pass


contractFile.close()