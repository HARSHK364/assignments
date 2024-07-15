// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
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

    }
}