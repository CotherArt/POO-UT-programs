//Programa 74. Programa que calcula el area y el perimetro de un circulo. usando objeros
using System;

class Circulo{
	public double radio;
	public double area;
	public double perimetro;

	public void CalculaArea(){
		area = 3.1416 * (radio * radio);
	}

	public void CalculaPerimetro(){
		perimetro = 2 * radio * 3.1416;
	}
}

// class Program{
// 	public static void Main(){
// 		Circulo cir1 = new Circulo();
// 
// 		cir1.radio = 4;
// 		cir1.CalculaArea();
// 		cir1.CalculaPerimetro();
// 		Console.WriteLine("El area es: " + cir1.area);
// 		Console.WriteLine("El perimetro es: " + cir1.perimetro);
// 	}
// }
