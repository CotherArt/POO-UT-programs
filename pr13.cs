// Programa 13. Programa que calcule el área y perimetro 
// de un rectángulo pedir los datos al usuario.
using System;

public class pr13 {
    public pr13(){
        int lado1, lado2, area, perimetro;
        
        Console.Write("Ingresa el primer lado del cuadrado: ");
        lado1 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el segundo lado del cuadrado: ");
        lado2 = int.Parse(Console.ReadLine());

        perimetro = lado1*2 + lado2*2;
        area = lado1 * lado2;

        Console.WriteLine("El perimetro del cuadrado es: " + perimetro + " unidades");
        Console.WriteLine("El area del cuadrado es: " + area + " unidades");
    }
}