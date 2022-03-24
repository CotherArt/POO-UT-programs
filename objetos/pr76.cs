//Programa 76. Programa que calcula el factorial de un numero solicitado al usuario
//usando POO
using System;

public class Factorial{
    public int num;
    public int fact = 1;
        
    public void ingresarDato(){
        Console.WriteLine("Dame el numero ");
        num = int.Parse(Console.ReadLine());
    }

    public void calculaFact(){
        for (var i = num; i >= 1; i--)
        {
            fact = fact * i;
        }
    }

    public void imprimirFact(){
        Console.WriteLine("El resultado es: " + fact);
    }

    //public static void Main(string[] args)
    //{
        //Factorial fact1 = new Factorial();
        //fact1.ingresarDato();
        //fact1.calculaFact();
        //fact1.imprimirFact();
    //}
}