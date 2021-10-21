maryinfo = open("marycount\mary.txt", "r")
marycount = open("marycount\mary_count.txt", "w")
linecount = 0
for line in maryinfo:
    linecount += 1
marycount.write(f"Aantal regels: {linecount}")
maryinfo.close()
marycount.close()