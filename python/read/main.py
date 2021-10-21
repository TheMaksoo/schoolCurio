text = open("read\myname.txt", "r")
name = text.read()
print(name)
text.close()