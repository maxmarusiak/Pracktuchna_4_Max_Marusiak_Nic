public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double Length() => Math.Sqrt(X * X + Y * Y + Z * Z);

    public override string ToString() => $"({X}, {Y}, {Z})";

    // +, -, *, ==, !=, >, <, ++, --, (double)
    // (реалізацію допишемо, якщо треба — я можу окремо розписати)
}
