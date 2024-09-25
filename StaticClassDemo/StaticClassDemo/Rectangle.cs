using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public class Rectangle
    {
        public int area;
        public int Length { get; set; }
        public int Width { get; set; }
        public void CalcuateArea()
        {
            area = Length * Width;
        }
    }
}
