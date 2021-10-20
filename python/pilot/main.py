pilotName = input("Pilot name:\n")
airplaneName = input("Airplane name:\n")
altitude = ''
while altitude is not int:
    try:
        altitude = int(input("Current altitude in feet:\n"))
        break
    except ValueError:
        print("Please enter a valid number,\nCurrent altitude in feet:\n")

prefferedAltitude = int(input("preffered altitude in feet:\n"))

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
  
print(f"\n\nPilot name:{pilotName}\nAirplane name: {airplaneName}\nAltitude:{altitude}\nPreffered altitude: {prefferedAltitude}\nTurbulance: {turbulance}\nFlight time: {flightTime}\nDestination: {destination}\nArrival time: {arrivalTime}\nPoint of interest: {pointofInterest}\nWeather condition: {weatherCondition}\nFlight Weather: {flightWeather}\nDestination weather: {destinationWeather}\nDegrees: {degrees}\n")
