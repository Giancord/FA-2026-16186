continuar="S"

def suma(x,y)->None:
    print(f"\nLa suma es: {x+y}")

def resta(x,y)->None:
    print(f"\nLa resta es: {x-y}")

def mult(x,y)->None:
    print(f"\nLa multiplicación es: {x*y}")

def divi(x,y)->None:
    if y==0:
        print("\nNo se puede dividir entre 0.")
    else:
        print(f"\nLa división es: {x/y}")


print("----CALCULADORA----")
print("OPCIONES: ")
print("1. Suma")
print("2. Resta")
print("3. Multiplicación")
print("4. División")


while(True):
    opt=int(input("Ingrese el código de la operación a realizar: "))

    if opt>0 and opt<=4:
     x=int(input("Ingrese el primer número: "))
     y=int(input("Ingrese el segundo número: "))

     match opt:
             case 1:
               suma(x,y)
             case 2:
               resta(x,y)
             case 3:
               mult(x,y)
             case 4:
               divi(x,y)
             case default:
               print("Ingrese un código válido.")
    else:
     print("Ingrese un código válido.")



    continuar=input("¿Desea continuar? (S) para continuar: ")

    if continuar.upper()!="S":
        print("Saliendo del programa...")
        break





