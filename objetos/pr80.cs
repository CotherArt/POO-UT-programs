//Programa 80. Programa que pida el precio de n articulos y calcule el total a pagar. usando POO

using System;

class Presio{
    public double total;
    public int num_articulos;

    public void PedirArticulos(){
        Console.WriteLine("Ingrese el numero de articulos");
        num_articulos = int.Parse(Console.ReadLine());

        for (int i = 0; i < num_articulos; i++)
        {
            Console.Write($"{i} articulo: ");
            total += double.Parse(Console.ReadLine());
        }
    }

    public void Imprimir(){
        Console.WriteLine($"Total a pagar: {total}");
    }
}

//class Program{
    //public static void Main(){
        //Presio obj = new Presio();
        //obj.PedirArticulos();
        //obj.Imprimir();
    //}
//}