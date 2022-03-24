// 21. Programa que lee un número y me imprima si el número es
// positivo, negativo o neutro
using System;
public class pr21{
    public pr21(){
        int numero;

        Console.Write("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        if(numero > 0){
            Console.WriteLine("El numero es positivo");
        }
        if(numero == 0){
            Console.WriteLine("El numero es neutro");
        }
        if(numero < 0){
            Console.WriteLine("El numero es negativo");
        }
    }
}