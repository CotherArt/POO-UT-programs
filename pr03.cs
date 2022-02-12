// Programa 3: Programa que pida el nombre, año de nacimiento, anio actual 
// e imprima el siguiente mensaje: "Buenos dias , tu nombre es <nombre> y tienes <edad> años
using System;
public class pr03{
    public pr03(){
        //Decraracion de variables
        int edad, aNac, aAct;
        String nombre;
        //Lectura de datos
        Console.WriteLine("Dame tu nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Dame tu anio de nacimiento");
        aNac = int.Parse(Console.ReadLine());
        Console.WriteLine("Dame el anio actual");
        aAct = int.Parse(Console.ReadLine());
        edad = aAct - aNac;
        Console.WriteLine("Buenos dias, tu nombre es " + nombre + " y tienes " + edad + " anios");
    }
}