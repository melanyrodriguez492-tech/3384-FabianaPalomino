# Pedir al usuario una cadena de texto para invertirla
cadena = input("Ingrese una cadena de texto para invertirla: ")
cadena_invertida = ""

# Recorrer la cadena de atrás hacia adelante para invertirla
for i in range(len(cadena) - 1, -1, -1):  # range descendente: desde len-1 hasta 0
    cadena_invertida += cadena[i]

print("La cadena invertida es: " + cadena_invertida)
