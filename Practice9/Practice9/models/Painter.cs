using Practice9.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice9.models
{
    class Painter : IDraw
    {
        public Picture Picture {
            get;
            protected set;
        }

        public Painter()
        {
            this.Picture = new Picture();
        }

        public Painter(int maxNumberOfFigures)
        {
            this.Picture = new Picture(maxNumberOfFigures);
        }

        public Painter(Picture picture)
        {
            this.Picture = picture;
        }

        public void CreateNewPicture(Picture picture)
        {
            this.Picture = picture;
        }

        public void AddShapeToPicture(Shape newShape)
        {
            if (this.Picture.Shapes.Capacity > this.Picture.CountOfShapes)
            {
                this.Picture.Shapes.Add(newShape);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to add as picture is full!");
                Console.ResetColor();
            }

        }

        public void AddShapeToPicture(Shape[] newShapes)
        {
            foreach (var shape in newShapes)
            {
                AddShapeToPicture(shape);
            }  
        }


        public void Draw()
        {
            this.Picture.Shapes.ForEach(shape => shape.Draw());
        }

        public void RemoveShape(string name)
        {
            this.Picture.Shapes.RemoveAll(shape => shape.Name == name);
        }
        public void RemoveShape(Type type)
        {
            this.Picture.Shapes.RemoveAll(shape => shape.GetType() == type);
        }
        public void RemoveShape(double maxArea)
        {
            this.Picture.Shapes.RemoveAll(shape => shape.Area > maxArea);
        }
    }
}
