using System;
using System.Diagnostics;

namespace ClassWork09
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int ii = 1; ii < 10;ii++)
			{
				int[] initialArray = GetTestArray(ii*2*1000, 1_000_000);
				Stopwatch stopwatch = new Stopwatch();
				//WriteArrayState("Наш массив: ", initialArray);
				int[] bubblesortedArray = (int[])initialArray.Clone();

				stopwatch.Start();
				BubbleSort(bubblesortedArray);
				//WriteArrayState("Отсортированный массив: ", bubblesortedArray);
				stopwatch.Stop();
				Console.WriteLine("Timer: {0}", stopwatch.ElapsedMilliseconds);
				int[] dotNetsortedArray = (int[])initialArray.Clone();
				stopwatch.Restart();
				Array.Sort(dotNetsortedArray);
				stopwatch.Stop();
				Console.WriteLine("Timer dotnet: {0}", stopwatch.ElapsedMilliseconds);
			}

		}
		private static int[] GetTestArray(int length, int maxValue)
		{


			var arr = new int[length];
			var rnd = new Random();
			for (var i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(maxValue);
			}
			return arr;
		}
		private static void WriteArrayState(string message, int[] arr)
		{
			Console.WriteLine(message);
			for (var i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}

		}
		private static void BubbleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length-1;i++)
			{
				var limit = arr.Length - 1-i;

					for (int j = 0; j < limit; j++)
					{
						if (arr[j] > arr[j + 1])
						{
							int temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;

						}
					}
			}

		}
	}
}
