// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI 2 SKAIČIUS. 
 * PIRMĄ SKAIČIŲ PADIDINTI 1, ANTRĄ –SUMAŽINTI 1. NAUDOTI ++/-- */
Console.WriteLine("Iveskite du skaicius:");
int sk1 = Int32.Parse(Console.ReadLine());
int sk2 = Int32.Parse(Console.ReadLine());
Console.WriteLine($"{++sk1} {--sk2}");
