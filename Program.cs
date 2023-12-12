namespace NumberToSpokenWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (0 to 9999):");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string words = NumberConverter.ConvertToWords(number);
                Console.WriteLine($"Number in words: {words}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
