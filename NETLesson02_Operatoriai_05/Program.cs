// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI STAČIAKAMPIO ILGĮ IR PLOTĮ. 
 * PROGRAMA TURI IŠVESTI STAČIAKAMPIO PLOTĄ */

Console.WriteLine("Iveskite staciakampio ilgi");
int ilgis = Int32.Parse(Console.ReadLine());
Console.WriteLine("Iveskite staciakampio ploti");
int plotis = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Staciakampio plotas yra: {ilgis*plotis}");

