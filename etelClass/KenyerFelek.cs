using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etelClass
{
	internal class KenyerFelek : Etel
	{
		public KenyerFelek(double caloriesPerDkg, double weight, string name) : base(caloriesPerDkg, weight, name)
		{
		}

		public override double CountCalories()
		{
			return Weight * CaloriesPerDkg / 100;
		}

		public override string ToString()
		{
			return "Kenyér " + base.ToString();
		}
	}
}
