// See https://aka.ms/new-console-template for more information
class MyClass
{
    enum Grade { pass = 60, distinction = 85 };

    public static void Main()
    {
 int empid;
 int marks;
 string name;

        Console.WriteLine("Hi What is name");
        name = Console.ReadLine();

        Console.WriteLine("Hi What is Your EMP_ID!");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine("welcome to the result genereator");
        Console.WriteLine($"Welcome {name}  thanks for the id {empid}");
        Console.WriteLine("Enter your marks");
        marks = int.Parse(Console.ReadLine());
        if (marks >= (int)Grade.distinction)
        {
            Console.WriteLine($"congrats {name} you earned distinction grades");
        }
        else if (marks >= (int)Grade.pass)
        {
            Console.WriteLine($"{name} you earned passing grades better luck next time");
        }
        else
        {
            Console.WriteLine($" {name} you have failed please contact the supervisor for the retest");
        }
    }
}

