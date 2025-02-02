using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class GeometryCalculations
    {
        private decimal area(decimal x1, decimal y1, decimal x2,
                       decimal y2, decimal x3, decimal y3)
        {
            return Math.Abs((x1 * (y2 - y3) +
                             x2 * (y3 - y1) +
                             x3 * (y1 - y2)) / (decimal)2.0);
        }

        private bool isInside(decimal x1, decimal y1, decimal x2,
                         decimal y2, decimal x3, decimal y3,
                         decimal x, decimal y)
        {
            decimal A = area(x1, y1, x2, y2, x3, y3);

            decimal A1 = area(x, y, x2, y2, x3, y3);

            decimal A2 = area(x1, y1, x, y, x3, y3);

            decimal A3 = area(x1, y1, x2, y2, x, y);

            return (A == A1 + A2 + A3);
        }

        private bool ifTriangleCanExist(
            decimal triangleAX,
            decimal triangleAY,
            decimal triangleBX,
            decimal triangleBY,
            decimal triangleCX,
            decimal triangleCY
            )
        {
            Vector2 triangleA = new Vector2((float)triangleAX, (float)triangleAY);
            Vector2 triangleB = new Vector2((float)triangleBX, (float)triangleBY);
            Vector2 triangleC = new Vector2((float)triangleCX, (float)triangleCY);
            Vector2 ab = triangleA   - triangleB;
            Vector2 bc = triangleB - triangleC;
            Vector2 ac = triangleA - triangleC;
            if(ab.Length() + bc.Length() > ac.Length() &&
                ab.Length() + ac.Length() > bc.Length() &&
                ac.Length() + bc.Length() > ab.Length()
                )
            {
                return true;
            }
            return false;
        }
        public string getPointTriangleAnswer(
            decimal triangleAX, 
            decimal triangleAY, 
            decimal triangleBX,
            decimal triangleBY,
            decimal triangleCX,
            decimal triangleCY,
            decimal pointX,
            decimal pointY
           )
        {
            if (ifTriangleCanExist(triangleAX, triangleAY, triangleBX, triangleBY, triangleCX, triangleCY))
            {
                if(isInside(triangleAX, triangleAY, triangleBX, triangleBY, triangleCX, triangleCY, pointX, pointY))
                {
                    return "Точка лежит внутри треугольника";
                }
                return "Точка не лежит внутри треугольника";
            }
            return "Треугольник не может существовать";
        }
    }
}
