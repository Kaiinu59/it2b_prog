using System;
class Program 
{ 
    static void Main()
    {
        Console.Write("Do you want to create a new character? (Y)es/(N)o: ");
        char CreAns = char.Parse(Console.ReadLine());
        Player player1 = new Player("", 0);
        switch (CreAns)
        {
            case 'Y':
                Console.Write("\nWrite your name: ");
                string name = Console.ReadLine();
                Console.Write("\nWrite your age: ");
                int age = int.Parse(Console.ReadLine());
                player1 = new Player("name", age);
                break;

            case 'N':

                break;

        }

        player1.TotalScore();

        Console.WriteLine("Now you can choose option from ((A)Win, (B)Loose, (C)TotalScore, (D)TotalInfo)");
        char OptAns = char.Parse(Console.ReadLine());
        switch (OptAns)
        {
            case 'A':
                player1.Win();
                break;

            case 'B':
                player1.Loose();
                break;

            case 'C':
                player1.TotalScore();
                break;

            case 'D':
                player1.TotalInfo();
                break;
        }







    }
}