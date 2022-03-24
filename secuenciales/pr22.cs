// 22. Programa que pida un número del 1 al 7 y me indique que día
// de la semana es, por ejemplo, el 1 sería lunes. Utilizando IF
using System;
public class pr22
{
    public pr22()
    {
        int dia;
        Console.WriteLine("Dame el dia de la semana (1 al 7) ");
        dia = int.Parse(Console.ReadLine());

        if (dia == 1)
        {
            Console.WriteLine("Lunes");
        }
        if (dia == 2)
        {
            Console.WriteLine("Martes");
        }
        if (dia == 3)
        {
            Console.WriteLine("Miercoles");
        }
        if (dia == 4)
        {
            Console.WriteLine("Jueves");
        }
        if (dia == 5)
        {
            Console.WriteLine("Viernes");
        }
        if (dia == 6)
        {
            Console.WriteLine("Sabado");
        }
        if (dia == 7)
        {
            Console.WriteLine("Domingo");
        }
    }
}