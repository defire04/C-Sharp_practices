using Practice9.interfaces;
using Practice9.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice9.models
{
    abstract class Shape : IDraw, IPerimeter
    {   
        public ConsoleColor Color { 
            get;
            protected set; 
        }

        public EnumFigureByNumberOfVertices NumberOfVertices {
            get;
        }

        public string Name
        {
            get;
        }

        public string Symbol
        {
            get;
            protected set;
        }

        public int Size
        {
            get;
            protected set;
        }

        public abstract double Area 
        {
            get;
        }

        public double Perimeter
        {
            get => (int)this.NumberOfVertices * this.Size; 
        }

        public Shape(string name, EnumFigureByNumberOfVertices numberOfVertices, ConsoleColor color = 0, int size = -1, string symbol = "*")
        {
            if (size == -1)
            {
                size = Randomize.Size();
            }

            if (color == 0)
            {
                color = Randomize.Color();
            }


            this.Name = name;
            this.NumberOfVertices = numberOfVertices;
            this.Size = size;
            this.Color = color;
            this.Symbol = symbol;
        }


        public void Draw()
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine("Figure name: {0}\nFigure size: {1}\nArea = {2}\nPerimeter = {3}", this.Name, this.Size, this.Area, ((IPerimeter)this).Perimeter);
            this.FigureShape();
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected abstract void FigureShape(); 
    }
}
