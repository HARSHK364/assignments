// See https://aka.ms/new-console-template for more information


using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {

        List<string> fruits = new List<string>();
        fruits.Add("Banana");
        fruits.Add("Apple");
        fruits.Add("Mango");
        fruits.Add("Orange");
        fruits.Add("Grapes");


        Console.WriteLine(" list of fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        fruits.Add("Watermelon");
        Console.WriteLine("\n after adding Watermelon:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        fruits.RemoveAt(1);
        Console.WriteLine("\n after removing Apple:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nThe 4th fruit is: " + fruits[3]);

        bool containsApple = fruits.Contains("Apple");
        Console.WriteLine("\nList contains Apple: " + containsApple);




        List<int> Values = new List<int>();


        for (int i = 0; i < 10; i++)
        {
            Values.Add(i);
        }


        foreach (int Value in Values)
        {
            Console.WriteLine(Value);
        }

        Values.Sort();
        Values.Reverse();
        Console.WriteLine("\n after  reverse sorting  ");
        {
            foreach (int Value in Values)
            {

                Console.WriteLine(Value);

            }
        }
        Values.Sort();
        Console.WriteLine("after sorting");
        {
            foreach (int Value in Values)
            {
                Console.WriteLine(Value);
            }
        }
        int searchNumber = 2;
        bool found = Values.Contains(searchNumber);
        if (found)
        {
            Console.WriteLine("\n true : " + searchNumber);

        }
        else
        {
            Console.WriteLine("\n false value not found");
        }

        /*  Dictionary<string, int> students = new Dictionary<string, int>();
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

          Console.ReadLine(); */

        Dictionary<string, double> products = new Dictionary<string, double>();
        products.Add("fan", 10.02);
        products.Add("laptop", 1000.56);
        products.Add("mouse", 200.6);
        products.Add("microwave", 2000.56);
        products.Add("pen", 100);

        Console.WriteLine("\n list of products: ");

        foreach (var prd in products)
        {
            Console.WriteLine($"{prd.Key}:{prd.Value}");
        }

        double averagePrice = products.Values.Average();
        Console.WriteLine($"Average Price: {averagePrice}");



        var mostExpensiveProduct = products.OrderByDescending(x => x.Value).First();
        Console.WriteLine($"Most Expensive Product: {mostExpensiveProduct.Key} - {mostExpensiveProduct.Value}");

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

