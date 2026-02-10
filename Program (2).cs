
using System.Drawing;
using System.Globalization;
/*
// 1 feladat
Console.WriteLine("Kérjük a felhasználó nevét és üdvözöljük, pl. “Üdvözöllek Kiss István!");
Console.WriteLine($"Üdözöllek {Console.ReadLine()} !");
// 2 feladat
Console.WriteLine("Kérjünk be egy számot és írjuk ki a képernyőre! Írjuk ki a kétszeresét is!");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Eredeti szám: {a}, a szám kétszerese:{a * 2}");
// 3 feladat
Console.WriteLine("Kérjünk be két számot és határozzuk meg az így meghatározott téglalap kerületét és területét és szépen formázva jelenítsük is meg!");
int a_o = int.Parse(Console.ReadLine());
int b_o = int.Parse(Console.ReadLine());
Console.WriteLine($"Téglalap területe: {a_o * b_o}, a téglalap kerülete:{2*a_o + 2*b_o}");
// 4 feladat
Console.WriteLine("Készítsünk programot, ami bekéri a kör sugarát, majd kiírja a kör területét és kerületét!");
int r = int.Parse(Console.ReadLine());
Console.WriteLine($"Kör terüle:{Math.Pow(r, 2) * Math.PI},Kör kerülete:{2 * r * Math.PI}");
// 5 feladat
Console.WriteLine("Életkor megállapítása, kérjük be a születési dátumot, majd határozzuk meg, hogy hány éves és jelenítsük is meg!");
Console.WriteLine("Adja meg a mai dátumot");
int ma_ev = int.Parse(Console.ReadLine()), ma_honap = int.Parse(Console.ReadLine()), ma_nap = int.Parse(Console.ReadLine());
Console.WriteLine("Adja meg a születési dátumot");
int ev = int.Parse(Console.ReadLine()), honap = int.Parse(Console.ReadLine()), nap = int.Parse(Console.ReadLine());
Console.WriteLine($"Ennyi idős {ma_ev - ev} éves {ma_honap - honap} honapos {ma_nap - nap} napos ");
// 6 feladat
Console.WriteLine("Kérjünk be egy számot és határozzuk meg, hogy hány jegyű, majd jelenítsük is meg! Maximum 9 jegyű számokat kell kezelni és erről a felhasználót is tájékoztatni kell! Ezen kívül a beolvasott számot is meg kell vizsgálni, hogy megfelel-e a feltételnek és ha nem, akkor jelezni is kell azt!");
Console.WriteLine("Maximum 9 jegyű számokat adhat");
int szam = int.Parse(Console.ReadLine());
string szam_sz = szam.ToString();
if (szam_sz.Length <= 9)
{
    Console.WriteLine("Megfelel");
}else
{
    Console.WriteLine("Nem felel meg");
}
// 7 feladat
Console.WriteLine("Készítsünk egy egyszerő szmálógépet, ami bekér 2 db számot majd egy műveleti jelet, ami 4 alapművelet (+,-,*,/) valamelyike lehet, majd végezzük is el a kívánt műveletet és az eredményt szépen formázva jelenítsük meg! Figyeljünk arra is, hogy csak a felsorolt műveleti jeleket fogadjuk el!");
int bekert_szam1 = int.Parse(Console.ReadLine());
int bekert_szam2 = int.Parse(Console.ReadLine());
string muvelet = Console.ReadLine();
switch (muvelet)
{
    case "+":
        Console.WriteLine(bekert_szam1+bekert_szam2);
        break;
    case "-":
        Console.WriteLine(bekert_szam1-bekert_szam2);
        break;
    case "*":
        Console.WriteLine(bekert_szam1*bekert_szam2);
        break;
    case "/":
        Console.WriteLine(bekert_szam1/bekert_szam2);
        break;
    default:
        break;
}
// 8 feladat
Console.WriteLine("Olvassunk be 20 db maximum 3 jegyű számokat és határozzuk meg az összegüket, átlagukat, a legkisebb és a legnagyobb számot majd jelenítsükis meg szépen formázva a kiszámított értékeket! A beolvasott számokatellenőrizni is kell, hogy megfelelnek a feltételeknek és csak azokkalkell számolni, amik megfelelnek!");
Random szam1 = new Random();
int[] szamok = new int[20];
string bekeres = Console.ReadLine(); 
int Megfelel = 0,osszeg = 0, min= szamok[0],  max=szamok[0];

for (int i = 0; i < szamok.Length; i++)
{
    int szam_ran = szam1.Next(0,999);
    if (szam_ran.ToString().Length <= 3)
    {
        szamok[i] = szam_ran;
        Console.WriteLine(szamok[i]);
        Megfelel++;
    }else
    {
        Console.WriteLine("Nem felel meg");
    }
    
}
Console.WriteLine("Ezek felelnek meg:"+Megfelel);
//Összeadás-átlag
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] == 0 )
    {
        Console.WriteLine("Nem megfelelt meg ezért nem számolom");
    }else
    {
        osszeg+=szamok[i];
    }
}
Console.WriteLine("Megfelelt számok összege:"+ osszeg);
Console.WriteLine("Megfelelet számok átlaga:"+ osszeg/Megfelel);
//Max-min
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] < min)
    {
        min = szamok[i];
    }
    if (szamok[i] > max)
    {
        max = szamok[i];
    }
}
Console.WriteLine("Megfelelt számok minimuma:"+min);
Console.WriteLine("Megfelelt számok maximuma:"+max);

// 9 feladat
Console.WriteLine("Írjuk ki a számokat 20-tól 55-ig! (az 55-öt már ne, és az összes többi ilyen feladatnál se kell az utolsó számmal dolgozni!)");
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] > 20 && szamok[i]<55)
    {
        Console.WriteLine(szamok[i]);
    }
}
// 10 feladat 
Console.WriteLine("Írjuk ki a számokat 15-35-ig egy sorba, vesszővel elválasztva&quot;);");
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] > 15 && szamok[i]<35)
    {
        Console.Write($"{szamok[i]};");
    }
}
// 11 feladat
Console.WriteLine("15-35-ig minden 2. szám egy sorba, vesszővel elválasztva");
for (int i = 0; i < szamok.Length; i=i+2)
{
    if (szamok[i] > 15 && szamok[i]<35)
    {
        Console.Write($"{szamok[i]},");
    }
}
// 12 feladat
Console.WriteLine("34-14-ig egy sorba, vesszővel elválasztva");
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] > 14 && szamok[i]<34)
    {
        Console.Write($"{szamok[i]},");
    }
}
// 13 feladat
Console.WriteLine("35-14-ig minden 3. szám egy sorba, vesszővel elválasztva");
for (int i = 0; i < szamok.Length; i=i+3)
{
    if (szamok[i] > 14 && szamok[i]<34)
    {
        Console.Write($"{szamok[i]},");
    }
}
// 14 feladat
Console.WriteLine("Írjunk ki 10 db 0-99 tartományból véletlen számokat egy sorba, vesszővel elválasztva");
int[] tartomany = new int[10];
for (int i = 0; i < tartomany.Length; i++)
{
    
}
// 15 feladat
Console.WriteLine("Írjunk ki véletlen számokat 0--9 tartományból, de véletlen számú db-t, vagyis 5-20 db-ig lehet véletlenszámokat generálni");
Random szam_random = new Random();
int ciklus = szam_random.Next(0,10);
int[] veletlen_szam = new int[ciklus];
for (int i = 0; i < veletlen_szam.Length; i++)
{
    veletlen_szam[i] = szam_random.Next(5,21);
}
foreach (var elemek in veletlen_szam)
{
    Console.Write($"{elemek},");
}
// 16 feladat
Console.WriteLine("Olvassunk be a billentyűzetről egy teszőleges szöveget, majd jelenítsük meg az egyes karaktereit vesszővel elválasztva, egy sorba");

string szoveg = Console.ReadLine();
char[] betuk = new char[szoveg.Length];
for (int i = 0; i < betuk.Length; i++)
{
    betuk[i] = szoveg[i];
}
for (int i = 0; i < betuk.Length; i++)
{
    Console.Write(betuk[i] + ",");
}

// 17 feladat
Console.WriteLine("Készítsül el azt az alkalmazást, ami 10 sorban véletszámú (5-10 közötti) * ír ki.");
Random csillag = new Random();
for (int i = 0; i < 10; i++) 
{
    for (int k = 0; k < csillag.Next(5,11); k++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
*/
// 18 feladat
/*
Console.WriteLine("Véletlenszámok segítségével generáljunk egy 10 karakterből álló szöveget, ahol az angol ABC nagybetűi fordulhatnak csak elő! Pl.: BSKAJIOLKE");
string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string szo = "";
Random betu_pic = new Random();
for (int i = 0; i < 10; i++)
{
    int a = betu_pic.Next(0,27);
    szo += angol_abc[a];
}
Console.WriteLine(szo);

//19 feladat
Console.WriteLine("19. Generáljunk véletlen hosszú (5-50) nagybetűs szöveget");
string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string szo = "";
Random betu_pic = new Random();
int b = betu_pic.Next(5,51);
for (int i = 0; i < b; i++)
{
    int a = betu_pic.Next(0,27);
    szo += angol_abc[a];
}
Console.WriteLine(szo);

//20 feladat
Console.WriteLine("Generáljunk 10 db véletlen hosszú (5-50) nagybetűs szöveget, amiket külön sorokba írjunk ki");
string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Random betu_pic = new Random();
int b = betu_pic.Next(5, 51);

for (int i = 0; i < 10; i++)
{
    string szo = "";                
    for (int k = 0; k < b; k++)
    {
        int a = betu_pic.Next(0, 26); 
        szo += angol_abc[a];
    }
    Console.WriteLine(szo);
}

//21 feladat
Console.WriteLine("Generáljunk véletlen hosszú (5-50) nagybetűs szöveget, majd mellé írjuk ki úgy, hogy csak minden 2. betűt jelenítsük meg! Pl.: APOKLUETZHJ -&gt; AOLEZJ");
string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string szo = "";
Random betu_pic = new Random();
int b = betu_pic.Next(5,51);
for (int i = 0; i < b; i++)
{
    int a = betu_pic.Next(0,27);
    szo += angol_abc[a];
}
Console.WriteLine(szo);
for (int i = 0; i < szo.Length; i=i+2)
{
    Console.Write(szo[i]);
}
Console.WriteLine();

//22 feladat
Console.WriteLine("Generáljunk 10 db véletlen hosszú (5-50) nagybetűs szöveget, majd mellé írjuk ki úgy, hogy csak minden 3. betűt jelenítsük meg! Pl.: APOKLUETZHJ -&gt; AOLEZJ PWOIEUKD -&gt; PIK");
string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Random betu_pic = new Random();

string[] szoveg = new string[10];
for (int i = 0; i < 10; i++)
{
    string szo = "";  
    int b = betu_pic.Next(5, 51);              
    for (int k = 0; k < b; k++)
    {
        int a = betu_pic.Next(0, 26); 
        szo += angol_abc[a];
    }
    szoveg[i] = szo;
}
for (int i = 0; i < 10; i++)
{
    for (int k = 0; k < szoveg[i].Length; k=k+3)
    {
        Console.Write(szoveg[i][k]);
    }
    Console.WriteLine();
}

// 23 feladat
Console.WriteLine("Generáljunk 2 db 2 számjegyű véletlen számot, írjuk ki a két számot, az összegüket, a különségüket, a szotzatukat és a hányadosukat. Ezt tízszer ismételjük meg, vagyis eredményül 10 sort kell kapnunk, a fenti mintával. Pl.: 10+55=65, 10-65=-55, 10*65=650, 10/65=0,.... 50+60=110, 50-60=-10, 50*60=3000, 50/60=0,... ....");
Random cigany = new Random();
int c = cigany.Next(0,100);
int a1 = cigany.Next(0,100);
string[] szia = new string[8];
for (int i = 0; i < szia.Length; i++)
{
    c = cigany.Next(0,100);
    a1 = cigany.Next(0,100);
    szia[i] = $"{c}+{a1}={c+a1},{c}-{a1}={c-a1},{c}*{a1}={c*a1},{c}/{a1}={c/a1},";
}
for (int i = 0; i < szia.Length; i++)
{
    Console.WriteLine(szia[i]);
}
*/
//24 feladat
Console.WriteLine("Olvassünk be a billentyűzetről egy tetszőleges hosszú szöveget, majd állítsuk elő egy titkosított változatát! A titkosítás során az egyes karakterek kódjaihoz adjunk hozzá 2-őt, és a kódhoz tartozó karaktert jelenítsük meg! Pl.: ABC -&gt; CDE");
string karakterrek = Console.ReadLine();
char[] karakter_kod = new char[karakterrek.Length];


