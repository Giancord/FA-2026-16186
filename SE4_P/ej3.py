conv= float
option = str

conv = 0
option ="soles"

monto = float(input("Ingrese un monto (soles): "))



print("---Opciones---")
print("\n(1) Convertir a dólares.")
print("(2) Convertir a euros.\n")
ops = int(input("Ingrese una opción: "))

match (ops):
    case 1:
        option = "dolares"
        conv = monto/3.75
        print(f"\nLa conversión de {monto} soles a {option} es de {conv}.")
    case 2:
        option = "euros"
        conv = monto/ 4.05
        print(f"\nLa conversión de {monto} soles a {option} es de {conv}.")
    case default:
        print("Ha ingresado una opción incorrecta.")

