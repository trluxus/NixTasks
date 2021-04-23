using System.Linq;

namespace Shapes
{
    class Picture : Point
    {
        private Point[] shapes;

        public Point[] Shapes
        {
            get { return shapes; }
            set { shapes = value; }
        }

        public Picture(double x, double y, params Point[] shapes)
            :base(x, y)
        {
            Shapes = shapes;
        }

        public void addShape(Point shape) =>   
            Shapes = Shapes.Append(shape).ToArray();

        public override void Scale(double k)
        {
            foreach(var s in Shapes)
                s.Scale(k);
        }

        public override void Print()
        {
            foreach (var s in Shapes)
                s.Print();
        }
    }
}
