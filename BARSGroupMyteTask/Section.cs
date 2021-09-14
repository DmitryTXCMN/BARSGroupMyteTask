using System;

namespace BARSGroupMyteTask
{
    public struct Dot
    {
        public double x;
        public double y;

        public Dot(double inputX, double inputY)
        {
            x = inputX;
            y = inputY;
        }
    }

    public class Section
    {
        public Dot PointA;
        public Dot PointB;
        private double lenghtMagnitude;
        private double lenght;

        public Section(double inputAX, double inputAY, double inputBX, double inputBY)
        {
            PointA = new Dot(inputAX, inputAY);
            PointB = new Dot(inputBX, inputBY);
            lenghtMagnitude = -1;
            lenght = -1;
        }

        public double GetLenghtMagnitude()
        {
            if (lenghtMagnitude == -1)
            {
                double deltaX = PointA.x - PointB.x;
                double deltaY = PointA.y - PointB.y;
                lenghtMagnitude = deltaX * deltaX + deltaY * deltaY;
            }
            return lenghtMagnitude;
        }

        public double GetLenght()
        {
            if (lenght == -1)
            {
                if (lenghtMagnitude == -1)
                    GetLenghtMagnitude();
                lenght = (double)Math.Sqrt(lenghtMagnitude);
            }
            return lenght;
        }
    }
}
