secretNumber = 7
guessCount = 0
guessLimit = 3
while guessCount < guessLimit:
   guess = int(input("Guess the number: "))
   guessCount += 1
   if guess == secretNumber:
       print("You win the game!")
       break
   elif guess != secretNumber and (guessLimit - guessCount) > 1:
       print(f"Incorrect guess, you have {guessLimit - guessCount} guesses remaining")
   else:
       print(f"Incorrect guess, you have 1 guess remaining")
else:
    print("You lose the game :(")

