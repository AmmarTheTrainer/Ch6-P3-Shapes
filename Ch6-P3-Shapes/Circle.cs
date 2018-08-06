using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P3_Shapes
{
    class Circle : Shape
    {
        public Circle()
        {

        }

        public Circle(string name) : base(name)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
    class ThreeDCircle : Circle
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }

    //class CustomShape
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("Drawing a 3D Circle");
    //    }
    //}
}
