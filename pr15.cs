// Programa 15. Programa que calcule el descuento y total a pagar
//  de un producto, debe solicitar al usuario el costo del producto 
// y el descuento a aplicar y calcular el total a pagar.
using System;
public class pr15 {
    public pr15(){
        float costo, total;
        int descuento;

        Console.Write("Ingrese el costo del producto: $");
        costo = float.Parse(Console.ReadLine());
        Console.Write("Ingrese el descuento en %: ");
        descuento = int.Parse(Console.ReadLine());

        total = costo - descuento * costo / 100;
        Console.WriteLine("El total a pagar es :" + total + "$");
    }
}