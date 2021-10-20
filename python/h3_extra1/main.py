teacherList = ["br", "mh", "eb", "wh", "ib", "bs"]

for teacher in teacherList:
  print(teacher)
#Schrijf een for-loop die alle docenten toont:


#Haal onderstaande regel uit commentaar en maak af, vraag de gebruiker om een docent-code in te voeren:
code = input("Docent code:")


#Schrijf nog een for-loop die door alle docenten loopt:
for teacher in teacherList:
  if code != teacher:
    print(teacher)

  #Maak in de for-loop een if die ervoor zorgt dat de ingevoerde docent-code wordt overgeslagen:
  