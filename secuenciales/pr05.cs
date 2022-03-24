// Programa 5: Programa que lea 3 numeros enteros y calcule su producto

using System;

public class pr05{
    public pr05(){
        int num1, num2, num3, resultado;
        Console.Write("ingresa un numero: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("ingresa un numero: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("ingresa un numero: ");
        num3 = int.Parse(Console.ReadLine());

        resultado = num1 * num2 * num3;
        Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
    }
}