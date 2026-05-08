i=int
num=int
cceros=int
cpares=int
cimpares=int
cceros=0
cpares=0
cimpares=0

cant=int(input("Ingrese la cantidad de números: "))

for i in range(0,cant):
    num=int(input(f"Ingrese el número {i+1}: "))
    if num==0:
        cceros=cceros+1
    elif num%2==0:
        cpares+=1
    else:
        cimpares+=1

print(f"Cantidad de ceros: {cceros}")
print(f"Cantidad de pares: {cpares}")
print(f"Cantidad de impares: {cimpares}")







