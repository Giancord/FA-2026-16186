sumap=sumai=0

while True:
    num=int(input("Ingrese números positivos, cero para terminar: "))

    if num<0:
        print("Número incorrecto. Ingrese otro")
        continue

    if num==0:
        break
    elif num%2==0:
        sumap+=num
    else:
        sumai+=num

print(f"La suma de pares es: {sumap}.")
print(f"La suma de impares es: {sumai}.")



