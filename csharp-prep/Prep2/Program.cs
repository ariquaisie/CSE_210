using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?: ");
        string gradestring = Console.ReadLine();
        int grade = int.Parse(gradestring);

        if (grade >= 90)
        {
            string lettergrade = "A";
            Console.WriteLine($"You have an {lettergrade}");
        } else if (grade < 90 && grade >= 80)
        {
            string lettergrade = "B";
            Console.WriteLine($"You have an {lettergrade}");
        } else if (grade < 80 && grade >= 70)
        {
            string lettergrade = "C";
            Console.WriteLine($"You have an {lettergrade}");
        } else if (grade < 70 && grade >= 60)
        {
            string lettergrade = "D";
            Console.WriteLine($"You have an {lettergrade}");
        } else
        {
            string lettergrade = "F";
            Console.WriteLine($"You have an {lettergrade}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry! Y0u failed this class. You would have to retake it if it is a requirement for your major!");
        }

    }
}
