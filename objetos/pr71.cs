//programa 71: Programa que calcula el area y volumen de un cubo con lado 5

using System;

class Cubo
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
//public class Program
//{
    //public static void Main()
    //{
        //cubo miCubo1 = new Cubo();
        //miCubo1.lado = 5;
        //miCubo1.CalculaArea();
        //Console.WriteLine("El area es " + miCubo1.area);
        //miCubo1.CalculaVolumen();
        //Console.WriteLine("El volumen es " + miCubo1.volumen);
    //}
//}