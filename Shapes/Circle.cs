using System;

namespace Shapes
{
    class Circle : Point
    {
        private double r;
        
        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public Circle(double x, double y, double r)
            :base(x, y)
        {
            R = r;
        }

        override public void Scale(double k)
        {
            if (k <= 0)
                throw new Exception();

            R *= k;
        }

        public override void Print()
        {
            Console.WriteLine($"Circle: (O: (X:{X}, Y:{Y}); R: {R}).");
        }

    }
}
