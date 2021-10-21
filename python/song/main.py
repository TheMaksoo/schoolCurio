songinfo = open("song\song.txt", "r")
songtext = songinfo.read()

for line in songtext:
    print(line, end="")