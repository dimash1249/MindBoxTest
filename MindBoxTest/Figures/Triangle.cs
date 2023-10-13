namespace MindBoxTest.Figures
{
    internal class Triangle : ITriangle
    {
        public Triangle(double edge1, double edge2, double edge3)
        {
            if (edge1 <= 0.0) throw new ArgumentException("Wrong edge length", nameof(edge1));
            if (edge2 <= 0.0) throw new ArgumentException("Wrong edge length", nameof(edge2));
            if (edge3 <= 0.0) throw new ArgumentException("Wrong edge length", nameof(edge3));

            if (edge1 + edge2 > edge3 && edge1 + edge3 > edge3 && edge2 + edge3 > edge1)
            {
                IsTriangle = true;
            }

            if (RightTriangle(edge1, edge2, edge3))
            {
                IsRightTriangle = true;
            }

            A = edge1;
            B = edge2;
            C = edge3;
        }

        public double A { get; }

        public double B { get; }

        public double C { get; }
        public bool IsTriangle { get; }
        public bool IsRightTriangle { get; }

        public double GetArea()
        {
            if (IsTriangle)
            {
                double halfPerimeter = (A + B + C) / 2d;
                var area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
                return area;
            }
            else
            {
                return -1d;
            }
        }

        public bool RightTriangle(double a, double b, double c)
        {
            double asquare = Math.Pow(a, 2);
            double bsquare = Math.Pow(b, 2);
            double csquare = Math.Pow(c, 2);
            switch (asquare + bsquare == csquare)
            {
                case true: { return true; }
                case false:
                    {
                        switch (asquare + csquare == bsquare)
                        {
                            case true: { return true; }
                            case false:
                                {
                                    switch (bsquare + csquare == asquare)
                                    {
                                        case true: { return true; }
                                        case false: { return false; }
                                    }
                                }
                        }
                    }
            }
        }
    }
}
