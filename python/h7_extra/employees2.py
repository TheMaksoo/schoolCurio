import csv
import os
employeeFile = open("h7_extra\\employees.csv", "r", encoding="UTF-8")
employeeDict = csv.DictReader(employeeFile)
employeeList = list(employeeDict)

totalEmployees = 0
isRunning = False

print("1. Show total employees.")
print("2. search employee")
choice = input("choice: \n")

os.system("cls")
if choice == "1":
    for employee in employeeList:
        totalEmployees += 1
    
    print(f"Total Employees: {totalEmployees}")
if choice == "2":
    isRunning = True

while isRunning == True:

    employeeFound = False
    employeeId = input("employee id: ")

    for employee in employeeList:
        if employee["id"] == employeeId:
            os.system("cls")
            print(f"ID:{employee['id']} | Name:{employee['first_name']} {employee['last_name']} | Department: {employee['departement']} | Salary: {employee['salary']} ")
            employeeFound = True

    if employeeFound == False:
        os.system("cls")
        print("No employee with that ID found.")

    stop = input("Type X to stop press enter to continue.\n")
    if stop.lower() == "x":
        isRunning = False

    
employeeFile.close()