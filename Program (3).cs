// See https://aka.ms/new-console-template for more information
using System;

Random az1 = new Random();
List<int> szamoklista = new List<int>();
List<int> paros = new List<int>();
List<int> megforditas = new List<int>();
List<int> valogat = new List<int>();
List<string> nevek = new List<string> { "Ferenc", "Krisz", "Peti", "Orosz", "Viktor" };

// 1 feladat
for (int i = 0; i < 5; i++)
{
    szamoklista.Add(az1.Next(0, 10));
}
foreach (int elso in szamoklista)
{
    Console.WriteLine(elso);
}
Console.WriteLine("\n");
// 2 feladat
int osszeg = 0;
foreach (int masodik in szamoklista)
{
    if (masodik > 0)
    {
        osszeg += masodik;
    }
}
Console.WriteLine(osszeg);
Console.WriteLine("\n");

// 3 feladat
foreach (int harmadik in szamoklista)
{
    if (harmadik % 2 == 0 && harmadik != 0)
    {
        paros.Add(harmadik);
    }
}
for (int i = 0; i < paros.Count; i++)
{
    Console.WriteLine(paros[i]);
}
Console.WriteLine("\n");
// 4 feladat
int max = szamoklista[0];
foreach (int negyedik in szamoklista)
{
    if (max < negyedik)
    {
        max = negyedik;
    }
}
Console.WriteLine(max);
Console.WriteLine("\n");
//5 feladat
foreach (string otodik in nevek)
{
    if (otodik.Length >= 5)
    {
        Console.WriteLine(otodik);
    }
}
Console.WriteLine("\n");
// 6 feladat
for (int i = szamoklista.Count - 1; i >= 0; i--)
{
    megforditas.Add(szamoklista[i]);
}
foreach (int hatodik in megforditas)
{
    Console.WriteLine(hatodik);
}
Console.WriteLine("\n");
// 7 feladat

for (int i = 0; i < szamoklista.Count; i++)
{
    for (int a = 0; a < szamoklista.Count; a++)
    {
        if (szamoklista[i] < szamoklista[a])
        {
            int c = szamoklista[i];
            szamoklista[i] = szamoklista[a];
            szamoklista[a] = c;
        }
    }
}
foreach (int hetedik in szamoklista)
{
    Console.WriteLine(hetedik);
}
Console.WriteLine("\n");
for (int i = 0; i < szamoklista.Count; i++)
{
    for (int a = 0; a < szamoklista.Count; a++)
    {
        if (szamoklista[i] > szamoklista[a])
        {
            int c = szamoklista[i];
            szamoklista[i] = szamoklista[a];
            szamoklista[a] = c;
        }
    }
}
foreach (int hetedik in szamoklista)
{
    Console.WriteLine(hetedik);
}

Console.WriteLine("\n");
//8 feladat
foreach (int az in szamoklista)
{
    if (!valogat.Contains(az))
    {
        valogat.Add(az);
    }
}
foreach (int ez in valogat)
{
    Console.WriteLine(ez);
}