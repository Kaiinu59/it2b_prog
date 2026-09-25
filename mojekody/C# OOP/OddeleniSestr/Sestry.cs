class Sestry    
{
    public string Name { get; set; }
    public string Oddeleni { get; set; }
    private double Plat;

    public Sestry(string name, string odddeleni = null, double plat = 20000)
    {
        Name = name;
        Oddeleni = odddeleni;
        Plat = plat;
    }


    static void ZvysPlat()
    {

        Console.Write("\nZadejte mnozstvi penez pro zvetswni platu: ");
        Plat += double.Parse(Console.ReadLine());
       
}


    static void ZmenPlat()
    {
        Console.Write("\nZadejte mnozstvi penez pro zmenseni platu: ");
        Plat += double.Parse(Console.ReadLine());
    }
}
