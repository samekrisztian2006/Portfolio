namespace ConsoleApp3;

public class Penz
{
    public int Euro {get; set;}
    public int Dollar {get; set;}
    public int Dinar {get; set;}

    public Penz(int euro, int dollar, int dinar)
    {
        Euro = euro;
        Dollar = dollar;
        Dinar = dinar;
    }
    public float Valtas(float db)
    {
        Console.WriteLine("Adja meg a pénznemet");
        string mi = Console.ReadLine();
        switch (mi)
        {
            case "Euro":
                float valt_euro = db / Euro;
                return valt_euro;
            case "Dollar":
                float valt_dollar = db / Dollar;
                return valt_dollar; ;
            case "Dinar":
                float valt_dinar = db / Dinar;
                return valt_dinar;
            default:
                return db;
        }
    }
    
}