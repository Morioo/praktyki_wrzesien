using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {
            PointF[] pointfTab =
            {
                new PointF(23.8F, 43.64F),
                new PointF (33.3F, 72.11F),     //array
                new PointF(11.1F, 5F)
            };
            foreach (PointF p in pointfTab)
            {
                Console.WriteLine(p);
            }
            Point[] points =
            Array.ConvertAll(pointfTab, new Converter<PointF, Point>(

                DoConvert

                ));
            foreach (Point p in points)
            {
                Console.WriteLine(p);


            }



        }
public static Point DoConvert(PointF pf)
            {
            return new Point(((int)pf.X), (int)pf.Y);
            }







    }
}
