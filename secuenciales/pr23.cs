// 23. Programa que pida un número del 1 al 7 y me indique que día
// de la semana es, por ejemplo el 1 sería lunes. Utilizando Switch.
using System;
public class pr23
{
    public pr23()
    {
        int dia;
        Console.WriteLine("Dame el dia de la semana (1 al 7) ");
        dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Error no existe ese dia de la semana");
                break;
        }
    }
}