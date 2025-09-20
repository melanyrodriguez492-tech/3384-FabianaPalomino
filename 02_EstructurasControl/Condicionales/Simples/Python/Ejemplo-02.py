# Pedir al usuario la cantidad de horas trabajadas en la semana
horas_trabajadas = int(input("Ingrese la cantidad de horas trabajadas en la semana: "))

# Verificar si el empleado cumplió con el mínimo de horas
if horas_trabajadas >= 6:
    print("El empleado cumplió con el mínimo de horas trabajadas, se le pagará $400.00")
else:
    print("El empleado no cumplió con el mínimo de horas trabajadas, no se le pagará.")
