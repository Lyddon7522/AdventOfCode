public class Program
{
    private static void Main(string[] args)
    {
        var inputPath = Path.Combine(Environment.CurrentDirectory, @"day01.txt");

        var elves = ParseInput(inputPath);

        Console.WriteLine(elves.Last());

        Console.WriteLine(elves.Sum());

        
    }

    public static List<int> ParseInput(string inputPath)
    {
        return File.ReadAllText(inputPath)
            .Split("\n\n")
            .Select(e =>
                e.Split("\n")
                    .Select(int.Parse)
                    .Sum())
            .Order()
            .TakeLast(3)
            .ToList();
    }
}