using Practice9.interfaces;
using Practice9.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice9.models
{
    class Circle : Shape, IPerimeter
    {
        public override double Area => Math.Pow(this.Size, 2) * Math.PI;
        public new double Perimeter => 2 * Math.PI * this.Size;

        public Circle(string name) : base(name, EnumFigureByNumberOfVertices.CIRCLE)
        {
            
        }

        public Circle(string name, int radius) : base(name, EnumFigureByNumberOfVertices.CIRCLE, size: radius)
        {

        }

        public Circle(string name, int side, ConsoleColor color) : base(name, EnumFigureByNumberOfVertices.CIRCLE, size: side, color: color)
        {

        }

        public Circle(string name, int side, ConsoleColor color, string symbol) : base(name, EnumFigureByNumberOfVertices.CIRCLE, size: side, color: color, symbol: symbol)
        {

        }


        public new void Draw()
        {
            Console.WriteLine("ddddddddddd");
            base.Draw();
        }

        protected override void FigureShape()
        {
            Console.WriteLine("------------------------");
            int size = this.Size * 2;
            for (int i = 3; i <= size - 2; i++)
            {
                if (i <= size / 2)
                {
                    for (int j = 1; j <= size - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < i * 2; k++)
                    {
                        Console.Write(this.Symbol);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < (size - i + 1) * 2 - 1; k++)
                    {
                        Console.Write(this.Symbol);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("------------------------");
        }
    }
}
