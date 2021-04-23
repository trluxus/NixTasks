using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var pic = new Picture(0, 0, new Circle(10, 10, 5));
            pic.Print();
            pic.addShape(new Rectangle(0, 0, 5, 5));
            pic.Print();
        }
    }
}
