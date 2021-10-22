car = input("type of car:\n")
price = input("price of the car:\n")

price = int(price)

if price >= 75000:
  print("Oh that's a pricy car.")
elif price <= 5000:
  print("Oh man, you're broke")
else:
  print("Nice,, very modest!")
print(f"Wanna buy a {car}? It’s only {price + 1000} dollars!")
