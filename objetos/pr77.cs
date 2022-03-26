//Programa que calcula el promedio de n calificaciones, usando POO
using System;

public class Promedio{
    public int nMaterias;
    public double promedio;
    public double sumaCalif;

    public void ingresaDatos(){
        Console.WriteLine("Dame el numero de materias");
        nMaterias = int.Parse(Console.ReadLine());

        sumaCalif = 0;
        for (int i = 1; i <= nMaterias; i++)
        {
            double calif = double.Parse(Console.ReadLine());
            sumaCalif += calif;
        }
    }

    public void calcularPromedio(){
        promedio = sumaCalif / nMaterias;
    }

    public void Imprimir(){
        Console.WriteLine("El promedio es: " + promedio);
    }
}

//class Program{
    //public static void Main(){
        //Promedio obj = new Promedio();
        //obj.ingresaDatos();
        //obj.calcularPromedio();
        //obj.Imprimir();
    //}
//}