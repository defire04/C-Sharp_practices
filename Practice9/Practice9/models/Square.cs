using Practice9.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice9.models
{
    class Square : Shape
    {

        public override double Area => Math.Pow(this.Size, 2);
        //public override double Perimeter => this.Size * (int)EnumFigureByNumberOfVertices.SQUARE;

        public Square(string name) : base(name, EnumFigureByNumberOfVertices.SQUARE)
        {
          
        }

        public Square(string name, int side) : base(name, EnumFigureByNumberOfVertices.SQUARE, size: side)
        {
            
        }

        public Square(string name, int side, ConsoleColor color) : base(name, EnumFigureByNumberOfVertices.SQUARE, size: side, color: color)
        {

        }

        public Square(string name, int side, ConsoleColor color, string symbol) : base(name, EnumFigureByNumberOfVertices.SQUARE, size: side, color: color, symbol: symbol)
        {

        }

        protected override void FigureShape()
        {
            Console.WriteLine("------------------------");
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    Console.Write(this.Symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
        }
    }
}
