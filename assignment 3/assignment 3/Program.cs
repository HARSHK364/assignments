// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> students = new Dictionary<string, int>();
        students.Add("harsh", 85);
        students.Add("Aryan", 82);
        students.Add("divyansh", 78);
        students.Add("deepa", 62);
        students.Add("drishti", 00);

        Console.WriteLine("initially students score are :");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}:{student.Value}");

        }

        students["drishti"] = 20;
        Console.WriteLine(" \n updated score");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}:{student.Value}");

        }

        students.Remove("deepa");
        Console.WriteLine("\n after removing :");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}:{student.Value}");

        }

        string specificStudent = "harsh";

        if (students.TryGetValue(specificStudent, out int value))
        {
            Console.WriteLine($"\nScore of {specificStudent} is:{value}");
        }
        else
        {
            Console.WriteLine($"Student {specificStudent} not found.");
        }

        Console.ReadLine();
    }
}
