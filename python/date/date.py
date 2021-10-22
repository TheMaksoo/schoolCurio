from datetime import date, datetime
yesterday = "21-10-2021"
tomorrow = "23-10-2021"

yesterday = datetime.strptime(yesterday, "%d-%m-%Y")
tomorrow = datetime.strptime(tomorrow, "%d-%m-%Y")

if yesterday < datetime.now():
    print("Gister is voor nu!")

if tomorrow > datetime.now():
    print("morgen is na nu!")