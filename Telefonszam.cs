using System.ComponentModel;

namespace ConsoleApp7;

public class Telefonszam : Azonosit
{

    public string szam { get; set; }


    private string keres;

    public void Telefonszam_Szol()
    {
        if (szam.Length == 11)
        {
            keres = $"{szam[2]}{szam[3]}";
            Console.WriteLine(keres);

            switch (keres)
            {
                case Telekom:
                    Console.WriteLine($"Telekomnál van ez a telefonszám: {szam}");
                    break;
                case Yettel:
                    Console.WriteLine($"Yettelnél van ez a telefonszám: {szam}");
                    break;
                case Vodafone:
                    Console.WriteLine($"Vodafone-nál van ez a telefonszám: {szam}");
                    break;
                default:
                    Console.WriteLine($"Ez a telefonszám: {szam} egyik szolgáltatónál sincs");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Nem létezik");
        }
    }
}