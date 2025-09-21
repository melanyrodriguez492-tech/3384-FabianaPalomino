# Creación del diccionario de meses
meses = {
    1: {"nombre": "Enero", "dias": 31},
    2: {"nombre": "Febrero", "dias": 28},
    3: {"nombre": "Marzo", "dias": 31},
    4: {"nombre": "Abril", "dias": 30},
    5: {"nombre": "Mayo", "dias": 31},
    6: {"nombre": "Junio", "dias": 30},
    7: {"nombre": "Julio", "dias": 31},
    8: {"nombre": "Agosto", "dias": 31},
    9: {"nombre": "Septiembre", "dias": 30},
    10: {"nombre": "Octubre", "dias": 31},
    11: {"nombre": "Noviembre", "dias": 30},
    12: {"nombre": "Diciembre", "dias": 31}
}

# Solicitud de entrada
try:
    numero_mes = int(input("Ingrese un numero del 1 al 12: "))

    # Búsqueda en el diccionario
    if numero_mes in meses:
        info_mes = meses[numero_mes]
        print(f"El mes es {info_mes['nombre']} y tiene {info_mes['dias']} dias.")
    else:
        print("Numero invalido")

except ValueError:
    print("Entrada invalida. Por favor, ingrese un numero entero.")