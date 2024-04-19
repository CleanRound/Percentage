internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the value: ");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine("Enter the percentage: ");
            if (double.TryParse(Console.ReadLine(), out double percentage))
            {
                double result = (percentage / 100) * value;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input for percentage.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input for value.");
        }
    }
}