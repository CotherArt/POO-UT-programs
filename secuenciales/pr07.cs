// 7. PROGRAMA QUE CALCULE EL SALARIO DE UN TRABAJADOR, 
// SE DEBERA SOLICITAR EL NOMBRE, LA CANTIDAD DE HORAS 
// TRABAJADAS Y EL PAGO POR HORA, IMPRIMIR UN M,ENSAJE 
// QUE DIGA EL NOMBRE Y CUANTO FUE SU SALARIO.
using System;
public class pr07 {
    public pr07(){
        string nombre;
        int horasTrab, pagoHora, resultado;
        
        Console.Write("Nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Horas trabajadas: ");
        horasTrab = int.Parse(Console.ReadLine());
        Console.Write("Pago por hora: $");
        pagoHora = int.Parse(Console.ReadLine());

        resultado = horasTrab * pagoHora;
        Console.WriteLine("El salario de " + nombre + " es: $" + resultado);
    }
}