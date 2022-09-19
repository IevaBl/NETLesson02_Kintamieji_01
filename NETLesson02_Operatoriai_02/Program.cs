// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI APKEIČIA DVIEJŲ  KINTAMŲJŲ REIKŠMES: A = 1, B = 15 */
int holder;
int A = 1;
int B = 15;
Console.WriteLine($"Buvo => {A} ir {B}");
holder = A;
A = B; 
B = holder;

Console.WriteLine($"Dabar yra => {A} ir {B}");

