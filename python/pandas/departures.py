import pandas as pd
import os
from datetime import datetime
from datetime import timedelta

data = pd.read_excel("python\\pandas\\departures.xlsx")


print("1 = Filteren op land.")
print("2 = Filteren op datum.")
print("3 = aantal bestemmingen voor vliegmaatschappijen")
print("-----------------------")
choice = input("Keuze 1, 2 of 3: ")

os.system("cls")


averagePersons = data["passengers_expected"].mean()

data_sorted = data.sort_values("passengers_expected", ascending = False)
top5 = data_sorted.head(5)

print(top5)
print("\n")
print(int(averagePersons))

if choice == "1":
    country = input("Land:")
    filter = (data["destination"] == country)
    filteredData = data[filter]
    amount = filteredData["destination"].count()
    print(f"Aantal vluchten uit: {country} = {amount}")

if choice == "2":
    data["departure"] = pd.to_datetime(data["departure"], format="%d/%m/%Y")
    filter = (data["departure"] > datetime.now())
    filteredData = data[filter]
    amount = filteredData["departure"].count()
    print(f"Aantal vluchten vandaag: {amount}")

if choice == "3":
    data_pivoted = data.pivot_table(index="departure", columns="airline", values="passengers_expected", aggfunc=sum)
    print(data_pivoted)

