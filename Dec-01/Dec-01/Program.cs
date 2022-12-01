using Dec_01;
using Dec_01.Infrastructure;

var inputFileLocation = @"C:\Users\Emma\Documents\_repos\advent-of-code-2022\input\dec-01\input.txt";
var input = FileReader.ReadFile(inputFileLocation).Result; 

var caloriesByElf = InputHandler.SumCaloriesByElf(input).Result;

var maxCalories = ResultProvider.GetMaxCalories(caloriesByElf).Result;
Console.WriteLine(maxCalories);

var sumTopThree = ResultProvider.GetSumOfTopThree(caloriesByElf).Result;
Console.WriteLine(sumTopThree);

Console.ReadKey();