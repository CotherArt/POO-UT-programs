// 30. Programa que imprima el siguiente menú: 1. Grados Fahrenheit
// a Celsius, 2. Grados Celsius a Fahrenheit y calcule el resultado.

using System;
					
public class pr30{
	public pr30()
	{
		int opc;
		double grados, resultado;

        Console.WriteLine("1. Frados Fahrenheit a Celcius");
        Console.WriteLine("2. Grados Celsius a Fahrenheit");

        Console.WriteLine("Elige una opción");
        opc = int.Parse(Console.ReadLine());

		Console.Write("Ingrese los grados: ");
		grados = double.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1:
                resultado = (grados -32) / 1.8;
  				Console.WriteLine($"{grados}°F = {resultado}°C");
                break;
            case 2:
                resultado = (grados * 1.8) + 32;
  				Console.WriteLine($"{grados}°C = {resultado}°F");
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
		
	}
}