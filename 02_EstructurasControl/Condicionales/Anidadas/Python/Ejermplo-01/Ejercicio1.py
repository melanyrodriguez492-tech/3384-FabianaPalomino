edad = int(input("Ingresa tu edad: "))

if edad >= 18:
    if edad >= 65:
        print("Eres adulto mayor.")
    else:
        print("Eres adulto.")
else:
    print("Eres menor de edad.")
