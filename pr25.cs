/*Programa25. Dado el sueldo de un trabajador considerar un aumento del 15% si su sueldo es inferior a $1000 
y de un 12% en caso contrario. Imprimir el nuevo sueldo.*/
using System;
					
public class pr25
{
	public pr25()
	{
		String nombre;
		double sueldo, NSueldo;
		Console.WriteLine("Dame tu nombre");
		nombre=Console.ReadLine();
		Console.WriteLine("Dame tu sueldo actual");
		sueldo=Double.Parse(Console.ReadLine());
		
		if(sueldo<1000)
		{
			NSueldo=sueldo*1.15;
		}
		else
		{
			NSueldo=sueldo*1.12;
		}
		
		Console.WriteLine(nombre + " tu nuevo salario es " + NSueldo);
		
	}
}