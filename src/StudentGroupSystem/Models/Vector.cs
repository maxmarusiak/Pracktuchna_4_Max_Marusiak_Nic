public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector(double x, double y, double z)
    {
        X = x; Y = y; Z = z;
    }

    public double Length() => Math.Sqrt(X * X + Y * Y + Z * Z);

    public override string ToString() => $"({X}, {Y}, {Z})";

    public static Vector operator +(Vector a, Vector b)
        => new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static Vector operator -(Vector a, Vector b)
        => new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static double operator *(Vector a, Vector b)
        => a.X * b.X + a.Y * b.Y + a.Z * b.Z;

    public static bool operator >(Vector a, Vector b) => a.Length() > b.Length();
    public static bool operator <(Vector a, Vector b) => a.Length() < b.Length();
    public static bool operator ==(Vector a, Vector b) => a.Length() == b.Length();
    public static bool operator !=(Vector a, Vector b) => a.Length() != b.Length();

    public static Vector operator ++(Vector a)
        => new Vector(a.X + 1, a.Y + 1, a.Z + 1);

    public static Vector operator --(Vector a)
        => new Vector(a.X - 1, a.Y - 1, a.Z - 1);

    public static explicit operator double(Vector v) => v.Length();
}
