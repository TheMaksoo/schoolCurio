### Input -- Noot: namen van variabelen kunnen ook verschillen in jouw uitwerking. Belangrijk is wel: gebruik camelCase en Engelse benaming.
import os
#                                                 Nummer uit opdracht:
pilotName = input("Wat is uw naam? \n")                             #1
os.system("cls")
planeType = input("Type vliegtuig: \n")                             #2
os.system("cls")
currentAltitude = input("Huidige vlieghoogte: \n")                  #3
os.system("cls")
cruisingAltitude = input("Gewenste vlieghoogte: \n")                #4
os.system("cls")
turbulenceExpected = input("Turbulentie verwacht? ja/nee \n")       #5
os.system("cls")
flightDuration = input("Vluchtduur: \n")                            #6
os.system("cls")
arrivalPlace = input("Arriveerplaats: \n")                          #7
os.system("cls")
arrivalTime = input("Arriveertijd: \n")                             #8
os.system("cls")
pointOfInterest = input("Point of interest: \n")                    #9
os.system("cls")
weatherOnFlight = input("Weersomstandigheden vlucht: \n")           #10
os.system("cls")
clearWeather = input("Helder vluchtweer? ja/nee \n")                #11
os.system("cls")
weatherOnArrival = input("Weersomstandigheden arriveerplaats: \n")  #12
os.system("cls")
temperatureOnArrival = input("Temperatuur arriveerplaats: \n")      #13
os.system("cls")

### Process
currentAltitude = int(currentAltitude)
cruisingAltitude = int(cruisingAltitude)
altitudeToClimb = cruisingAltitude - currentAltitude                #*

if(turbulenceExpected == "ja" or turbulenceExpected == "Ja"):
  typeOfRide = "bumpy ride"
else:
  typeOfRide = "smooth ride"

if(clearWeather == "ja" or clearWeather == "Ja"):
  landmarkVisible = "which will give us a chance to point out some specific landmarks"
else:
  landmarkVisible = "so we will not get to see much of the specific landmarks"

### Output
print(f"Good evening Ladies & gentlemen. This is {pilotName}, your captain for this flight. Here is some information about the flight progress. Our {planeType} is presently climbing through {currentAltitude} feet en route to our cruising altitude of {cruisingAltitude} feet so we expect a climb of {altitudeToClimb} feet. We are expecting a {typeOfRide} and our flight plan shows an en route time of {flightDuration}. We expect to arrive in {arrivalPlace} at {arrivalTime}. Our route today will take us over the {pointOfInterest}, visible on the left-hand side of the aircraft. The en route weather is {weatherOnFlight}, {landmarkVisible}. The {arrivalPlace} weather is {weatherOnArrival} and about {temperatureOnArrival} degrees Celsius. Enjoy your flight.")