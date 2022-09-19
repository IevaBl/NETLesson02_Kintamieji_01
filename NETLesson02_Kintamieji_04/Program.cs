/* PAPILDYTI PROGRAMĄ NR3 IR PRIDĖTI:
 * •KURSO PRADŽIOS DATĄ
 * •KURSO PABAIGOS DATĄ
 * •KIEK DARBO DIENŲ TRUNKA MŪSŲ KURSAS 
 * 1.Sužinoti skirtumą tarp pradžios ir pabaigos (dienomis)
 * 2.Sužinoti kiek tai savaičių
 * 3.Atimti savaitgalius ir penktadienius
 * •VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ */

using System;

namespace NETLesson02_Kintamieji_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kursoPradzia = Convert.ToDateTime("2022-09-05");
            var kursoPabaiga = Convert.ToDateTime("2023-04-14");
            var dienos = kursoPabaiga.Subtract(kursoPradzia);

            var current = kursoPradzia;
            var dd = 0;
            while (current <= kursoPabaiga)
            {
                if (current.DayOfWeek == DayOfWeek.Monday ||
                    current.DayOfWeek == DayOfWeek.Tuesday ||
                    current.DayOfWeek == DayOfWeek.Wednesday ||
                    current.DayOfWeek == DayOfWeek.Thursday
                    )
                {
                    dd++;
                }

                current = current.AddDays(1);

            }


            Console.WriteLine("Darbo dienos kuriomis mokomes: " + dd);
        }
    }
}
