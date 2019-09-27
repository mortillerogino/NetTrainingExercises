using System;
using System.Collections.Generic;
using System.Text;

namespace GreatestProductOf20x20
{
    public enum Directions
    {
        Horizontal,
        Vertical,
        ForwardDiagonal,
        BackwardDiagonal
    }

    public class ProductResult
    {
        public int Product { get; set; }
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public Directions Direction { get; set; }

        
    }
}
