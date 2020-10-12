hasGoodCredit = True
price = 1000000
deposit = 0
if hasGoodCredit:
    deposit = price/10
else:
    deposit = price/5
print(f"Deposit needed: £{deposit}")