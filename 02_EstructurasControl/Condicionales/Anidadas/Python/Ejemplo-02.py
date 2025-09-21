# Entrada de datos
monto_compra = float(input("Ingrese el monto total de la compra: "))
color_bolita = int(input("Ingrese el color de la bolita (1-Verde, 2-Amarilla, 3-Negra, 4-Blanca): "))

# Proceso: Calcular el monto a pagar según el color de la bolita
if color_bolita == 1:  # Bolita verde - 20% descuento
    monto_pagar = monto_compra - (monto_compra * 0.20)
    print(f"El monto a pagar con el descuento de la bolita verde es: ${monto_pagar}")
elif color_bolita == 2:  # Bolita amarilla - 25% descuento
    monto_pagar = monto_compra - (monto_compra * 0.25)
    print(f"El monto a pagar con el descuento de la bolita amarilla es: ${monto_pagar}")
elif color_bolita == 3:  # Bolita negra - 30% descuento
    monto_pagar = monto_compra - (monto_compra * 0.30)
    print(f"El monto a pagar con el descuento de la bolita negra es: ${monto_pagar}")
elif color_bolita == 4:  # Bolita blanca - 0% descuento
    monto_pagar = monto_compra
    print(f"El monto a pagar sin descuento de la bolita blanca es: ${monto_pagar}")
else:
    print("Color de bolita no válido.")
