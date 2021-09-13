using System;

namespace CarSimulator
{

    public class Physics1D
    {
        // Implement the methods
        public static double compute_position(double x0, double v, double dt)
        { 
            // to do
            var position = x0 + (v * dt); // Math to solve for postion
            return position;
        }
        public static double compute_velocity(double v0, double a, double dt)
        { 
            // to do
            var velocity = v0 + (a * dt); // Math to solve for velocity
            return velocity;
        }
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        { 
            // to do
            var velocity = (x1 - x0)/(t1 - t0); // Math to solve for velocity
            return velocity;
        }
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        { 
            // to do
            var acceleration  = (v1 - v0)/(t1 - t0); // Math to solve for acceleration
            return acceleration;
        }
        public static double compute_acceleration(double f, double m)
        { 
            // to do
            var acceleration = f / m; // Math to solve for acceleration
            return acceleration;
        }
    }
}
