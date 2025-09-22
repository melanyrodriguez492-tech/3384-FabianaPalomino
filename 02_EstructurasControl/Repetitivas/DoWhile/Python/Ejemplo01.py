# Validación de entrada de usuario: Este ejemplo pide al usuario que ingrese un número 
# y continúa pidiéndolo hasta que se ingrese un valor positivo
numero = None  # Inicializar para el bucle

while True:  # Simula un do-while: ejecuta al menos una vez
    print("Por favor, ingrese un número positivo:")
    try:
        numero = int(input())  # Convierte la entrada a entero
        if numero <= 0:
            print("Entrada no válida. El número debe ser positivo.")
        else:
            break  # Sale del bucle si es positivo
    except ValueError:
        print("Entrada no válida. Por favor, ingrese un número entero.")

print(f"Gracias! Ha ingresado el número positivo: {numero}")
input("Presione Enter para continuar...")  # Pausa equivalente a ReadKey()
