filas = int(input("Ingrese la cantidad de filas: "))
columnas=int(input("Ingrese la cantidad de columnas: "))

print()
i=0

while(i<filas):
    j=0
    while j<columnas:
        print("*", end=" ")   #end=" " lo que está dentro de las comillas es lo que se imprimirá.
        j+=1
    print()
    i+=1