using System;
namespace CarSimulator
{
	public class Test
	{
		static void Main(string[] args)
		{
			State myTestState;
			myTestState= new State(15, 15, 15, 15);
			Console.WriteLine("p:{0}, v:{1}, a:{2}, t:{3}", myTestState.position, myTestState.velocity, myTestState.acceleration, myTestState.time);
			myTestState.set(1.0, 1.1, 1.2, 1.3);
			Console.WriteLine("p:{0}, v:{1}, a:{2}, t:{3}", myTestState.position, myTestState.velocity, myTestState.acceleration, myTestState.time);
		}
	}
}

