import csv
employeeFile = open("employees\\employees.csv", "r", encoding="UTF-8")
employeeDict = csv.DictReader(employeeFile)
employeeList = list(employeeDict)

totalSalary = float(0)
totalEmployees = 0
totalEmployeesFromDepartment = 0

departmentType = input("Department type:")

for employee in employeeList:
    totalEmployees += 1
    totalSalary += float(employee["salary"])
    if employee["departement"] == departmentType:
        totalEmployeesFromDepartment += 1

print("---------------")
print(f"total Salary: {round(totalSalary, 2)}$")
print(f"Average Salary: {round(totalSalary / totalEmployees, 2)}$")
print(f"Total employees: {totalEmployees}")
print(f"Employees from {departmentType}: {totalEmployeesFromDepartment}")

print("---------------")
print(f"Top 5 most earning employees:")
sortedEmployees = sorted(employeeList, key=lambda row: int(row["salary"]),reverse=True)
for i in range(5):
    topEmployee = sortedEmployees[i]
    print(f"{topEmployee['first_name']} {topEmployee['last_name']} earning: {topEmployee['salary']}$")

employeeFile.close()