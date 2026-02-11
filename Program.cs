// See https://aka.ms/new-console-template for more information

using ConsoleApp7;


Console.WriteLine("Adja meg a hosszát:"); 
double hossz = double.Parse(Console.ReadLine());;
Console.WriteLine("Adja meg a széleségét:"); 
double szel = double.Parse(Console.ReadLine());
Class teglalap = new Class(hossz,szel);
teglalap.K_T();

Telefonszam tel = new Telefonszam();
tel.szam = Console.ReadLine();
tel.Telefonszam_Szol();
