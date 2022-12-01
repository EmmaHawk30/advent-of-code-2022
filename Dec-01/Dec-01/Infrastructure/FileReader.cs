namespace Dec_01.Infrastructure;

public class FileReader
{
    public static Task<string> ReadFile(string inputFileLocation)
    {
        var input = File.ReadAllText(inputFileLocation);

        return Task.FromResult(input);
    }
}
