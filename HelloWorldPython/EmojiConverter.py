def emoji_converter(message_string):
    words = message_string.split(' ')
    emojis = {
        ":)": "😀",
        ":(": "😔"
    }
    output = ""
    for word in words:
        output += emojis.get(word, word) + " "
    return output


message = input("> ")
result = emoji_converter(message)
print(result)
