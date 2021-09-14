using System;

namespace BARSGroupMyteTask
{
    public struct Dot
    {
        public double x;
        public double y;

        public Dot(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public override string ToString() =>
            $"({x} ; {y})";
    }

    public class Section : IComparable<Section>
    {
        public Dot PointA;
        public Dot PointB;
        private double lenghtMagnitude;
        private double lenght;
        public double LenghtMagnitude
        {
            get
            {
                GetLenghtMagnitude();
                return lenghtMagnitude;
            }
        }
        public double Lenght
        {
            get
            {
                GetLenght();
                return lenght;
            }
        }

        public int CompareTo(Section other) =>
            LenghtMagnitude.CompareTo(other.LenghtMagnitude);

        public override string ToString() =>
        $"PointA: {PointA} PointB: {PointB} Lenght: {Lenght}";

        public Section(double AX, double AY, double BX, double BY)
        {
            PointA = new Dot(AX, AY);
            PointB = new Dot(BX, BY);
            lenghtMagnitude = -1;
            lenght = -1;
        }

        private void GetLenghtMagnitude()
        {
            if (lenghtMagnitude != -1)
                return;
            double deltaX = PointA.x - PointB.x;
            double deltaY = PointA.y - PointB.y;
            lenghtMagnitude = deltaX * deltaX + deltaY * deltaY;
        }

        private void GetLenght()
        {
            if (lenght != -1)
                return;
            lenght = (double)Math.Sqrt(LenghtMagnitude);
        }
    }
}
