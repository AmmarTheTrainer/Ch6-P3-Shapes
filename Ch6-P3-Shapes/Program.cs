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

            
            //// Make an array of Shape-compatible objects.
            //Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),new Circle("Beth"),
            //                        new Hexagon("Linda") };

            //Shape customshape = new Hexagon();

            ////Hexagon hexagon = new Shape();

            //myShapes[2].Draw();

            //// Loop over each item and interact with the polymorphic interface.
            //foreach (Shape s in myShapes)
            //{
            //    s.Draw();
            //}

            #region Member shadowing

            // This calls the Draw() method of the ThreeDCircle.
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            //Circle circle = new ThreeDCircle();
            //((ThreeDCircle)circle).Draw();

            // This calls the Draw() method of the parent!
            //((Circle)o).Draw();

            #endregion

            Console.ReadLine();
        }
    }
}
