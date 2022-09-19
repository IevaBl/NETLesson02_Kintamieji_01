// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI SKAIČIŲ, 
 * PASKUI TĄ SKAIČIŲ PARODO 4 KARTUS VIENOJE EILUTĖJE NAUDOTI {0} */
Console.WriteLine("Iveskite skaiciu:");
var input = Console.ReadLine();
Console.WriteLine($"{input} {input} {input} {input}");
