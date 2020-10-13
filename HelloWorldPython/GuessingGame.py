secretNumber = 7
guessCount = 0
guessLimit = 3
while guessCount < guessLimit:
   guess = int(input("Guess the number: "))
   guessCount += 1
   if guess == secretNumber:
       print("You win the game!")
       break
else:
    print("You lose the game :(")

