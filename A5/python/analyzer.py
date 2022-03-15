from asyncore import write
import pandas as pd
from datetime import datetime
import lib_bamboo as bamboo
import os
import csv

os.system("cls")
print("Working...")


data = pd.read_excel("C:\\xampp\\htdocs\\A5\\python\\Hockey_Tweede_klasse_tussenstand.xlsx")
#data["datum"] = pd.to_datetime(data["datum"], format="%d/%m/%Y")
#data = data.sort_values("datum")
dataFile = open("C:\\xampp\\htdocs\\A5\\python\\Hockey_Tweede_klasse_tussenstand.csv", "r")
dataReader = csv.DictReader(dataFile)
dataList = list(dataReader)

average = open("C:\\xampp\\htdocs\\A5\\files\\average.txt", "w", encoding="UTF-8")
zwartboek = open("C:\\xampp\\htdocs\\A5\\files\\zwartboek.txt", "w", encoding="UTF-8")
eregalerij = open("C:\\xampp\\htdocs\\A5\\files\\eregalerij.txt", "w", encoding="UTF-8")
sum = open("C:\\xampp\\htdocs\\A5\\files\\sum.txt", "w", encoding="UTF-8")

#Aantal overtredingen
overtredingen = 0
for x in dataList:
    
    print(x)
    overtredingen += int(x["overtredingen"])
sum.write(f"{overtredingen}")

sum.close()
#gemmideld per wedstrijd
overtredingen = 0
wedstrijden = 0
for x in dataList:
    wedstrijden += 1
    overtredingen += int(x["overtredingen"])
    averageshit = overtredingen / wedstrijden

rounded = int(round(averageshit, 0))
average.write(f"{rounded}")

average.close()

#top 5 meeste overtredingen

data_sorted = data.sort_values("overtredingen", ascending = False)
top = data_sorted.head(5)  
topString = top.to_string()
zwartBoek = topString
#zwatboek = bamboo.prettify(zwartBoek, type="zwartboek")
zwartboek.write(f"{zwartBoek}")


zwartboek.close()
#wedstrijdden met minder dan 2 overtredingen
eregalerijtext = ""
for x in dataList:
    
    if int(x["overtredingen"]) < 2:
        
        eregalerijtext += x["divisie"]
        eregalerijtext += x["team1"]
        eregalerijtext += x["team2"]
        eregalerijtext += x["datum"]
        eregalerijtext += x["scheidsrechter"]
        eregalerijtext += x["stadion"]
        eregalerijtext += x["bezoekersaantal"]
        eregalerijtext += x["uitslag"]
        eregalerijtext += x["overtredingen"]
        eregalerijtext += "\n"
#eregal = bamboo.prettify(eregalerij, type="eregalerij")
eregalerij.write(eregalerijtext)




eregalerij.close()


print("Done!")