for (int i = 0; i < karakterrek.Length; i++)
{      
    int decimalis = (int)karakterrek[i]+2; 
    karakter_kod[i] = (char)decimalis;
}
string szo = "";

for (int i = 0; i < karakter_kod.Length; i++)
{
    szo += karakter_kod[i];
}
Console.WriteLine(szo);

//25 feladat
Console.WriteLine("Az előbbi feladat során titkosítottunk (Encryption), most állítsuk elő a titkosított szövegből az eredeti szöveget (Decryption)!");
char[] karakter_kod2 = new char[szo.Length];
for (int i = 0; i < szo.Length; i++)
{
    int decimalis2 = (int)szo[i]-2;
    karakter_kod2[i] = (char)decimalis2;
}
string visszafejtetszo = "";
for (int i = 0; i < karakter_kod2.Length; i++)
{
    visszafejtetszo+=karakter_kod2[i];
}
Console.WriteLine(visszafejtetszo);
//26 feladat
Console.WriteLine("A 24. feladatot valósítsuk meg kicsi módosítással úgy, hogy az ABC végén lévő utolsó két karakter ne lójon ki a nagybetűs ABC-ből, vagyis ha az eredeti karakter Y, akkor a kódolt karakter A legyen, Z betű esetén pedig B.");
string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string tiktositas = Console.ReadLine().ToUpper();
char[] valtoztatas = new char[tiktositas.Length];
for (int i = 0; i < tiktositas.Length; i++)
{
    char tiktos = tiktositas[i];
    if (angol_abc.Contains(tiktos))
    {
        int index = angol_abc.IndexOf(tiktos);
        int ujIndex = (index + 1) % angol_abc.Length;
        valtoztatas[i] = angol_abc[ujIndex];
    }else
    {
        
        valtoztatas[i] = tiktos;
    }
}
string ujszo = "";
for (int i = 0; i < valtoztatas.Length; i++)
{
    ujszo+=valtoztatas[i];
}

