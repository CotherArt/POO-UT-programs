// Programa 66: Programa que sume 2 numeros (con funciones)
using System;

public class pr66 {
    public pr66() {
        int num1, num2;

        Console.Write("Ingrese un numero: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese otro numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(suma(num1,num2));
    }

    static int suma(int num1, int num2){
        return num1 + num2;
    }
}