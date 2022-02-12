//Programa 2: Programa que pida el nombre y la edad de una persona 
// e imprima el siguiente mensaje: "Buenos dias , tu nombre es <nombre> y tienes <edad> años
using System;
public class pr02{
    public pr02(){
        int edad;
        String nombre;
        Console.WriteLine("Dame tu nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Dame tu edad");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Buenos dias, tu nombre es " + nombre + " y tienes " + edad + " anios");
    }
}
