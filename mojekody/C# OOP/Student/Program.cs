using System;
class Program
{
    static void Main()
    {
        Student st01 = new Student("Vasya Ran", 19, "IT4A");
        Student st02 = new Student("Valentine", 18, "IT2A");


        st01.AddGrade(5);
        st01.AddGrade(2);
        st02.AddGrade(4);
        st01.AddGrade(3);


       
        st02.AddGrade(5);
        st02.AddGrade(1);
        st02.ShowInfo();
        st02.RemoveGrade(5);
        st02.ShowInfo();
        st02.AddGrade(5);
        st02.AddGrade(3);
        st02.AddGrade(1);
        Console.WriteLine(st02.AverageGrade());
        st02.ShowInfo();
        st02.IfAdult();







    }
}