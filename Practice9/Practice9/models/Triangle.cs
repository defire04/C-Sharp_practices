using Practice9.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice9.models
{
    class Triangle : Shape
    {
        public override double Area => Math.Pow(this.Size, 2) * Math.Sqrt(3) / 4;
        //public override double Perimeter => this.Size * (int)EnumFigureByNumberOfVertices.TRIANGLE;

        public Triangle(string name) : base(name, EnumFigureByNumberOfVertices.TRIANGLE)
        {

        }

        public Triangle(string name, int side) : base(name, EnumFigureByNumberOfVertices.TRIANGLE, size: side)
        {

        }

        public Triangle(string name, int side, ConsoleColor color) : base(name, EnumFigureByNumberOfVertices.TRIANGLE, size: side, color: color)
        {

        }

        public Triangle(string name, int side, ConsoleColor color, string symbol) : base(name, EnumFigureByNumberOfVertices.TRIANGLE, size: side, color: color, symbol: symbol)
        {

        }


        protected override void FigureShape()
        {
            Console.WriteLine("------------------------");
            for (int i = 1; i < this.Size; i++)
            {

                for (int j = 1; j < this.Size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write(this.Symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
        }
    }
}
