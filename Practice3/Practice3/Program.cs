using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дані координати (як цілі від 1 до 8) двох різних полів шахівниці.
            // Якщо ферзь за один хід може перейти з одного поля на інше, вивести логічне значення True,
            // інакше вивести значення False. 

            Queen queen = new Queen(new Point(4, 1), new Point(2, 3));

            Console.WriteLine(Checker.check(queen));

            queen.setEnd(new Point(3, 3));

            Console.WriteLine(Checker.check(queen));

            Console.ReadKey();
        }
    }

    interface Chessmen {
        bool canGoThere();
    }

    class Queen : Chessmen {

        private Point start;
        private Point end;

        public Queen(Point start, Point end) {
            this.start = start;
            this.end = end;
        }

        public Point getStart()
        {
            return this.start;
        }

        public void setStart(Point newPoint)
        {
            this.start = newPoint;
        }

        public Point getEnd()
        {
            return this.end;
        }

        public void setEnd(Point newPoint)
        {
            this.end= newPoint;
        }


        public bool canGoThere()
        {
            if (Math.Abs(start.getX() - end.getX()) == Math.Abs(start.getY() - end.getY())
                 || start.getX() == end.getX()
                 || start.getY() == end.getY())
            {
                return true;
            }
            return false;
        }
    }

    class Checker {
        public static bool check(Queen queen) {
            return queen.canGoThere();
        }
    }

    class Point {
        private int x;
        private int y;

        

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int getX() {
            return this.x;
        }
        public void setX(int x) {
            this.x = x;
        }

        public int getY() {
            return this.y;
        }

        public void setY(int y) {
            this.y = y;
        }
    }
}
