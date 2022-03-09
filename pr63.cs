// Programa 63. Programa que me diga si un número es primo o no.
using System;

public class pr63 {
    public pr63() {
        int numero, divisor;

        Console.WriteLine("Programa que me diga si un número es primo o no");
        Console.Write("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());
        divisor = numero -1;
        do{
            //Si el numero es 1 o el divisor llega hasta 1, el numero es primo
            if(numero == 1 || divisor == 1){
                Console.WriteLine("El numero es primo");
                break;
            }
            //Si el numero se puede dividir entre cualquier divisor, no es primo
            if(numero % divisor == 0){
                Console.WriteLine("El numero no es primo");
                break;
            }
            divisor--;
        } while (divisor >= 0);
    }
}