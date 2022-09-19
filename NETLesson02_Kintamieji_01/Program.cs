/* PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS. 
 * PROGRAMA TURI IŠVESTI
 * •SKAIČIŲ SUMĄ
 * •SKAIČIŲ SKIRTUMĄ
 * •SANDAUGĄ
 * •DALYBĄ */

using System;

namespace NETLesson02_Kintamieji_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            double num1 = Convert.ToDouble(Console.ReadLine()); 
            double num2 = Convert.ToDouble(Console.ReadLine()); 
            
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

        }
    }
}
