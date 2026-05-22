#Método con retorno sin parámetros.

def suma()->int:
    x=int(input("Ingrese el primer número: "))
    y=int(input("Ingrese el segundo número: "))
    return x+y

print("La suma es: ", suma())
