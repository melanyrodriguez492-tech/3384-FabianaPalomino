# Pedir al usuario un número para generar su tabla de multiplicar
numero = int(input("Ingrese un número para generar su tabla de multiplicar: "))

# Generar la tabla de multiplicar hasta el 10
for i in range(1, 11):  # range(1, 11) genera números del 1 al 10
    resultado = numero * i
    print(f"{numero} x {i} = {resultado}")
