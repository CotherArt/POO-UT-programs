//69. Programa que imprima el siguiente menú de conversiones: 
//1. Conversión de centímetros a metros, 
//2. Conversión de metros a centímetros. utilizando métodos

using System;

public class pr69 {

    static int menu(){
        Console.WriteLine("---Eliga una opcion---");
        Console.WriteLine("1. Conversión de centímetros a metros");
        Console.WriteLine("2. Conversión de metros a centímetros");
        Console.WriteLine("3. Salir");
        Console.Write("> ");
        return int.Parse(Console.ReadLine());
    }
    static void cm_to_mts(){
        double cm, mts;
        Console.Write("Ingrese la medida en cm: ");
        cm = double.Parse(Console.ReadLine());
        mts = cm/100;

        Console.WriteLine($"{cm}cm = {mts}mts \n");
    }

    static void mts_to_cm(){
        double cm, mts;
        Console.Write("Ingrese la medida en mts: ");
        mts = double.Parse(Console.ReadLine());
        cm = mts*100;

        Console.WriteLine($"{mts}mts = {cm}cm \n");
    }

    public pr69() {
        bool exit = false;
        int opcion;

        do{
            
            opcion = menu();
            switch (opcion)
            {
                case 1:
                    cm_to_mts();
                    break;
                case 2:
                    mts_to_cm();
                    break;
                case 3:
                    exit = true;
                    break;
            }
        } while (!exit);
    }
}