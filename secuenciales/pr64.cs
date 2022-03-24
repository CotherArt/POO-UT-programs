// Programa 64: Programa que me imprima los primeros 100 números primos.
using System;

public class pr64 {
    public pr64() {
        int numero, divisor;

        Console.WriteLine("Programa que imprime los primeros 100 números primos");
        numero = 1;
        divisor = numero -1;

        int contador = 0; //Contador de primos
        do{
            do{
                //Si el numero es 1 o el divisor llega hasta 1, el numero es primo
                if(numero == 1 || divisor == 1){
                    contador++; //Incrementa el contador de primos
                    Console.WriteLine($"#{contador} = {numero}"); //Imprime el numero con su posicion
                    break;
                }
                //Si el se puede dividir entre cualquier divisor, no es primo
                if(numero % divisor == 0){
                    break;
                }
                divisor--;
            } while (divisor >= 0);
            //Salta al siguiente numero
            numero++;
            //Resetea el divisor
            divisor = numero -1;
        }while(contador < 100);
    }
}