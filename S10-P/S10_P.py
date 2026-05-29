from cajero import cajero
c= cajero() #c almacena la clase cajero

continuar="si"

while continuar=="si":
    print("BIENVENIDO AL SISTEMA DE CAJERO\n")
    print("\nOPCIONES: ")
    print("1.Consultar saldo.")
    print("2.Depositar dinero.")
    print("3.Retirar dinero.")
    print("4.Salir.\n")

    while True:

        opc=int(input("Ingrese una opción: "))
        if opc in(1,2,3,4):
            break
        else:
            print("Opción ingresada no válida. Ingrese un número entre el 1 y el 4.")

    continuar=input("\n¿Desea continuar? escriba [si]")
    




