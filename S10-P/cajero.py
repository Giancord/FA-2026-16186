class cajero:
    saldo=1000



    def Consultar(self) ->float: #self permite compartir una variable global entre diferentes clases (ej: saldo), solo hace eso
        return self.saldo

    def Depositar(self, monto)->None:
        while True:
            try: #para evaluar algo
                m=float(monto)
                if monto>0:
                    self.saldo+=monto
                    print("\nDepósito exitoso.")
                    break
                else:
                    print("\nMonto ingresado negativo.")
                    break
            except ValueError: #En caso try no sea verdadero, para que no de error se muestra lo que esta aca.
                print("\nError: Ingrese solo números válidos.")
                break






