using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            double radius = 25;
            int sides = 5;
            Polygon polygon = new Polygon(radius, sides);
            Console.WriteLine($"Polygon with {sides} sides:");
        }
    }
}

