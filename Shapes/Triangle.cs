using System;

namespace Shapes
{
    class Triangle : Rectangle
    {
        private double dx;
        private double dy;

        public double DX
        {
            get { return dx; }
            set { dx = value; }
        }

        public double DY
        {
            get { return dy; }
            set { dy = value; }
        }

        public Triangle(double x, double y, double w, double h, double dx, double dy)
            : base(x, y, w, h)
        {
            DX = dx;
            DY = dy;
        }

        public override void Scale(double k)
        {
            base.Scale(k);

            DX *= k;
            DY *= k;
        }

        public override void Print()
        {
            Console.WriteLine($"Triangle: (P1: (X:{X}, Y:{Y}); P2: (X:{W}, Y:{H}); P3: (X:{DX}, Y:{DY})).");
        }

        public override void Move(double x, double y)
        {
            base.Move(x, y);

            DX += x;
            DY += y;
        }
    }
}
