recordinginfo = open("weekcheckH5/recording.txt", "r")
reportinfo = open("weekcheckH5/report.txt", "w")

linecount = 0
wordcount = 0
for line in recordinginfo:
    linecount += 1
    wordcount += len(line.split())
    
reportinfo.write(f"Aantal regels: {linecount}\n")
reportinfo.write(f"Aantal woorden: {wordcount}\n")

recordinginfo.close()
reportinfo.close()