using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P3_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");



            //Hexagon hex = new Hexagon("Beth");
            //hex.Draw();
            //Circle cir = new Circle("Cindy");
            //// Calls base class implementation!
            //cir.Draw();

            
            // Make an array of Shape-compatible objects.
            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),new Circle("Beth"), new Hexagon("Linda")};

            Shape customshape = new Hexagon();

            //Hexagon hexagon = new Shape();

            // Loop over each item and interact with the polymorphic interface.
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            Console.ReadLine();
        }
    }
}
