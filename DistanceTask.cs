using System;

namespace DistanceTask
{
    public static class DistanceTask

    {

        //Задание
        //Напишите метод вычисления расстояния от отрезка до точки.
        //Решение(выполнено самостоятельно):
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by,
          double x, double y)
        {

            double distanceToLine = ((by - ay) * x) - ((bx - ax) * y) + (bx * ay) - (by * ax);
            if (distanceToLine < 0)
            {
                distanceToLine = -1 * distanceToLine;
            }

            double distanceAB = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
            double scalarMultiplicationAXAB = (x - ax) * (bx - ax) + (y - ay) * (by - ay);
            double scalarMultiplicationBXAB = (x - bx) * (-bx + ax) + (y - by) * (-by + ay);
            if (distanceAB == 0) return DistanceToPoint(y, ay, x, ax);
            else if (scalarMultiplicationAXAB >= 0 && scalarMultiplicationBXAB >= 0)
            {
                double distanceGyotenuse;
                return distanceGyotenuse = distanceToLine / (Math.Sqrt(Math.Pow(by - ay, 2) + Math.Pow(bx - ax, 2)));

            }
            else return Math.Min(DistanceToPoint(y, ay, x, ax), DistanceToPoint(y, by, x, bx));

        }

        public static double DistanceToPoint(double yToPoint, double byToPoint, double xToPoint, double bxToPoint)
        {
            return Math.Sqrt(Math.Pow((yToPoint - byToPoint), 2) + Math.Pow((xToPoint - bxToPoint), 2));

        }

    }

}


