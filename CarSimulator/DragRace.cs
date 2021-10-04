using System;
namespace CarSimulator
{
    public class DragRace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
            Car myPrius = new Car("Prius", 1000, 750, 0.43);

            // drive for 60 seconds with delta time of 1s
            double dt = 0.1;
            double t = 0;

            // Drag Race to 402.3m mark

            while((myTesla.myCarState.position < 402.3) ||
                (myPrius.myCarState.position < 402.3)) 
            {
                myTesla.Drive(t);
                myPrius.Drive(t);
                // print the time and current state
                Console.WriteLine("time: {0}",t);
                Console.WriteLine("Tesla State: p:{0}, v:{1}, a:{2}, t:{3}",
                    myTesla.myCarState.position,
                    myTesla.myCarState.velocity,
                    myTesla.myCarState.acceleration,
                    myTesla.myCarState.time);
                Console.WriteLine("Prius State: p:{0}, v:{1}, a:{2}, t:{3}",
                    myPrius.myCarState.position,
                    myPrius.myCarState.velocity,
                    myPrius.myCarState.acceleration,
                    myPrius.myCarState.time);
                // print who is in lead
                if (myTesla.myCarState.position > myPrius.myCarState.position)
                {
                    Console.WriteLine("Leader: Tesla\n");
                }
                else if (myTesla.myCarState.position < myPrius.myCarState.position)
                {
                    Console.WriteLine("Leader: Prius\n");
                }
                else
                {
                    Console.WriteLine("Leader: Neither\n");
                }
                t += dt;
            }
            if (myTesla.myCarState.position > myPrius.myCarState.position)
            {
                Console.WriteLine("Winner: Tesla\n");
            }
            else if (myTesla.myCarState.position < myPrius.myCarState.position)
            {
                Console.WriteLine("Winner: Prius\n");
            }

            // Drag Race for 60 Seconds Code
            /*
            for (double t = 0; t < 60; t += dt)
            {
                myTesla.drive(t);
                myPrius.drive(t);
                // print the time and current state
                Console.WriteLine("time: {0}", t);
                Console.WriteLine("Tesla State: p:{0}, v:{1}, a:{2}, t:{3}",
                    myTesla.myCarState.position,
                    myTesla.myCarState.velocity,
                    myTesla.myCarState.acceleration,
                    myTesla.myCarState.time);
                Console.WriteLine("Prius State: p:{0}, v:{1}, a:{2}, t:{3}",
                    myPrius.myCarState.position,
                    myPrius.myCarState.velocity,
                    myPrius.myCarState.acceleration,
                    myPrius.myCarState.time);
                // print who is in lead
                if (myTesla.myCarState.position > myPrius.myCarState.position)
                {
                    Console.WriteLine("Leader: Tesla\n");
                }
                else if (myTesla.myCarState.position < myPrius.myCarState.position)
                {
                    Console.WriteLine("Leader: Prius\n");
                }
                else
                {
                    Console.WriteLine("Leader: Neither\n");
                }
            }
            */

        }
    }
}
