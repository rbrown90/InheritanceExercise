using System;
namespace Inheritance
{
	public class Reptile:Animal
	{
		public Reptile()
		{
			NeedsToEat = "yes";
			NeedsToSleep = "yes";
			HasCells = true;
			HasLegs = 0;
		}

		public string ColdBlooded { get; set; }
		public bool IsATetrapod { get; set; }
		public bool CoveredInScales { get; set; }
		public string IsAnAmphibion { get; set; }
	}
}

