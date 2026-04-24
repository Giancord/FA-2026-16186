se = int(input("Ingrese los segundos: "))


horas = se / 3600
mi = (se % 3600) / 60
resto = se % 60

print(f"Horas: {horas}\nMinutos: {mi}\nSegundos_restantes: {resto}")
