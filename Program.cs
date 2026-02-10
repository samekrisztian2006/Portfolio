float szam = float.Parse(Console.ReadLine());

if (szam >= 50)
{
    Console.WriteLine("Nagyobb a szám mint 50-ven");
}else
{
    Console.WriteLine(" Nem nagyobb a szám mint 50-ven");
}

char ch = Console.ReadKey().KeyChar; 


if (Char.IsLower(ch))
{
    Console.WriteLine("Kicsi");
}
else if (Char.IsUpper(ch))
{
    Console.WriteLine("Nagy");
}
else
{
    Console.WriteLine("Más");
}

float szam = float.Parse(Console.ReadLine());
float szam2 = float.Parse(Console.ReadLine());

if (szam > szam2)
{
    Console.WriteLine($"{szam} nagyobb ennyivel {szam - szam2} ");
}
else if (szam2 > szam)
{
    Console.WriteLine($"{szam2} nagyobb ennyivel: {szam2 - szam}. ");
}
else if (szam2 == szam)
{
    Console.WriteLine($"Engyelők.");
}

float szam = float.Parse(Console.ReadLine());

if (szam < 18)
{
    Console.WriteLine("Fiatalabb mint 18 ");
}else
{
    Console.WriteLine("18 vagy idősebb");
}

float szam = float.Parse(Console.ReadLine());

switch (szam)
{
    case 0:
        Console.WriteLine("nulla");
        break;
    case 1:
        Console.WriteLine("egy");
        break;
    case 2:
        Console.WriteLine("kettő");
        break;
    case 3:
        Console.WriteLine("három");
        break;
    case 4:
        Console.WriteLine("négy");
        break;
    case 5:
        Console.WriteLine("öt");
        break;
    case 6:
        Console.WriteLine("hat");
        break;
    case 7:
        Console.WriteLine("hét");
        break;
    case 8:
        Console.WriteLine("nyolc");
        break;
    case 9:
        Console.WriteLine("kilencs");
        break;

    default:
        Console.WriteLine("Nem szám");
        break;
}
Console.WriteLine("Add meg a jelszót:");
string jelszo = Console.ReadLine();

if (jelszo == "titok")
{
    Console.WriteLine("Hozzáférés engedélyezve");
}else
{
    Console.WriteLine("Hozzáférés megtagadva!");
}
float szam = float.Parse(Console.ReadLine());

switch (szam)
{
    case 1:
        Console.WriteLine("elégtelen");
        break;
    case 2:
        Console.WriteLine("kettes");
        break;
    case 3:
        Console.WriteLine("háromas");
        break;
    case 4:
        Console.WriteLine("négyes");
        break;
    case 5:
        Console.WriteLine("ötös");
        break;
}
Console.Write("Kérem a hónap nevét (pl. január): ");
string honap = Console.ReadLine().ToLower();

switch (honap)
{

    case "január":
    case "március":
    case "május":
    case "július":
    case "augusztus":
    case "október":
    case "december":
        Console.WriteLine($"{honap} 31 napos.");
        break;

    case "április":
    case "június":
    case "szeptember":
    case "november":
        Console.WriteLine($"{honap} 30 napos.");
        break;

    case "február":
        Console.WriteLine("február 28 napos.");
        break;

    default:
        Console.WriteLine("Ismeretlen hónap név.");
        break;
}
int szam = int.Parse(Console.ReadLine());

string sz = szam.ToString();
int szamjegy = sz.Length;
if (szamjegy == 4)
{
    Console.WriteLine("Négyjegyü");
}
else
{
    Console.WriteLine("Nem négyjegyü");
}

string szoveg = Console.ReadLine();

if (szoveg.Contains("a"))
{
    Console.WriteLine("Tartalmaz A betüt");
}
else if (szoveg.Contains("e"))
{
    Console.WriteLine("Tartalmaz E betüt");
}
else if (szoveg.Contains("i"))
{
    Console.WriteLine("Tartalmaz I betüt");}
else if (szoveg.Contains("o"))
{
    Console.WriteLine("Tartalmaz O betüt");}
else if (szoveg.Contains("u"))
{
    Console.WriteLine("Tartalmaz U betüt");
}
else
{
    Console.WriteLine("Mássalgangó vagy ismeretlen karakter");

}
