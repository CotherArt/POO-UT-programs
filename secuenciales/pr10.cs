// 10. PROGRAMA QUE CALCULE EL RESULTADO DE LA SIGUIENTE OPERACIÓN,   
// 3x+10+4y, solicitar al usuario los datos "x"  y "y",
using System;

public class pr10 {
    public pr10(){
        int x, y, resultado;
        
        Console.Write("Ingresa el valor x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor y: ");
        y = int.Parse(Console.ReadLine());

        resultado = 3*x + 10 + 4*y;

        Console.WriteLine("El resultado de 3x+10+4y es :" + resultado);
    }
}