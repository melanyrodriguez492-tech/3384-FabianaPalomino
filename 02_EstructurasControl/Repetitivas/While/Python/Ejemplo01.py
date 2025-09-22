import time  # Para simular el tiempo de descarga

# Simula la descarga de un archivo, mostrando el progreso hasta que se complete
progreso = 0
print("Descargando archivo...")

while progreso < 100:
    progreso += 10  # Incrementa el progreso en 10%
    if progreso > 100:
        progreso = 100  # Asegura que no exceda 100%
    print(f"Progreso: {progreso}%")
    time.sleep(0.5)  # Simula tiempo de descarga (500 ms)

print("Descarga completa.")
input("Presione Enter para continuar...")  # Pausa para ver el resultado
