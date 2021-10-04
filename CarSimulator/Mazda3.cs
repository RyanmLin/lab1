using System;
namespace CarSimulator
{
	public class Mazda3 : Car
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
			this.model = model;
			this.mass = mass;
			this.engineForce = engineForce;
			this.dragArea = dragArea;
		}
	}
}
