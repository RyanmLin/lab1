using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        //implement methods like set, constructors (if applicable)

        public void set(double p, double v, double a, double t)
        {
            position = p;
            velocity = v;
            acceleration = a;
            time = t;
        }

        public State()
        {
            position = 0;
            velocity = 0;
            acceleration = 0;
            time = 0;
        }
        public State(double p, double v, double a, double t)
        {
            set(p, v, a, t);
        }
    }
}
