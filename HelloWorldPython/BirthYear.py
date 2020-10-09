import datetime
birth_year = int(input('Birth year: '))
current_year = datetime.datetime.now().year
age = current_year - birth_year
print(age)