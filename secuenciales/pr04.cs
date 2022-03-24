// Programa 4: Programa que pida dos numeros enteros e imprima el resultado de la suma
using System;

public class pr04{
    public pr04(){
        //Decraracion de variables
        int num1, num2, suma;
        Console.WriteLine("Dame un numero pls ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dame otro numero pls ");
        num2 = int.Parse(Console.ReadLine());
        suma = num1 + num2;
        Console.WriteLine("El resultado de la suma es: " + suma);
    }
}