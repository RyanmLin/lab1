using System;
namespace CarSimulator
{
	public class Herbie : Car
	{
		public Herbie() : base()
		{
			this.model = "Herbie";
			this.mass = 1690;
			this.engineForce = 1420;
			this.dragArea = 0.69;
		}
		public Herbie(string model, double mass, double engineForce, double dragArea)
		{

		}
		public override void Drive(double dt) 
		{
			var v = myCarState.velocity;
			var a = myCarState.acceleration;
			var x0 = myCarState.position;

			a = Physics1D.compute_acceleration(engineForce, mass); // Use engine force as net force
			v = Physics1D.compute_velocity(v, a, dt);
			x1 = Physics1D.compute_position(x0, v, dt);

			myCarState.set(x1, v, a, dt);
		}
	}
}
