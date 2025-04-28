public class Age
{
	static void Main()
	{
		for (int fatherAge = 18; fatherAge <= 100; fatherAge++)
		{
			double sonAge = fatherAge / 4.0;
			if (fatherAge + 15 == 2 * (sonAge + 15))
			{
				Console.WriteLine($"Отцу сейчас: {fatherAge} лет");
				return;
			}
		}
	}
}

