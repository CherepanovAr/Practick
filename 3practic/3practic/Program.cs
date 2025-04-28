class Vowels
{
	static void Main()
	{
		try
		{
			Console.Write("Введите строку: ");
			string input = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input))

				throw new Exception("Строка пустая");

			string vowels = "аеёиоуыэюяaeiouyАЕЁИОУЫЭЮЯAEIOUY";
			foreach (char c in input)
			{
				if (vowels.Contains(c))
					Console.Write(c + " ");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Ошибка: {ex.Message}");
		}
	}
}
