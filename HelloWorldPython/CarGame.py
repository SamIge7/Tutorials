command = ""
isCarStarted = False

while command.lower() != "quit":
    command = input("> ")
    if command.lower() == "start":
        if not isCarStarted:
            print("Car has been started")
            isCarStarted = True
        else:
            print("Car has already been started")
    elif command.lower() == "stop":
        if isCarStarted:
            print("Car has stopped")
            isCarStarted = False
        else:
            print("Car is already stopped")
    elif command.lower() == "quit":
        break
    elif command.lower() == "help":
        print("start - start the car")
        print("stop - stop the car")
        print("quit - quit the program")
    else:
        print("I don't understand that command....")