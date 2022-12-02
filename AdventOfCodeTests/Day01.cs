using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCodeTests;

public class Day01
{
    [Fact]
    public void GivenFileWithElves_WhenSummed_ThenReturnElfWithMostCalories()
    {
        var inputPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"day01test.txt");

        var elves = Program.ParseInput(inputPath).Last();

        Assert.Equal(24000, elves);

    }

    [Fact]
    public void GivenFileWithElves_WhenSummed_ThenReturnTopThreeElvesWithMostCalories()
    {
        var inputPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"day01test.txt");

        var elves = Program.ParseInput(inputPath);

        Assert.Equal(45000, elves.Sum());

    }
}
