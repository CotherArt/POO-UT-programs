// Programa 12: programa que calcule el área y perimetro de un círculo 
// solicitar los datos al usuario.
using System;

public class pr12 {
    public pr12(){
        double radio, area, perimetro;
        
        Console.Write("Ingrese el radio del circulo: ");
        radio = double.Parse(Console.ReadLine());

        perimetro = 2 * Math.PI * radio;
        area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine("El perimetro del circulo es: " + perimetro + " unidades");
        Console.WriteLine("El area del circulo es: " + area + " unidades");
    }
}