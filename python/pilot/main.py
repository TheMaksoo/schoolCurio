pilotName = input("Pilot name:\n")
airplaneName = input("Airplane name:\n")
altitude = ''
while altitude is not int:
    try:
        altitude = int(input("Current altitude in feet:\n"))
        break
    except ValueError:
        print("Please enter a valid number,\nCurrent altitude in feet:\n")

prefferedAltitude = ''

while prefferedAltitude is not int:
    try:
        prefferedAltitude = int(input("preffered altitude in feet:\n"))
        break
    except ValueError:
        print("Please enter a valid number,\npreffered altitude in feet:\n")

turbulance = bool(input("Expected turbulance:\nTrue / False\n"))
flightTime = input("Flight duration:\n")
destination = input("Destination:\n")
arrivalTime = input("Time of arrival:\nLocal time.\n")
pointofInterest = input("Point of interest:\n")
weatherCondition = input("Weather condtion:\n")
flightWeather = bool(input("Clear flight weather conditions:\nTrue / False\n"))
destinationWeather = input("Weater at the destination:\n")
degrees = input("Current Temperature:\n")

if turbulance == True:
  turbulance = "Bumpy Ride"
else:
  turbulance = "Smooth ride"

if flightWeather == True:
  flightWeather = "which will give us a chance to point out some specific landmarks."
else:
  flightWeather = "so we will notget to see much of the specific landmarks."

flightDifference = prefferedAltitude - altitude
print(f"Good evening Ladies & gentlemen. This is {pilotName}, your captain for this flight. Here is some information about the flight progress. Our {airplaneName} is presently climbing through {altitude} feet en route to our cruising altitude of {prefferedAltitude} feet so we expect a climb of {flightDifference} feet. we are expecting {turbulance} and our flight plan shows an en route time of {flightTime}. We expected to arrive in {destination} at {arrivalTime}. Our route today will take us over the {pointofInterest}, visible on the left-hand side of the aircraft. The en route weather is {flightWeather}. The {destination} weather is {destinationWeather} and about {degrees} degrees Celsius. Enjoy your flight.")
