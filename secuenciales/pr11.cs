// Programa 11. Programa que calcule el área y perimetro de un cuadrado 
// solicitar los datos necesarios al usuario.
using System;

public class pr11 {
    public pr11(){
        int lado, area, perimetro;
        
        Console.Write("Ingresa el lado del cuadrado: ");
        lado = int.Parse(Console.ReadLine());

        perimetro = lado * 4;
        area = lado * lado;

        Console.WriteLine("El perimetro del cuadrado es: " + perimetro + " unidades");
        Console.WriteLine("El area del cuadrado es: " + area + " unidades");
    }
}