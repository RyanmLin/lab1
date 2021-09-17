using System;
namespace CarSimulator
{
	public class Mazda3 : Prius
	{
		public Mazda3() : base()
		{
			this.model = "Mazda3";
			this.mass = 1500;
			this.engineForce = 1100;
			this.dragArea = 0.43;
		}
		public Mazda3(string model, double mass, double engineForce, double dragArea)
		{

		}
	}
}
