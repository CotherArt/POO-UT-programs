// Programa 17. Pedir el total de compra, si el total de compra es > a 2000
// aplicar descuento de 10%
using System;
public class pr17
{
    public pr17()
    {
        double totalCompra, totalPagar;

        Console.Write("Dame el total de compra: $");
        totalCompra = double.Parse(Console.ReadLine());

        if (totalCompra >= 2000){
            Console.WriteLine("Se aplica el descuento de 10%");
            totalPagar = totalCompra * 0.9;
        }
        else{
            Console.WriteLine("No se aplica descuento");
            totalPagar = totalCompra;
        }

        Console.WriteLine("El total a pagar es de: $" + totalPagar);
    }
}