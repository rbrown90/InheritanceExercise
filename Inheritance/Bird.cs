using System;
namespace Inheritance
{
	public class Bird:Animal
	{
		public Bird()
		{
			NeedsToSleep = "yes";
			NeedsToEat = "yes";
			HasLegs = 2;
			HasCells = true;
		}

        public bool DoesFly { get; set; }
		public bool Has2Legs { get; set; }
		public int HasWings { get; set; }
		public bool HasBeak { get; set; }
    }
}

