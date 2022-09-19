/* PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
 * •MOKYKLOS PAVADINIMĄ
 * •KURSO PAVADINIMĄ
 * •STUDENTŲ SKAIČIŲ 
 * •ŠIANDIENOS DATĄ
 * •VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ */

using System;

namespace NETLEsson02_Kintamieji_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pavadinimas = "CodeAcedemy";
            string kursas = ".NET";
            string studentai = Convert.ToString(19);           
            DateTime data = new DateTime(2022, 09, 05);
            string pradzia = Convert.ToDateTime(data).ToString("yyyy-MM-dd");
            Console.WriteLine($"Mokyklos pavadinimas => {pavadinimas}");
            Console.WriteLine($"Kurso pavadinimas => {kursas}");
            Console.WriteLine($"Studentu skaicius => {studentai}");
            Console.WriteLine($"{pradzia}");
        }
    }
}
