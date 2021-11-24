import pandas as pd
import os
from datetime import datetime
from datetime import timedelta
import matplotlib.pyplot as plt

reportfile = open("report.txt", "w")
data = pd.read_excel("flights_2019.xlsx")
isRunning = True


while isRunning == True:
    isChoiceRunning = True
    print("1 = gemiddelde aantal passagiers.")
    print("2 = Top X van vluchten met meeste passagiers")
    print("3 = aantal vluchten naar 'bestemming'")
    print("4 = Toon draaitabel van maanden versus airlines, met som vanpassagiers")
    print("5 = Stop")          
    print("-----------------------")
    choice = input("Keuze 1, 2, 3, 4 of 5: ")

    os.system("cls")
    while isChoiceRunning == True:    
        reportfile.write("\n\n")

        if choice == "1":
            averagePersons = data["passengers"].mean()
            print(f"gemiddelde passagiers: {int(averagePersons)}")

        if choice == "2":
            topAmount = ''
            while topAmount is not int:
                try:
                    topAmount = int(input("voer nummer in: "))
                    break
                except ValueError:
                    print("Voer geldig nummer in.")

            data_sorted = data.sort_values("passengers", ascending = False)
            top = data_sorted.head(int(topAmount))  
            print(top)
            topString = top.to_string()
            reportfile.write(topString)

        if choice == "3":
            country = input("Land:")
            filter = (data["destination"] == country)
            filteredData = data[filter]
            amount = filteredData["destination"].count()
            msg = (f"Aantal vluchten uit: {country} = {amount}")
            print(msg)
            reportfile.write(str(msg))

        if choice == "4":
            data["departed"] = pd.to_datetime(data["departed"], format="%d/%m/%Y")
            data["departed"] = data["departed"].dt.strftime("%Y-%m")
            data_pivoted = data.pivot_table(index="departed", columns="airline", values="passengers", aggfunc=sum)
            print(data_pivoted)
            data_pivotedString = data_pivoted.to_string()
            reportfile.write(data_pivotedString)
            sums = data.groupby("departed")["passengers"].sum()

            sums.plot(stacked = True)
            plt.show()
            
            sums.plot(kind="barh", stacked = True)
            plt.show()
            
        if choice == "5":
            isChoiceRunning = False
            isRunning = False
        else:
            print("----------------------------")
            stop = input("Druk op enter om door te gaan of typ 'X'\n")
            os.system('cls')
            if stop.lower() == "x":
                isChoiceRunning = False

reportfile.close()