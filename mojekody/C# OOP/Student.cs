using System;
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string SchoolClass { get; set; }
    public List<int> Grades;

    public Student(string name, int age, string schoolClass)
    {
        Name = name;
        Age = age;
        SchoolClass = schoolClass;
        Grades = new List<int>();
    }


    public void AddGrade(int grade)
    {
        Grades.Add(grade);
    }

    public void RemoveGrade(int grade)
    {
        if (Grades.Contains(grade))
        {
            Grades.Remove(grade);
        }
        else
        {
            Console.WriteLine($"\nZnamka {grade} neni neleznuta.");
        }

    }

    public void ShowGrades()
    {
        Console.WriteLine($"\nGrades for {Name} class {SchoolClass}:");
        foreach (int grade in Grades)
        {
            Console.WriteLine(grade);
        }
    }
    public void DeleteGrade(int grade)
    {
        Grades.Remove(grade);
    }


    public void IfAdult()
    {
        if (Age >= 18)
        {
            Console.WriteLine($"\n{Name} je dospely.");
        }
        else
        {
            Console.WriteLine($"\n{Name} neni dospely.");
        }
    }


    public double AverageGrade()
    {
        if (Grades.Count == 0)
        {
            Console.WriteLine("\nStudent nema znamky");
            return 0;
        }
        double sum = 0;
        for(int i = 0; i < Grades.Count; i++)
        {
            if (Grades[i] < 1 || Grades[i] > 5)
            {
                Console.WriteLine("\nStudent ma neplatnou znamku.");
                return 0;
            }
            sum += Grades[i];

        }
        return sum / Grades.Count;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nName: {Name}, Age: {Age}, Class: {SchoolClass}");
        foreach (int grade in Grades)
        {
            Console.Write($"{grade} ");
        }
    }

}


    