/* PARAŠYTI PROGRAMĄ, 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ */

using System;

namespace NETLesson02_Kintamieji_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Siu skaiciu vidurkis yra => {(num1+num2+num3)/3}");
        }
    }
}
