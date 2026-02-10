using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

Random szam = new Random();
int[] szamok = new int[20];
int[] negativ_szamok = new int[20];
int[] kivallogatott = new int[20];
int[] abszulut = new int[20];

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = szam.Next(10,51);
}
for (int i = 0; i < abszulut.Length; i++)
{
    abszulut[i] = szam.Next(-20,20);
}

// 1 feladat
Console.WriteLine("1 Feladat");
for (int i = 0; i < szamok.Length; i++)
{
    Console.Write($"{szamok[i]} ");
}
// 2 feladat
Console.WriteLine("2 Feladat");
for (int i = 0; i < szamok.Length; i++)
{
    Console.WriteLine($"{szamok[i]}");
}
// 3 feladat
Console.WriteLine("3 Feladat");
for (int i = 0; i < negativ_szamok.Length; i++)
{
    negativ_szamok[i] = szam.Next(-101,-1);
}
for (int i = 0; i < negativ_szamok.Length; i++)
{
    Console.Write(negativ_szamok[i] + "");
}
// 4 feladat
Console.WriteLine("4 Feladat");
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] % 2 == 0 && szamok[i] > 0)
    {
        Console.WriteLine($"{szamok[i]}");
    }
}
// 5 feladat
Console.WriteLine("5 Feladat");
Console.WriteLine(szamok[0]);
Console.WriteLine(szamok[19]);
// 6 feladat
Console.WriteLine("6 Feladat");
for (int i = 0; i < szamok.Length; i=i+2)
{
    Console.WriteLine(szamok[i]);
}
// 7 feladat
Console.WriteLine("7 Feladat");
int min = szamok[0];
for (int i = 0; i < szamok.Length; i++)
{
    if(szamok[i] < min)
    {
        min = szamok[i];
    }
}
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] > min)
    {
        kivallogatott[i] = szamok[i];
    }
}
Console.WriteLine(min);
for (int i = 0; i < szamok.Length; i++)
{
    Console.Write(kivallogatott[i] + " ");
}
Console.WriteLine();
// 8 feladat
Console.WriteLine("8 feladat");
for (int i = 0; i < negativ_szamok.Length; i++)
{
    negativ_szamok[i] = Math.Abs(negativ_szamok[i]);
}
foreach (var az in negativ_szamok)
{
    Console.Write(az + " ");
}
// 9 feladat
Console.WriteLine("9 feladat");
for (int i = 0; i < abszulut.Length; i++)
{
    if (abszulut[i] > -5 && abszulut[i]< 5)
    {
        Console.Write(abszulut[i] + " ");
    }
}
// 10 feladat
Console.WriteLine("10 feladat");
for (int i = 0; i < abszulut.Length; i++)
{
    if (abszulut[i] < -10 && abszulut[i] > -5)
    {
        Console.Write(abszulut[i] + " ");
    }
}
Console.WriteLine("11 feladat");
for (int i = 0; i < abszulut.Length; i++)
{
    Console.Write(abszulut[i] + " ");
}
Console.WriteLine("");

for (int i = abszulut.Length-1; i >= 0 ; i--)
{
    Console.Write(abszulut[i] + " ");
}
// 12 feladat
Console.WriteLine("12 feladat");
Console.WriteLine("Elötte:" + szamok[0]);
Console.WriteLine("Elötte:" + szamok[19]);
int elotte = szamok[0];
int elotte1 = szamok[19];

for (int i = 0; i < szamok.Length; i++)
{
    szamok[0] = elotte1;
    szamok[19] = elotte;
}
Console.WriteLine($"Utána:{szamok[0]},{szamok[19]}");
//13 feladat
for (int i = 0; i < abszulut.Length - 1; i++)
{
    if (abszulut[i] + abszulut[i+1] == 0 )
    {
        Console.WriteLine($"{abszulut[i] + abszulut[i+1]}");
        Console.WriteLine(abszulut[i]);
        Console.WriteLine(abszulut[i+1]);
        abszulut[i] = 0;
        abszulut[i+1] = 0;
    }
    Console.Write(abszulut[i]+" ");
}
//14 feladat
Console.WriteLine(" ");
for (int i = 0; i < szamok.Length; i++)
{
    string szoveg_szam = szamok[i].ToString();
    if (szoveg_szam.Length == 2)
    {
        if (szoveg_szam[1] == '5')
        {
            Console.WriteLine(szoveg_szam);
        }
    }
}
// 15 feladat
//14 feladat
Console.WriteLine(" ");
for (int i = 0; i < szamok.Length; i++)
{
    string szoveg_szam = szamok[i].ToString();
    if (szoveg_szam.Length == 2)
    {
        if (szoveg_szam[0] == '1')
        {
            Console.WriteLine(szoveg_szam);
        }
    }
}
//16-17 feladat 
Console.WriteLine(" ");
for (int i = 0; i < szamok.Length; i++)
{
    string szoveg = szamok[i].ToString();
    if (szoveg[0] == szoveg[1])
    {
        Console.WriteLine("két szám megegyezik");
        Console.WriteLine(szoveg);
    }
}
// 18 feladat 
Console.WriteLine("18 feladat");
for (int i = 1; i < abszulut.Length - 1; i++)
{
    if (abszulut[i - 1] < abszulut[i] && abszulut[i] > abszulut[i + 1])
    {
        if (abszulut[i - 1] + abszulut[i + 1] == abszulut[i])
        {
            Console.WriteLine(abszulut[i]);
        }else
        {
            
        }
    }
}

/*
//Összegzés tétel
int osszeg = 0;
Console.WriteLine("Összegzés");
for (int i = 0; i < szamok.Length; i++)
{
    osszeg+=szamok[i];
}
Console.WriteLine($"Számok lista hossza:{szamok.Length}");
Console.WriteLine($"Számok lista összege:{osszeg}");
//7 feladat

//Megszámlálás
int db = 0;
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] >= 5 )
    {
        db++;
        Console.Write($"{szamok[i]} ");
    }
}
Console.WriteLine("");
Console.WriteLine($"Ennyi darab van ami nagyobb mint 5: {db}");
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] > 5)
    {
        kivallogatott[i] = szamok[i];
        Console.Write(kivallogatott[i]+ " ");
    }
}
Console.WriteLine("");
foreach (var az in kivallogatott)
{
    Console.Write(az+ " ");
}
int min = szamok[0];
for (int i = 0; i < szamok.Length; i++)
{
    if(szamok[i] < min)
    {
        min = szamok[i];
    }
}
Console.WriteLine("");
Console.WriteLine($"Minimum:{min}");
int max = szamok[0];
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] > max)
    {
        max = szamok[i];
    }
}
Console.WriteLine($"Maximum:{max}");
*/