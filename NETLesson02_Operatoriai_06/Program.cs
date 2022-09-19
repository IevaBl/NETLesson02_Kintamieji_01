// See https://aka.ms/new-console-template for more information

/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI TEKSTO EILUTE. 
 * PROGRAMA TURI PARODYTI AR EILUTĖ YRA TUŠČIA (TRUE/FALSE)
 * PVZ: EILUTĖ TUŠČIA -> FFALSE */
Console.WriteLine("Iveskite teksto eilute arba palikite ja tuscia:");
var eilute = Console.ReadLine();
bool ats = !string.IsNullOrEmpty(eilute);
Console.WriteLine(ats);
