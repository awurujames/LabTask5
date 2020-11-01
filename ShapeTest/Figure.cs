namespace ShapeTest
{
    public class Figure
    {
        public double X { get; set; }
        public double Y { get; set; }
        // public string Name { get; set; }

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
            // Name = name;
        }

        public virtual double Area()
        {
            return (X * Y);
        }

    }

    public class Rectangle : Figure
    {
        public double Length { get; set; }
        public double Breath { get; set; }


        public Rectangle(double x, double y, double length, double breath) : base(x, y)
        {
            Length = length;
            Breath = breath;
        }


        public override double Area()
        {
            return (Length * Breath);
        }
    }

    public class Triangle : Figure
    {
        public double MyBase { get; set; }
        public double Heigth { get; set; }


        public Triangle(double x, double y, double myBase, double heigth) : base(x, y)
        {
            MyBase = myBase;
            Heigth = heigth;
        }
        public override double Area()
        {
            return (0.5 * MyBase * Heigth);
        }
    }


    public class Squar : Figure
    {
        public double A { get; set; }
        public double B { get; set; }


        public Squar(double x, double y, double a, double b) : base(x, y)
        {
            A = a;
            B = b;
        }
        public override double Area()
        {
            return (A * B);

        }
    }

    public class Cube : Figure
    {
        public double S { get; set; }


        public Cube(double x, double y, double s) : base(x, y)
        {
            S = s;
        }
        public override double Area()
        {
            return (S * 6);
        }
    }


}