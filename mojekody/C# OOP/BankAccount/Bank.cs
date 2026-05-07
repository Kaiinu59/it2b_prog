using System;
class BankAccount
{
    public string Name { get; set; }
    private double Balance;
    private string Password;
    private List<string> History;

    public BankAccount(string name, int balance = 0, string password = "password")
    {
        Name = name;
        Balance = balance;
        Password = password;
        History = new List<string>();
    }

    public void AddBalance()
    {
        Console.Write("\nZadejte mnozstvi penez pro prizdani: ");
        string AddMonCou = Console.ReadLine()
        double AddMonCouTran = double.Parse();
        Balance += AddMonCou;
        History.Add();
    }

    public void ShowBalance()
    {
        Console.Write($"\nVas aktualni zustatek: {Balance}");
    }

    public void ReduceBalance() {
        Console.Write("\nZadejte mnozstvi penez pro odpocet z uctu: ");
        double AddMonCou = double.Parse(Console.ReadLine());
        if (AddMonCou > Balance)
            Console.WriteLine("\nZamitnuto, zustatek na uctu je mensi nez zadana castka.");
        else
            Balance -= AddMonCou;

    }

    public void ChangePassword()
    {
        Console.WriteLine("Chcete zmenit heslo ? Y/N");
        int Ans = int.Parse(Console.ReadLine());
        switch (Ans)
        {
            case 'N':
                break;
            case 'Y':
                Console.Write("\nZadejte stare heslo: ");
                if (Password != Console.ReadLine())
                {
                    Console.WriteLine("Zkuste jeste jednou.");
                    if (Password != Console.ReadLine())
                    {
                        Console.WriteLine("Zmena hesla zamitnuta.");
                    }
                }
                else
                {
                    Console.Write("Zadejte nove heslo: ");
                    Password = Console.ReadLine();
                    Console.WriteLine("Heslo bylo uspesne zmeneno");
                }
            break;
        }
    }









}