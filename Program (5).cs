// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

Penz atvaltas = new Penz(400,300,3);
int db1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Euro:{db1*atvaltas.Euro}\nDollar:{db1*atvaltas.Dollar}\nDinar:{db1*atvaltas.Dinar}");
Console.WriteLine($"Váltott pénznembe az értéke: {atvaltas.Valtas(db1)}");