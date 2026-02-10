using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CiklusTeszt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input?.ToLower())
            {
                case "for":
                    Console.WriteLine("FOR ciklus");

                    for (int i = 1; i < 10; i++)
                    {
                        Console.Write($"{Math.Pow(i, 2)},");
                    }

                    int paros = 0;
                    int paratlan = 0;
                    int hatar = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= hatar; i++)
                    {
                        if (i % 2 == 0)
                        {
                            paros++;
                        }
                        else
                        {
                            paratlan++;
                        }
                    }
                    Console.WriteLine($"Ennyi páros{paros},Ennyi páratlan{paratlan}.");

                    string bemenet = Console.ReadLine();
                    string ujszo = "";
                    for (int i = bemenet.Length - 1; i >= 0; i--)
                    {
                        ujszo += bemenet[i];
                    }
                    Console.WriteLine($"A szó megforditva {ujszo}.");

                    int osszeg = 0;
                    int atlag = 0;
                    int mennyi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= mennyi; i++)
                    {
                        osszeg += i;
                        atlag++;
                    }
                    double vegleg = osszeg / atlag;
                    Console.WriteLine($"A számok összeg {osszeg},Átlaga{vegleg}");

                    break;

                case "while":
                    Console.WriteLine("WHILE ciklus");
                    int ujra = Convert.ToInt32(Console.ReadLine());
                    int o = 0;
                    while (ujra != 0)
                    {
                        o += ujra;
                        ujra = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"A számok összeg {o}");

                    string? szamok1 = Console.ReadLine();
                    int ia = 0;
                    int os = 0;

                    while (ia != szamok1.Length)
                    {
                        if (char.IsDigit(szamok1[ia]))
                        {
                            int a = Convert.ToInt32(szamok1[ia].ToString());
                            os += a;
                        }
                        else
                        {
                            ia++; 
                            continue;
                        }
                        ia++;
                    }

                    Console.WriteLine($"A számok összege {os}");

                    Random random = new Random();
                    int random_szam = random.Next(1, 20);
                    int szam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(random_szam);
                    while (szam != random_szam)
                    {
                        if (szam > random_szam)
                        {
                            Console.WriteLine("Nagyobb");
                        }
                        else
                        {
                            Console.WriteLine("Kisebb");
                        }
                        szam = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Eltaláltad!");

                    string? ez_a = Console.ReadLine();
                    int az = ez_a.Length - 1;
                    string ujszam = "";
                    while (az >= 0)
                    {
                        ujszam += ez_a[az];
                        az--;
                    }
                    Console.WriteLine($"Új szám: {ujszam}");

                    break;

                case "do-while":
                    Console.WriteLine("DO-WHILE ciklus");
                    int ba;
                    do
                    {
                        ba = Convert.ToInt32(Console.ReadLine());

                    } while (ba % 2 != 0);
                    int mod;
                    int eredmeny = 0;
                    do
                    {
                        mod = Convert.ToInt32(Console.ReadLine());

                        if (mod == 1)
                        {
                            eredmeny += Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(eredmeny);
                        }
                        else if (mod == 2)
                        {
                            eredmeny -= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(eredmeny);
                        }
                    } while (mod != 0);
                    Console.WriteLine("Kiléptél");

                    string jelszo = "asd123";
                    string ber = "";
                    do
                    {
                        ber = Console.ReadLine();
                    } while (ber != jelszo);
                    Console.WriteLine("Eltaláltad!");


                    int gag = Convert.ToInt32(Console.ReadLine());
                    int amaz = 1;
                    do
                    {
                        Console.WriteLine(amaz);
                        amaz++;
                    } while (gag >= amaz);
                    break;

                case "foreach":
                    Console.WriteLine("FOREACH ciklus");
                    List<string> nevek = new List<string> { "Gergerly", "Gergő", "Gabriella", "Peti" };
                    int kell = 1;
                    foreach (var most in nevek)
                    {
                        Console.WriteLine($"{kell}.{most}");
                        kell++;
                    }
                    List<int> sorozat = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    int sorozat_o = 0;
                    foreach (var item in sorozat)
                    {
                        sorozat_o += item;
                    }
                    Console.WriteLine($"{sorozat_o},{sorozat_o / sorozat.Count}");
                    string szo = nevek[0];
                    foreach (var item in nevek)
                    {
                        if (item.Length > szo.Length)
                        {
                            szo = item;
                        }
                    }
                    Console.WriteLine(szo);
                    foreach (var item in sorozat)
                    {
                        if (item % 2 == 0)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Nincs ilyen ciklus a listában.");
                    break;
            }
            Console.ReadKey();
        }
    }
}