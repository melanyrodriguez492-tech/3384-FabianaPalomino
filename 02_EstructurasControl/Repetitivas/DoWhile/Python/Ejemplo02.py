# Juego de adivinanza simple: 
# El bucle se repite hasta que el usuario adivina el número secreto,
# garantizando al menos un intento.
numero_secreto = 7  # Número que el usuario debe adivinar (entre 1 y 10)

while True:  # Simula un do-while: ejecuta al menos una vez
    print("Adivina el número secreto (entre 1 y 10):")
    try:
        intento = int(input())  # Convierte la entrada a entero
        if intento != numero_secreto:
            print("Número incorrecto. Inténtalo de nuevo.")
        else:
            break  # Sale del bucle si acierta
    except ValueError:
        print("Entrada no válida. Por favor, ingrese un número entero.")

print("¡Felicidades! Has adivinado el número secreto.")
input("Presione Enter para continuar...")  # Pausa para ver el resultado
