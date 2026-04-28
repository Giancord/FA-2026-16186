import math

print("------SISTEMA DE CÁLCULO DE ÁREAS------")
print("\n(1) Área de un cuadrado.")
print("(2) Área de un rectángulo.")
print("(3) Área de un triángulo.")
print("(4) Área de un círculo.\n")
opcion = int(input("Elija una opción: "))


match (opcion):
    case 1:
        L = int(input("Ingrese el lado del cuadrado: "))
        area = L * L
        print(f"\nEl área del cuadrado es de: {area} metros cuadrados.")
    case 2:
        b = int(input("Ingrese la base del rectángulo: "))
        a = int(input("Ingrese la altura del rectángulo: "))
        area = b * a
        print(f"\nEl área del rectángulo es de: {area} metros cuadrados.")
    case 3:
        bt = float(input("Ingrese la base del triángulo: "))
        at=float(input("Ingrese la altura del triángulo: "))
        area = (bt * at)/2
        print(f"\nEl área del triángulo es de: {area} metros cuadrados.")
    case 4:
        r=float(input("Ingrese el radio del círculo: "))
        area = math.pi * math.pow(r, 2); 
        print(f"\nEl área del círculo es de: {area} metros cuadrados.")
    case default:
        print("Ha ingresado una opción incorrecta.")

