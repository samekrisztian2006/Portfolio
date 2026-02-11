namespace ConsoleApp7;

public class Class
{
    public static double hossz{get;set;}
    public static double szel{get;set;}

    public Class(double Hossz,double Szel)
    {
        hossz=Hossz;
        szel=Szel;
    }

    public virtual void K_T()
    {
        Console.WriteLine($"Terület:{hossz*szel}");
        Console.WriteLine($"Kerület:{2*(hossz+szel)}");
    }

}