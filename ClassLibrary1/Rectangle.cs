using ClassLibrary1.Interfaces;

namespace ClassLibrary1
{
    public class Rectangle : ISquareCalc
    {
        int a, b, c;

        public Rectangle(int a, int b, int c) => (this.a, this.b, this.c) = (a, b, c);
        public double CalculateSquare()
        {
            double p = (a + b + c) / 2;
            double square = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            return square;
        }

        public bool IsRectangular() => Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
    }
}
