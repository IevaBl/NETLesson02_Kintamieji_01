// See https://aka.ms/new-console-template for more information

/* PAPILDYTI PROGRAMĄ NR3 IR PRIDĖTI:
 * •NAMO STATYMO PRADŽIOS DATĄ
 * •KIEK METŲ STATĖ NAMĄ
 * •VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ */

string miestas = "Vilnius";
string gatve = "Stadiono g.";
int numeris = 1;

var statybuPradzia = Convert.ToDateTime("1986-03-05");
var statybuPabaiga = Convert.ToDateTime("1988-08-01");
var statybuLaikas = statybuPabaiga.Subtract(statybuPradzia);
int metai = Convert.ToInt32(statybuLaikas.TotalDays);


Console.WriteLine($"{miestas}, {gatve}{numeris}, {metai/365}");
