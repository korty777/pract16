using System;
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class code1
{
    static void Main()
    {
        var p1 = new Point(1, 2);
        var p2 = new Point(3, 4);
        Console.WriteLine(p1 + p2);
        Console.WriteLine(p2 - p1);
    }
}