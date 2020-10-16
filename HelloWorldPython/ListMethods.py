numbers = [5, 5, 5, 6, 7, 4, 6, 10]
uniques = []
for number in numbers:
    if number not in uniques:
        uniques.append(number)
print(uniques)