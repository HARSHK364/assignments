// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        var studentScores = new Dictionary<string, List<int>>();


        studentScores.Add(" vanshika", new List<int> { 98, 60, 50 });
        studentScores.Add("shailja", new List<int> { 95, 75, 55 });
        studentScores.Add(" uday", new List<int> { 98, 42, 08 });


        Console.WriteLine("Student Scores:");
        foreach (var student in studentScores)
        {
            Console.WriteLine($"Name: {student.Key}, Scores: {string.Join(", ", student.Value)}");
        }

        Console.WriteLine("\nAverage Scores:");
        /*List<int> averagePrice = studentScores.Values.Average();
        Console.WriteLine($"Average Price: {averagePrice}");*/     //getting error here    

        var highestAverageStudent = studentScores.OrderByDescending(x => x.Value.Average()).First();
        Console.WriteLine($"\nStudent with Highest Average Score: {highestAverageStudent.Key}, Average Score: {highestAverageStudent.Value.Average()}");
    }
}
