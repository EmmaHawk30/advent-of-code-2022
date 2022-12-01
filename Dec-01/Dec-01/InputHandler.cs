namespace Dec_01;

public class InputHandler
{
    public static Task<List<int>> SumCaloriesByElf(string input)
    {
        var splitFile = input.Split("\n\n");

        List<int> caloriesByElf = new List<int>();

        foreach (string s in splitFile)
        {
            string[] caloriesByElfArray = s.Split('\n');
            int sum = 0;

            foreach (string caloryEntry in caloriesByElfArray)
            {
                var isInt = Int32.TryParse(caloryEntry, out int entryAsInt);

                if (isInt)
                {
                    sum += entryAsInt;
                }
            }

            caloriesByElf.Add(sum);
        }

        return Task.FromResult(caloriesByElf);
    }
}
