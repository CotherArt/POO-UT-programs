// Programa 20. Programa que lea 2 numeros y diga cual es el mayor
using System;
public class pr20{
    public pr20(){
        int numero1, numero2, mayor;

        Console.Write("Ingrese el primer numero: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        numero2 = int.Parse(Console.ReadLine());

        mayor = numero1;

        if(numero2 > numero1){
            mayor = numero2;
        }
        Console.WriteLine("El numero mayor es el: " + mayor);
    }
}