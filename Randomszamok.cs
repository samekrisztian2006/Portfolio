// 1 feladat
Random x = new Random();
int y = x.Next(0, 100);
Console.WriteLine(y);*/
// 2 feladat
Random x = new Random();
int y = x.Next(0, 50);
int z = x.Next(0, 50);
int g = x.Next(0, 50);

Console.WriteLine($"{y},{z},{g}");
//
Random x = new Random();
double y = x.NextDouble();
Console.WriteLine(y);
//
// 4 feladat
Random x = new Random();
int y = x.Next(0, 100);
Console.WriteLine(y);

if (y%2 == 0)
{
    Console.WriteLine("Páros");
}else
{
    Console.WriteLine("Páratlan");
}
// 5 feladat
Random x = new Random();
int a = x.Next(0, 90);
int b = x.Next(0, 90);
int c = x.Next(0, 90);
int d = x.Next(0, 90);
int e = x.Next(0, 90);


Console.WriteLine($"{a},{b},{c},{d},{e}");*/
