using System;
namespace CarSimulator
{
	public class Prius : Car
	{
		public Prius() : base()
		{
			this.model = "Prius";
			this.mass = 1000;
			this.engineForce = 750;
			this.dragArea = 0.43;
		}
		public Prius(string model, double mass, double engineForce, double dragArea)
		{
			
		}
	}
}
