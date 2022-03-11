// Programa 67: Programa que lee un numero y calcule su factorial usando metodos.
using System;

public class pr67 {

    static int leernumero(){
        Console.Write("Ingrese un numero: ");
        return int.Parse(Console.ReadLine());
    }

    static int factorial(int numero){
        int fact = 1;
        for (int i = numero; i>=1; i--) 
        {
            fact *= i;
        }
        return fact;
    }

    public pr67() {
        int numero = leernumero();
        Console.WriteLine(factorial(numero));
    }
}