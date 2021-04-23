using System;

namespace Shapes
{
    class Rectangle : Point
    {
        private double w;
        private double h;

        public double W
        {
            get { return w; }
            set { w = value; }
        }

        public double H
        {
            get { return h; }
            set { h = value; }
        }

        public Rectangle(double x, double y, double w, double h)
            : base(x, y)
        {
            W = w;
            H = h;
        }

        public override void Scale(double k)
        {
            if (k <= 0)
                throw new Exception();

            W *= k;
            H *= k;
        }

        public override void Print()
        {
            Console.WriteLine($"Rectangle: (P1: (X:{X}, Y:{Y}); P2: (X:{W}, Y:{H})).");
        }

        public override void Move(double x, double y)
        {
            base.Move(x, y);

            W += x;
            H += y;
        }
    }
}
