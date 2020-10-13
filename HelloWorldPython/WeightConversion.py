weight = int(input('Weight?: '))
conversion = input('(l)bs or (k)g?: ')

if conversion == "l":
    kgWeight = round(weight * 0.45)
    print(f"You are {kgWeight} kg")
elif conversion == "k":
    lbsWeight = round(weight/0.45)
    print(f"You are {lbsWeight} lbs")