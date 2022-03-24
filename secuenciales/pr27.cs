// Programa27. Programa que solicite el numero de mes e imprima el nombre del mes


using System;
					
public class pr27{
	public pr27()
	{
		int numero_mes;

		Console.Write("Dame el numero del mes: ");
		numero_mes = int.Parse(Console.ReadLine());


		switch(numero_mes){
			case 1:
				Console.WriteLine("Enero");
				break;
			case 2:
				Console.WriteLine("Feblrero");
			break;
			case 3:
				Console.WriteLine("Marzo");
			break;
			case 4:
				Console.WriteLine("Abril");
			break;
			case 5:
				Console.WriteLine("Mayo");
			break;
			case 6:
				Console.WriteLine("Junio");
			break;
			case 7:
				Console.WriteLine("Julio");
			break;
			case 8:
				Console.WriteLine("Agosto");
			break;
			case 9:
				Console.WriteLine("Septiembre");
			break;
			case 10:
				Console.WriteLine("Octubre");
			break;
			case 11:
				Console.WriteLine("Noviembre");
			break;
			case 12:
				Console.WriteLine("Diciembre");
			break;
			default:
				Console.WriteLine("No es un dato valido");
				break;
		}
	}
}