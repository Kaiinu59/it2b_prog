using System;
class Player
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Level { get; set; }
    public int Score { get; set; }


    public Player(string name, int age)
    {
        Name = name;
        Age = age;
        Level = 1;
        Score = 100;
    }

    public void Win()
    {
        Score += 100;
    }

    public void Loose()
    {
        Score -= 100;
        if (Score <= 0)
        {
            Console.WriteLine("You have no score, it's a defeat.");
        }
    }

    public void TotalScore()
    {
        Console.WriteLine($"Your total score: {Score}");
    }

    public void TotalInfo()
    {
        Console.WriteLine($"Your name: {Name}\n Your age: {Age}\n Your level: {Level}\n Your score: {Score}");
    }

    public void ChooseOption()
    {
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