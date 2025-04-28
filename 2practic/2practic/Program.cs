public class IMT
{
	static void Main()
	{
		Console.Write("Вес (кг): ");
		double w = Convert.ToDouble(Console.ReadLine());
		Console.Write("Рост (м): ");
		double h = Convert.ToDouble(Console.ReadLine());
		double imt = w / (h * h);

		string status = imt < 18.5 ? "Недостаток" : imt < 25 ? "Норма" : "Избыток";

		Console.WriteLine($"ИМТ: {imt} - {status}");
	}
}
