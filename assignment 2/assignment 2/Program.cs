// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
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
    }
}
