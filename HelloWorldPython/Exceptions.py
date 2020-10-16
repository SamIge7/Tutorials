try:
    age = int(input("Age: "))
    print(age)
except ValueError:
    print("Your input was not a number")