using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etelClass
{
	internal abstract class Etel
	{
		double caloriesPerDkg;
		double weight;
		string name;
		bool IsItDairyFree;

		public double CaloriesPerDkg { get => caloriesPerDkg; set => caloriesPerDkg = value; }
		public double Weight { get => weight; set => weight = value; }
		public string Name { get => name; set => name = value; }

		protected Etel(double caloriesPerDkg, double weight, string name, bool IsItDairyFree = false, bool isItDairyFree = false)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.name = name;
		}

		protected Etel(double caloriesPerDkg, double weight, string name)
		{
			this.caloriesPerDkg = caloriesPerDkg;
			this.weight = weight;
			this.name = name;
			IsItDairyFree = false;
		}

		public void IsDairyFree()
		{
			IsItDairyFree = true; 
		}
		public abstract double CountCalories();
	}
}
