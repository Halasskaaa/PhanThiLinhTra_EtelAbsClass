using System.Security.Cryptography.X509Certificates;

namespace etelClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Etel[] etterem =
			{
				new KenyerFelek(2660, 1, "White Bread", false),
				new KenyerFelek(3640, 1, "Brioche", true),
				new KenyerFelek(4710, 1, "Brown Bread", false),

				new Levesek(1250, 3, "Vegetables Soup", false),
				new Levesek(1800, 2, "Vegetables Beef Soup", false),
				new Levesek(2000, 6, "Chicken Soup", false),

				new SultHusok(200, 2, "Chicken Schnitzel", false),
				new SultHusok(350, 3, "Beef Schnitzel", false),
				new SultHusok(300, 4, "Pork Schnitzel", false)
			};

			static double SumCalories()
			{
				double osszKal = 0;
				foreach (var item in etterem)
					{
					double sorba = item.CountCalories();
					osszKal += sorba;
				}
				return osszKal;
			}

			static void IsItDairy()
			{
				List<string> dairyFree = new List<string>();
				foreach (var item in etterem) 
				{
					if (item.IsItDairyFree == false)
					{
						dairyFree.Add(item)
					}
				}
				Console.WriteLine(dairyFree);
			}

		SumCalories();
		IsItDairy();

	}
    }
}