Console.WriteLine(ujszo);
//27 feladat
Console.WriteLine("Készítsük el a 26. feladathoz tartozó visszatitkosító programot!");
char[] a_valtoztatas = new char[tiktositas.Length];
for (int i = 0; i < ujszo.Length; i++)
{
    char vissza_a = ujszo[i];
    if (angol_abc.Contains(vissza_a))
    {
        int index = angol_abc.IndexOf(vissza_a);
        int ujIndex = (index - 1 + angol_abc.Length) % angol_abc.Length;
        a_valtoztatas[i] = angol_abc[ujIndex];
    }else
    {
        
        a_valtoztatas[i] = vissza_a;
    }
}
string vissza_ujszo = "";
for (int i = 0; i < a_valtoztatas.Length; i++)
{
   vissza_ujszo+=a_valtoztatas[i];
}
Console.WriteLine(vissza_ujszo);
//28 feladat
Console.WriteLine("Dolgozz ki egy egyedi titkosító algoritmust, majd annak a visszatitkosító változatát is, ami tetszőleges hosszú szöveggel működik!");
/*string angol_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string szo = "";
Random betu_pic = new Random();
int b = betu_pic.Next(5,51);
for (int i = 0; i < b; i++)
{
    int a = betu_pic.Next(0,27);
    szo += angol_abc[a];
}
Console.WriteLine(szo);
for (int i = 0; i < szo.Length; i=i+2)
{
    Console.Write(szo[i]);
}
Console.WriteLine();
*/

