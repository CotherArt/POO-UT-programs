//Programa 78. Programa que calcula operaciones basicas. suma, resta, multiplicacion, division
//utilidado POO
using System;

public class Operacion{
    public int opc;
    public static double num1, num2, resultado;

    public void suma(){
        resultado = num1 + num2;
    }

    public void resta(){
        resultado = num1 - num2;
    }

    public void multiplicacion(){
        resultado = num1 * num2;
    }

    public void division(){
        resultado = num1 / num2;
    }
    public void Imprimir(){
        Console.WriteLine($"El resultado es: {resultado}");
    }
    public void menu(){
        Console.WriteLine("Que operacion quiere usted");
        Console.WriteLine("1. suma");
        Console.WriteLine("2. resta");
        Console.WriteLine("3. multiplicacion");
        Console.WriteLine("4. division");
        Console.WriteLine("5. salir");
        opc = int.Parse(Console.ReadLine());
    }
    public void leerDatos(){
        Console.WriteLine("Ingrese el primer numero");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = double.Parse(Console.ReadLine());
    }
}

//public class Program{
    //public static Operacion op = new Operacion();
    //public static void Main(string[] args)
    //{
        //do{
            //op.menu();
            //if(op.opc != 5) op.leerDatos();
            //switch(op.opc){
                //case 1:
                    //op.suma();
                    //break;
                //case 2:
                    //op.resta();
                    //break;
                //case 3:
                    //op.multiplicacion();
                    //break;
                //case 4:
                    //op.division();
                    //break;
                //case 5:
                    //Console.WriteLine("Saliendo del programa");
                    //break;
                //default:
                    //Console.WriteLine("Opcion no valida");
                    //break;
            //}
            //if(op.opc != 5) op.Imprimir();
        //}while(op.opc != 5);
    //}
//}