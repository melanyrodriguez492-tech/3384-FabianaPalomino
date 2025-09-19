# Pedir la cantidad de alumnos de cada carrera
sis = int(input("Ingrese la cantidad de alumnos de Ing. De Sistemas: "))
adm = int(input("Ingrese la cantidad de alumnos de Administración de Empresas: "))
cont = int(input("Ingrese la cantidad de alumnos de Contabilidad: "))
# Calcular el total de alumnos
total = sis + adm + cont
# Calcular el porcentaje de cada carrera
porSis = (sis / total) * 100
porAdm = (adm / total) * 100
porCont = (cont / total) * 100
# Mostrar los resultados
print(f"El porcentaje de alumnos de Ing. De Sistemas es: {porSis}%")
print(f"El porcentaje de alumnos de Administración de Empresas es: {porAdm}%")
print(f"El porcentaje de alumnos de Contabilidad es: {porCont}%")