// 29 feladat
Console.WriteLine("Készíts egy 8*8-as egyszámjegyű vélelen számokból álló mátrixot. Pl:");
Random szama = new Random();
for (int i = 0; i < 8; i++)
{

    for (int k = 0; k < 8; k++)
    {
        int a = szama.Next(0,9);
        string b = a.ToString();
        Console.Write(b);
    }
    Console.Write("\n");
}

//30 feladat
/*Console.WriteLine("Ez haladó feladat!! Az előző feladathoz hasonlóan készíts egy 8*8-as mátrixot, de figyelj arra, hogy egy sorban egy szám csak egyszer szerepelhet!");
Random szama_a = new Random();
string[] hasznalt = new string[8];
for (int i = 0; i < 8; i++)
{

    for (int k = 0; k < 8; k++)
    {
        string b;

        do
        {
            int a = szama_a.Next(0,9);
            b = a.ToString();
            
        } while (hasznalt.Contains(b));
        hasznalt[k] = b;
    }
    for (int j = 0; j < hasznalt.Length; j++)
    {
        Console.Write(hasznalt[j]+",");
    }
    Console.Write("\n");
}*/
//31 feladat
Console.WriteLine("Készítsd el azt a programot, ahol a program generál egy 1 és 20 közötti (1-19) számot, és a játékos feladata, hogy pontosan eltalálja a számot.");
Random talaldkitefasz = new Random();
int talal;
int az;
do
{
    az = talaldkitefasz.Next(1,20);
    Console.WriteLine(az);
    talal = Convert.ToInt32(Console.ReadLine());
    
} while (az!=talal);
//32 feladat CHATGPT Help-el
Console.WriteLine("Készíts egy programot, ami egy soron belül billentyűk segítségével mozgatni tud egy adott karaktert.");
string sorok = "=---------";
int pos = 0; // az "=" pozíciója

