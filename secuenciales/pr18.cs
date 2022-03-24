// Programa 18. Pedir un numero e indicar si es par o impar
using System;
public class pr18{
    public pr18(){
        int numero;

        Console.Write("Ingrese numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0){
            Console.WriteLine("Tu numero es par");
        }
        else{
            Console.WriteLine("Tu numero es impar");
        }
    }
}