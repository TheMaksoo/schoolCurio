classList=[{"name":"Bob","number":560292,"email":"bob@example.com"},{"name":"Alice","number":293737,"email":"alice@example.com"},{"name":"Joe","number":127350,"email":"joe@example.com"},{"name":"Rick","number":947463,"email":"rick@example.com"}]

newname= ''

for student in classList:
  print(student["name"])
  
find  = input("\nName: ")

for student in classList:
  if student["name"].lower() == find.lower():
    newname = input("New Name: ")
    student["name"] = newname.capitalize()
    print(student["name"])
if newname == '':  
  print("Not found\n")
  awnser = input("Want to add a student? Yes / No\n")
  if awnser.lower() == "yes":
    name = input("Student Name:")
    number = input("Student Number:")
    email = input("Student email:")
    name = name.capitalize()

    classList.append({"name": name, "number": int(number),"email": email})
  
for student in classList:
  print("\nName: {}\nNumber: {}\nEmail: {}\n".format(student["name"], student["number"], student["email"]))