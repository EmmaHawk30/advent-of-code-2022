namespace Dec_01;

public class ResultProvider
{
    public static Task<int> GetMaxCalories(List<int> caloriesByElf)
    {
        var result = caloriesByElf.Max();

        return Task.FromResult(result);
    }

    public static Task<int> GetSumOfTopThree(List<int> caloriesByElf)
    {
        caloriesByElf.Sort();
        caloriesByElf.Reverse();
        int[] topThree = new int[] { caloriesByElf[0], caloriesByElf[1], caloriesByElf[2] };

        int sumTopThree = 0;

        foreach (int i in topThree)
        {
            sumTopThree += i;
        }

        return Task.FromResult(sumTopThree);
    }
}
