// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI SKAIČIŲ. 
 * PROGRAMA TURI PARODYTI AR SKAIČIUS MAŽESNIS UŽ 0 (TRUE/FALSE) */

Console.WriteLine("Iveskite skaiciu");
var sk = Convert.ToInt32(Console.ReadLine());
bool ats = sk > 0;
Console.WriteLine(ats);

