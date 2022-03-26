//Programa 81. implementar la formula general con clases
using System;

class GeneralForm{
    public double a, b, c, x1,x2;

    public void IngresarDatos(){
        Console.WriteLine("ingrese los siguientes valores:");
        Console.Write("a=");
        a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        c = double.Parse(Console.ReadLine());
    }

    public void Calcular(){
        if((b * b) - (4 * a * c) > 0){
            Console.WriteLine("No se puede calcular por formula general chiki :c");
        }
        x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
        x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
    }

    public void Imprimir(){
        Console.WriteLine("X1 = " + x1);
        Console.WriteLine("X2 = " + x2);
    }
}

//class Program{
    //public static void Main(string[] args)
    //{
        //GeneralForm obj = new GeneralForm();
        //obj.IngresarDatos();
        //obj.Calcular();
        //obj.Imprimir();
    //}
//}