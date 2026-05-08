num=int(input("Ingrese la tabla del número positivo que desee: "))
i=1


while num<=0:
    num=int(input("Número inválido. Ingrese otro número: "))


while i<=12:
    print(f"{num} x {i} = {num*i}")
    i+=1




