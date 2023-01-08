using System;
using System.Collections.Generic;
using System.Text;

namespace Practice9.models
{
    class Picture
    {
        // Картина сама не рисуется, ее рисует художник

        public List<Shape> Shapes { 
           get; 
           private set; 
        }
        public int CountOfShapes {
            get => Shapes.Count; 
            set {
                if(CountOfShapes > value)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The number of maximum possible figures is less than it was!\nIt is impossible to draw less shapes than already drawn!");
                    Console.ResetColor();
                    return;
                }
               
                List<Shape> newList = new List<Shape>(value);
                foreach (var shape in this.Shapes)
                {
                    newList.Add(shape);
                }

                this.Shapes = newList;
            }
        }

        [System.Runtime.CompilerServices.IndexerName("Shape")]
        public Shape this[int index]
        {
            get => Shapes[index];
            set => Shapes[index] = value;
        }

        public Picture()
        {
            this.Shapes = new List<Shape>();
        }

        public Picture(int maxNumberOfShapes)
        {
            this.Shapes = new List<Shape>(maxNumberOfShapes);
        }

        public Picture(List<Shape> shapes)
        {
            this.Shapes = shapes;
        }
    }
}
