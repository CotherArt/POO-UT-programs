// Programa 68: Programa que imprima un menú para calculo de áreas, 
// 1. Área de un circulo, 2. Área de un cuadrado, 
// 3. Área de un rectángulo, 4. Salir.  
// Deberá repetirse el menú hasta que el usuario le de la opción salir.
// usando metodos

using System;

public class pr68 {
    static double area_circulo(){
        double radio, area;
        Console.Write("Ingrese el radio del circulo: ");
        radio = double.Parse(Console.ReadLine());

        area = Math.PI * Math.Pow(radio, 2);

        return area;
    }

    static double area_cuadrado(){
        int lado, area;
        Console.Write("Ingresa el lado del cuadrado: ");
        lado = int.Parse(Console.ReadLine());

        area = lado * lado;
        
        return area;
    }

    static double area_rectangulo(){
        int alto, ancho, area;
        Console.Write("Ingresa la altura del rectangulo: ");
        alto = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el ancho del rectangulo: ");
        ancho = int.Parse(Console.ReadLine());

        area = alto * ancho;

        return area;
    }

    static int menu(){
        Console.WriteLine("---Eliga una opcion---");
        Console.WriteLine("1. Área de un circulo");
        Console.WriteLine("2. Área de un cuadrado");
        Console.WriteLine("3. Área de un rectángulo");
        Console.WriteLine("4. Salir");
        Console.Write("> ");
        return int.Parse(Console.ReadLine());
    }

    static void imprimir(double dato){
        Console.WriteLine($"El resultado es {dato} \n");
    }

    public pr68() {
        bool exit = false;
        int opcion;

        do
        {
            opcion = menu();
            switch (opcion)
            {
                case 1:
                    imprimir(area_circulo());
                    break;
                case 2:
                    imprimir(area_cuadrado());
                    break;
                case 3:                    
                    imprimir(area_rectangulo());
                    break;
                case 4:
                    exit = true;
                    break;
            }
        } while (!exit);
    }
}