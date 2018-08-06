using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P3_Shapes
{
    abstract class Shape
    {
        public string PetName { get; set; }

        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        public abstract void Draw();
        //// A single virtual method.
        //public virtual void Draw()
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}
    }
}
