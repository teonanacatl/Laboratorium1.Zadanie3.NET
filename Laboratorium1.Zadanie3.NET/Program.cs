namespace Laboratorium1.Zadanie3.NET
{
    class Program
    {
        static void Main()
        {
            string path = @"data\test.txt";

            using FileStream fileStream = new FileStream(path, FileMode.Open);
            using StreamReader reader = new StreamReader(fileStream);

            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}