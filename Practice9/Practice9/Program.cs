using Practice9.models;
using System;
using System.Collections.Generic;

namespace Practice9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------============== Picture1 ==============----------");
            Picture picture1 = new Picture(
             new List<Shape>()
             {
                new Square("MySquare", 5),
                new Triangle("MyTriangle", 5),
                new Circle("MyCircle")
             });


            Painter coolPainterDima = new Painter(picture1);
            coolPainterDima.Draw();


            Console.WriteLine("RemoveShapes ...");
            Console.WriteLine("----------============== Picture1 after remove ==============----------");
            coolPainterDima.RemoveShape(typeof(Triangle));
            coolPainterDima.RemoveShape("MySquare");
            coolPainterDima.RemoveShape(50);
            coolPainterDima.Draw();


            Console.WriteLine("----------============== Picture2 ==============----------");
            Picture picture2 = new Picture(2);
            coolPainterDima.CreateNewPicture(picture2);
            coolPainterDima.AddShapeToPicture(new Square("MySquareeee"));
            coolPainterDima.AddShapeToPicture(new Square("MySquareeee"));
            coolPainterDima.AddShapeToPicture(new Square("MySquareeee"));
            coolPainterDima.Draw();



            Console.ReadKey();
        }
    }
}
