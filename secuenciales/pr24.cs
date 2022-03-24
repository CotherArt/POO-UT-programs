// Programa 24. Programa que pide una letra y te diga si es vocal o consonante
using System;
public class pr24{
    public pr24(){
        char letra;

        Console.WriteLine("Dame una letra: ");
        letra=char.Parse(Console.ReadLine().ToLower());

        switch (letra)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Es vocal");
                break;
            default:
                Console.WriteLine("Es consonante");
                break;
        }
    }
}