// Programa26. Programa que introduzca una calificacion en letra (A-E) y emita el mensaje segun la letra


using System;
					
public class pr26
{
	public pr26()
	{
		string nombre;
		char letra;
		Console.Write("Dame tu nombre: ");
		nombre = Console.ReadLine();
		Console.Write("Dame la calificacion: ");
		letra = char.Parse(Console.ReadLine());

		switch(letra){
			case 'A':
				Console.WriteLine($"{nombre}, tu calificacion es Excelente");
			break;
			case 'B':
				Console.WriteLine($"{nombre}, tu calificacion es Buena");
			break;
			case 'C':
				Console.WriteLine($"{nombre}, tu calificacion es Regular");
			break;
			case 'D':
				Console.WriteLine($"{nombre}, tu calificacion es Suficiente");
			break;
			case 'E':
				Console.WriteLine($"{nombre}, tu calificacion es No suficiente");
			break;
			default:
				Console.WriteLine("No es una calificacion valida");
				break;
		}
	}
}