ConsoleKeyInfo keyInfo;

do
{
    Console.Clear();
    Console.WriteLine(sorok);

    keyInfo = Console.ReadKey(true);

    if (keyInfo.Key == ConsoleKey.A && pos > 0)
    {
        pos--; // balra
    }
    else if (keyInfo.Key == ConsoleKey.D && pos < sorok.Length - 1)
    {
        pos++; // jobbra
    }

    // új string összeállítása
    char[] chars = new string('-', sorok.Length).ToCharArray();
    chars[pos] = '=';
    sorok = new string(chars);

} while (keyInfo.Key != ConsoleKey.X);

//33 feladat CHATGPT Help-el
Console.WriteLine("program egy 10x10-es mezőben &#39;-&#39;-okat jelenít meg, valamint véletlenszerű helyen egy &#39;0&#39;-t és egy &#39;=&#39;-t.");
int width = 10;
int height = 10;

int x = 0; // oszlop
int y = 0; // sor

ConsoleKeyInfo key;

do
{
    Console.Clear();
    for (int row = 0; row < height; row++)
    {
        for (int col = 0; col < width; col++)
        {
            if (row == y && col == x)
                Console.Write("=");
            else
                Console.Write("-");
        }
        Console.WriteLine();
    }

    key = Console.ReadKey(true);

    
    if (key.Key == ConsoleKey.A && x > 0)
        x--; 
    else if (key.Key == ConsoleKey.D && x < width - 1)
        x++; 
    else if (key.Key == ConsoleKey.W && y > 0)
        y--; 
    else if (key.Key == ConsoleKey.S && y < height - 1)
        y++; 

} while (key.Key != ConsoleKey.X); 


//34 feladat

Console.WriteLine("1-99 véletlenszámokkal töltsünk fel egy 50 elemű tömböt. Határozzuk meg a számok összegét, átlagát, a legkisebb és a legnagyobb értéket, majd jelenítsük is meg!");
int[] szeri = new int[50];
Random amaz = new Random();
for (int i = 0; i < szeri.Length; i++)
{
    szeri[i] = amaz.Next(1,99);
}
int addossze = 0;
for (int i = 0; i < szeri.Length; i++)
{
    addossze += szeri[i];
}
int atlag = addossze / szeri.Length;
int legkisebb = szeri[0];
int legnagyobb = szeri[0];
for (int i = 0; i < szeri.Length; i++)
{
    if (szeri[i] > legnagyobb)
    {
        legnagyobb = szeri[i];
    }
    if (szeri[i] < legkisebb)
    {
        legkisebb = szeri[i];
    }
}
Console.WriteLine($"{legnagyobb},{legkisebb},{addossze}");
//35 feladat
Console.WriteLine("1-99 véletlenszámokkal töltsünk fel egy 50 elemű tömböt. Határozzuk meg, hogy szerepel-e a tömbben a 21-es érték és azt is, hogy hányszor!");

int huszonegynel = 0;
for (int i = 0; i < szeri.Length; i++)
{
    if (szeri[i] == 21)
    {
        huszonegynel++;
    }
}
Console.WriteLine(huszonegynel);
//36 feladat
Console.WriteLine("1-99 véletlenszámokkal töltsünk fel egy 50 elemű tömböt. Határozzuk meg a számok átlagát, jelenítsük is meg! Majd számoljuk meg, hogy hány db szám van, ami kisebb, mint az átlag! Határozzuk meg azt is, hogy hány db olyan szám van a tömbben, ami nagyobb, mint az átlag!");
int nagyobb = 0;
int kisebb = 0;
for (int i = 0; i < szeri.Length; i++)
{
    if (szeri[i] > atlag)
    {
        nagyobb++;
    }
    if(szeri[i] < atlag)
    {
        kisebb++;
    }
    
}
Console.WriteLine($"Nagyobb:{nagyobb},Kisebb:{kisebb}");
