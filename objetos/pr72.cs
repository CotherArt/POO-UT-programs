//programa 72: Programa que calcula el area y volumen de un cubo con el valor del lado solicitado al usuario
using System;

public class Cubo2
{
    // datos
    public double lado;
    public double area;
    public double volumen;
    //metodos
    public void CalculaArea()
    {
        area = lado * lado * 6;
    }
    public void CalculaVolumen()
    {
        volumen = lado * lado * lado;
    }
}
// public class Program
// {
//     public static void Main()
//     {
//         Cubo2 miCubo1 = new Cubo2();
//         Console.WriteLine("Dame el valor del lado del cubo");
//         miCubo1.lado = double.Parse(Console.ReadLine());
//         miCubo1.CalculaArea();
//         Console.WriteLine("El area es " + miCubo1.area);
//         miCubo1.CalculaVolumen();
//         Console.WriteLine("El volumen es " + miCubo1.volumen);
//     }
// }