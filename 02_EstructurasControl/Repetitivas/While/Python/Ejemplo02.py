# Procesamiento de un cajero automático: Mantiene un bucle que permite al
# usuario realizar múltiples transacciones hasta que decida salir.
continuar = True
print("Bienvenido al cajero automático.")

while continuar:
    print("Seleccione una opción:")
    print("1. Consultar saldo")
    print("2. Retirar dinero")
    print("3. Depositar dinero")
    opcion = input()

    if opcion == "1":
        print("Su saldo es de $1000.")
    elif opcion == "2":
        print("Ingrese la cantidad a retirar:")
        retiro = input()
        print(f"Ha retirado ${retiro}.")
    elif opcion == "3":
        print("Ingrese la cantidad a depositar:")
        deposito = input()
        print(f"Ha depositado ${deposito}.")
    else:
        print("Opción no válida.")

    print("¿Desea realizar otra transacción? (s/n)")
    respuesta = input().lower()  # Convierte a minúsculas para comparación insensible
    if respuesta != "s":
        continuar = False
        print("Gracias por usar el cajero automático. ¡Hasta luego!")

    input("Presione Enter para continuar...")  # Pausa equivalente a ReadKey()
