songinfo = open("song\song.txt", "r")
output = open("song\output.txt", "w")

linecount = 0
wordcount = 0
for line in songinfo:
    print(line, end="")
    linecount += 1
    words = len(line.split())
    wordcount += words
    output.write(f"{words} | {line}")

print("--------------")
print(f"Lines: {linecount}")
print(f"Words: {wordcount}")

songinfo.close()
output.close()