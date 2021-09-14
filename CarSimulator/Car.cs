using System;
namespace CarSimulator
{
    public class Car
    {
        private double mass;
        private string model;
        private double dragArea;
        private double engineForce;
        public State myCarState;

        private double rho = 1.225;
        private double x1, fd, nForce;

        /// implement constructor and methods
        public Car(string mdl, double mas, double eForce, double dArea)
        {
            mass = mas;
            model = mdl;
            dragArea = dArea;
            engineForce = eForce;
            myCarState = new State();
        }

        public void drive(double dt)
        {
            var v = myCarState.velocity;
            var a = myCarState.acceleration;
            var x0 = myCarState.position;
            fd = 0.5 * rho * dragArea * (v * v); // solve for drag force

            nForce = engineForce - fd; // force to calculate acceleration

            a = Physics1D.compute_acceleration(nForce, mass); // solve for acceleration using Physics1D function
            v = Physics1D.compute_velocity(v, a, dt); // solve for velocity 
            x1 = Physics1D.compute_position(x0, v, dt); // solve for current position

            myCarState.set(x1, v, a, dt); // Update car state to be updated
            
        } 
        //implement inheritence

    }
}
