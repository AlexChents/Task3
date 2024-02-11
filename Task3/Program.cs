using System.Text;

namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть кількість чисел Фібоначчі");
			int count = Convert.ToInt32(Console.ReadLine());

			//Iterator
			var timeStart = DateTime.Now;
            Console.WriteLine("Iterator");
            for (int i = 0; i < count; i++)
			{
                Console.Write(FibonacciIterator(i) + " ");
			}
			var timeStop = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Загальний час виконання через Iterator: " + (timeStop - timeStart).TotalSeconds + " секунд");
            Console.WriteLine();
			
			//Recursive
            timeStart = DateTime.Now;
            Console.WriteLine("Recursive");
			for (int i = 0; i < count; i++)
			{
				Console.Write(FibonacciRecursive(i) + " ");
			}
			timeStop = DateTime.Now;
			Console.WriteLine();
            Console.WriteLine("Загальний час виконання через Recursive: " + (timeStop - timeStart).TotalSeconds + " секунд");
            Console.WriteLine();
            Console.WriteLine("Намагання вивести кількість чисел Фібоначчі до 28 за допомогою рекурсії - швидкіть значно більша за ітератор.");
            Console.WriteLine("Намагання вивести від 28 до 30 чисел Фібоначчі за допомогою рекурсії - швидкість починає зрівнюватися ");
            Console.WriteLine("Намагання вивести більше 30 чисел Фібоначчі за допомогою рекурсії  - час виконання збільшує в геометричній прогресії");
            Console.WriteLine("Намагання вивести більше 60 чисел Фібоначчі за допомогою рекурсії призведе до stackoverflowexception");
            Console.ReadKey();
		}

		private static int FibonacciRecursive(int count)
		{
			if (count == 0 || count == 1)
			{
				return count;
			}
			else
			{
				return FibonacciRecursive(count - 2) + FibonacciRecursive(count - 1);
			}
		}

		private static int FibonacciIterator(int count)
		{
			if (count == 0 || count == 1)
			{ 
				return count; 
			}
			else
			{
				int firstNumber = 0;
				int secondNumber = 1;
				int result = 0;
				for (int i = 2; i <= count; i++)
				{
					result = firstNumber + secondNumber;
					firstNumber = secondNumber; 
					secondNumber = result;
				}
				return result;
			}
		}
	}
}
