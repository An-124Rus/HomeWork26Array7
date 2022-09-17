using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите строку из слов: ");
        string userText = Console.ReadLine();

        string[] wordsString = userText.Split(' ');

        foreach (string word in wordsString)
        {
            Console.WriteLine(word);
        }
    }
}