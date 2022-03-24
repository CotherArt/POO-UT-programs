//Programa 75. Hacer un programa que mediante un menu, pueda calcular el area,
//perimetro o volumen de un circulo, triangulo, rectangulo y cuadrado;
using System;

class Programa{
    public static void Main()
    {
		bool exit = false;
		do
		{
			int opcion;
			Console.WriteLine("Que figura quiere usted?");
			Console.WriteLine("1. Circulo");
			Console.WriteLine("2. Triangulo");
			Console.WriteLine("3. Rectangulo");
			Console.WriteLine("4. Cuadrado");
			Console.WriteLine("5. Salir");
			Console.Write(">");
			opcion = int.Parse(Console.ReadLine());

			switch(opcion){
				case 1:
					Circulo myCirculo = new Circulo();
					Console.WriteLine("Ingrese el radio:");
					myCirculo.radio = double.Parse(Console.ReadLine());
					myCirculo.CalculaArea();
					myCirculo.CalculaPerimetro();
					Console.WriteLine("El area es: " + myCirculo.area);
					Console.WriteLine("El perimetro es: " + myCirculo.perimetro);
				break;
				case 2:
					Triangulo myTriangulo = new Triangulo();
					Console.WriteLine("Ingrese la base:");
					myTriangulo.base_ = double.Parse(Console.ReadLine());
					Console.WriteLine("Ingrese la altura:");
					myTriangulo.altura = double.Parse(Console.ReadLine());
					myTriangulo.CalculaArea();
					myTriangulo.CalculaPerimetro();
					Console.WriteLine("El area es: " + myTriangulo.area);
					Console.WriteLine("El permietro es: " + myTriangulo.perimetro);
				break;
				case 3:
					Rectangulo myRect = new Rectangulo();
					Console.WriteLine("ingrese la base: ");
					myRect.lado1 = double.Parse(Console.ReadLine());
					Console.WriteLine("ingrese la altura: ");
					myRect.lado2 = double.Parse(Console.ReadLine());
					myRect.CalculaArea();
					myRect.CalculaPerimetro();
					Console.WriteLine("El area es: " + myRect.area);
					Console.WriteLine("El perimetro es: " + myRect.perimetro);
				break;
				case 4:
					Cuadrado myCuad = new Cuadrado();
					Console.WriteLine("ingrese el lado: ");
					myCuad.lado1 = double.Parse(Console.ReadLine());
					myCuad.CalculaArea();
					myCuad.CalculaPerimetro();
					Console.WriteLine("El area es: " + myCuad.area);
					Console.WriteLine("El perimetro es: " + myCuad.perimetro);
				break;
				case 5:
					exit = true;
				break;
			}
		} while (!exit);
	}
}

class Triangulo{
	public double base_;
	public double altura;
	public double area;
	public double perimetro;	

	public void CalculaArea(){
		area = (base_ * altura)/2;
	}
	public void CalculaPerimetro(){
		perimetro = base_ + altura + (Math.Sqrt(Math.Pow(base_,2) + Math.Pow(altura,2)));
	}
}

class Rectangulo{
	public double lado1;
	public double lado2;
	public double area;
	public double perimetro;
	public void CalculaArea(){
		area = lado1 * lado2;
	}
	public void CalculaPerimetro(){
		perimetro = lado1 * 2 + lado2 *2;
	}
}

class Cuadrado : Rectangulo{
	public void CalculaArea(){
		area = lado1 * lado1;
	}
	public void CalculaPerimetro(){
		perimetro = lado1 * 4;
	}
}