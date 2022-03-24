// Programa 61: Programa que imprima un menú para calculo de áreas, 
// 1. Área de un circulo, 2. Área de un cuadrado, 
// 3. Área de un rectángulo, 4. Salir.  Deberá repetirse el menú hasta que el usuario le de la opción salir.

using System;

public class pr61 {
    public pr61() {
        bool exit = false;
        int opcion;

        do
        {
            Console.WriteLine("---Eliga una opcion---");
            Console.WriteLine("1. Área de un circulo");
            Console.WriteLine("2. Área de un cuadrado");
            Console.WriteLine("3. Área de un rectángulo");
            Console.WriteLine("4. Salir");
            Console.Write("> ");
            opcion = int.Parse(Console.ReadLine());

            int lado, ancho, alto;
            double area, radio;

            switch (opcion)
            {
                case 1:
                    // Console.Clear();
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = double.Parse(Console.ReadLine());

                    area = Math.PI * Math.Pow(radio, 2);

                    Console.WriteLine("El area del circulo es: " + area + " unidades \n");
                    break;
                case 2:
                    // Console.Clear();
                    Console.Write("Ingresa el lado del cuadrado: ");
                    lado = int.Parse(Console.ReadLine());

                    area = lado * lado;

                    Console.WriteLine("El area del cuadrado es: " + area + " unidades \n");
                    break;
                case 3:                    
                    // Console.Clear();
                    Console.Write("Ingresa la altura del rectangulo: ");
                    alto = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el ancho del rectangulo: ");
                    ancho = int.Parse(Console.ReadLine());

                    area = alto * ancho;

                    Console.WriteLine("El area del rectangulo es: " + area + " unidades \n");
                    break;
                case 4:
                    exit = true;
                    break;
            }
        } while (!exit);
    }
}