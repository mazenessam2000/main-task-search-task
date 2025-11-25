// Main Task
const int smallCarpetPrice = 25;
const int largeCarpetPrice = 35;

int numberOfSmallCarpets = 0;
int numberOfLargeCarpets = 0;

int totalCost = 0;

Console.WriteLine("Enter the amount of small carpets");
numberOfSmallCarpets = ParseNumber(Console.ReadLine());

Console.WriteLine("Enter the amount of large carpets");
numberOfLargeCarpets = ParseNumber(Console.ReadLine());

totalCost = (numberOfSmallCarpets * smallCarpetPrice) + (numberOfLargeCarpets * largeCarpetPrice);

if (totalCost == 0)
{
	Console.WriteLine("No carpets to clean. Exiting.");
	return;
}

double tax = TaxRate(totalCost);

Console.WriteLine();
Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine($"Number of small carpets: {numberOfSmallCarpets} <--");
Console.WriteLine($"Number of large carpets: {numberOfLargeCarpets} <--");
Console.WriteLine($"Price per small carpet: ${smallCarpetPrice}");
Console.WriteLine($"Price per large carpet: ${largeCarpetPrice}");
Console.WriteLine($"Cost: ${totalCost}");
Console.WriteLine($"Tax: ${tax}");
Console.WriteLine($"Total estimate: ${totalCost + tax}");

double TaxRate(int cost)
{
	return cost * 0.06;
}

int ParseNumber(string input)
{
	while (true)
	{
		if (input.ToLower() == "exit")
		{
			break;
		}

		if (int.TryParse(input, out int result))
		{
			return result;
		}

		Console.WriteLine("Invalid input. Please enter a valid number or type 'exit' to quit.");
	}

	return 0;
}