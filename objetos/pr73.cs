/*programa 73: Programa que calcula el area y volumen de un Cubo3
 con la creacion de tres objetos, en el primero el lado sera igual a 10,
 en el segundo el lado sera solicitado al usuario y en el tercero 
 el lado sera la suma del primero y del segundo*/

using System;

public class Cubo3
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
//         //Objeto1
//         Console.WriteLine("OBJETO 1");
//         Cubo3 miCubo1 = new Cubo3();
//         miCubo1.lado = 10;
//         miCubo1.CalculaArea();
//         Console.WriteLine("El area es " + miCubo1.area);
//         miCubo1.CalculaVolumen();
//         Console.WriteLine("El volumen es " + miCubo1.volumen);
//         //Objeto2
//         Console.WriteLine("OBJETO 2");
//         Cubo3 miCubo2 = new Cubo3();
//         Console.WriteLine("Dame el valor del lado del Cubo3");
//         miCubo2.lado = double.Parse(Console.ReadLine());
//         miCubo2.CalculaArea();
//         miCubo2.CalculaVolumen();
//         Console.WriteLine("El area es " + miCubo2.area);
//         Console.WriteLine("El volumen es " + miCubo2.volumen);
//         //Objeto3
//         Console.WriteLine("OBJETO 3");
//         Cubo3 miCubo3 = new Cubo3();
//         miCubo3.lado = miCubo1.lado + miCubo2.lado;
//         miCubo3.CalculaArea();
//         Console.WriteLine("El area es " + miCubo3.area);
//         miCubo3.CalculaVolumen();
//         Console.WriteLine("El volumen es " + miCubo3.volumen);
//     }
// }