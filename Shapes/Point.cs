using System;

namespace Shapes
{
    abstract class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Point: (X:{X}, Y:{Y}).");
        }

        public abstract void Scale(double k);
    }
}
