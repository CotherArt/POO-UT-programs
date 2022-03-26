//Programa 79. Programa que realize conversiones de cm a mts y de mts a cm. usando POO
using System;

public class Conversor{
    public double distancia, resultado;
    public int opcion;

    public void ToMetros(){ // Centimetros a metros
        resultado = distancia / 100;
    }
    public void ToCentimetros(){
        resultado = distancia * 100;
    }
    public void Menu(){
        Console.WriteLine("Conversor de cm a mts y mts a cm");
        Console.WriteLine("1. Centimetros a Metros");
        Console.WriteLine("2. Metros a Centrimetros");
        Console.WriteLine("3. salir");
        opcion = int.Parse(Console.ReadLine());
    }
    public void PedirDatos(){
        if(opcion == 1){
            Console.Write("Dame la distancia en cm: ");
            distancia = double.Parse(Console.ReadLine());
        }
        if(opcion == 2){
            Console.Write("Dame la distancia en mts: ");
            distancia = double.Parse(Console.ReadLine());
        }
    }
    public void Imprimir(){
        if(opcion == 1) Console.WriteLine($"|{distancia}cm = {resultado}mts|");
        if(opcion == 2) Console.WriteLine($"|{distancia}mts = {resultado}cm|");
    }
}

//public class Program{
    //public static Conversor obj = new Conversor();
    //public static void Main(string[] args)
    //{
        //do{
            //obj.Menu();
            //obj.PedirDatos();
            //if(obj.opcion == 1) obj.ToMetros();
            //if(obj.opcion == 2) obj.ToCentimetros();
            //obj.Imprimir();
        //}while(obj.opcion != 3);
    //}
//}