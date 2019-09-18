using System;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;


namespace lap_1._2._2
{
    class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }

    class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public bool Contains(Point point) //dung kieu bool de kieu du lieu tra ve la TF
        {
            return this.topLeft.X <= point.X && this.bottomRight.X >= point.X && this.topLeft.Y <= point.Y && this.bottomRight.Y >= point.Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vui long nhap vao toa do cua point topleft and point bottomright as format: 'x_topleft y_topleft x_bottomright y_bottomright' ");
            int[] XYrectangle = Console.ReadLine()
                .Split()                                    //tach chuoi XY rectangle thanh 4 bien 
                .Select(int.Parse)                          //chon bien int
                .ToArray();                                 //them vao mang

            var topLeftPoint = new Point(XYrectangle[0], XYrectangle[1]);           //nhap x_topleft y_topleft
            var bottomRightPoint = new Point(XYrectangle[2], XYrectangle[3]);       //x_bottomright y_bottomright
            var rectangle = new Rectangle(topLeftPoint, bottomRightPoint);          //tao bien moi

            Console.WriteLine("vui long nhap vao so diem");
            int pointsCount = int.Parse(Console.ReadLine()); //dung lenh parse thay cho convert se ngan gon va de dung hon

            for (int i = 0; i < pointsCount; i++)
            {
                int j = i + 1;
                Console.Write("vui long nhap vao toa do cua diem {0} ",j);
                int[] XYpoint = Console.ReadLine()
                    .Split()                                        //tach chuoi XY point thanh 2 bien rieng biet
                    .Select(int.Parse)                              //chon bien int
                    .ToArray();                                     //them vao mang

                Point currentPoint = new Point(XYpoint[0], XYpoint[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }

}