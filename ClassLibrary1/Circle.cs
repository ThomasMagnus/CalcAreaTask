using ClassLibrary1.Interfaces;

namespace ClassLibrary1
{
    public class Circle : ISquareCalc
    {
        int r;

        public Circle(int r) => this.r = r;

        public double CalculateSquare() => Math.Round(Math.PI * Math.Pow(r, 2), 2);
    }
}
