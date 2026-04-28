
año = int(input("Ingrese un año: "))

# El if indica si el año es bisiesto

if (año % 4 == 0 and año % 100 != 0 or año % 400 == 0):
    print("\nEl año es bisiesto.")
else:
    print("\nEl año no es bisiesto.")

if año % 2 == 0:
   print("El año es par.")
else:
    print("El año es impar.")