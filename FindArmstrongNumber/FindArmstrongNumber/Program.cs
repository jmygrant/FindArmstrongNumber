using System;
using System.Collections.Generic;

namespace FindArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int number = 1;
			TestNumber(number);
			number = 371;
			TestNumber(number);
			number = 370;
			TestNumber(number);

			Console.ReadLine();
		}

		private static void TestNumber(int number)
		{
			if (IsArmstrongNumber(number))
			{
				Console.WriteLine(string.Format("The number: {0} is an Armstrong number.", number));
			}
			else
			{
				Console.WriteLine(string.Format("The number: {0} is not an Armstrong number.", number));
			}
		}

		public static bool IsArmstrongNumber(int number)
		{
			//Method One: Solves the problem mathmatically.
			//int copyNumber = number;
			//int parseNumber = (copyNumber % 10);
			//int testNumber = 0;
			//var intList = new List<int>();
			//while(copyNumber > 0)
			//{
			//	intList.Add(parseNumber);
			//	copyNumber -= parseNumber;
			//	copyNumber = copyNumber / 10;
			//	parseNumber = copyNumber % 10;
			//}

			//foreach (var item in intList)
			//{
			//	testNumber += Convert.ToInt32(Math.Pow(item, intList.Count));
			//}

			//if(testNumber == number)
			//{
			//	return true;
			//}
			//return false;

			//Method Two: Solves the problem using strings and conversion.
			string numberStr = number.ToString();
			double power = Convert.ToDouble(numberStr.Length);
			int numberSum = 0;
			foreach(var item in numberStr)
			{
				double value = char.GetNumericValue(item);
				numberSum += Convert.ToInt32(Math.Pow(value, power));
			}

			if (numberSum == number)
			{
				return true;
			}
			return false;
		}
	}
}
