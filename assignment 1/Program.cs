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

 
    }
}



