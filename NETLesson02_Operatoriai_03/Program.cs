// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI 2 SKAIČIUS.
 * PROGRAMA TURI IŠVESTI SKAIČIŲ SULYGINIMO REZULTATĄ (A = B) TRUE/FALSE */

Console.WriteLine("Iveskite du skaicius:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
bool ansver = A == B;
Console.WriteLine(ansver);

