using System;
namespace CarSimulator
{
	public class Tesla3 : Car
	{
		public Tesla3() : base()
		{
			this.model = "Tesla3";
			this.mass = 1500;
			this.engineForce = 1000;
			this.dragArea = 0.51;
		}
		public Tesla3(string model, double mass, double engineForce, double dragArea)
		{

		}
	}
}
