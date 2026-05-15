contra=str(input("Cree se contraseña: "))



intentos=0

print("----------------------------")
print("|    VALIDAR CONTRASEÑA    |")
print("----------------------------")


while intentos<3:
    veri=str(input("Ingrese su contraseña: "))
    if veri==contra:
        print("¡Contraseña verificada exitosamente!\n")
        break
    else:
        intentos+=1
        print(f"Contraseña incorrecta. Intento N°{intentos}/3.")
else:
    print("Se acabaron los intentos. Cerrando el programa...")
        
    
