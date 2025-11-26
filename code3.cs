using System;
public class Vector
{
    private double[] components;
    public Vector(params double[] components)
    {
        this.components = components ?? throw new ArgumentNullException(nameof(components));
    }
    public static double operator *(Vector v1, Vector v2)
    {
        if (v1.components.Length != v2.components.Length)
            throw new ArgumentException("Векторы должны иметь одинаковую размерность");

        double result = 0;
        for (int i = 0; i < v1.components.Length; i++)
        {
            result += v1.components[i] * v2.components[i];
        }
        return result;
    }
    public double this[int index]
    {
        get
        {
            if (index < 0 || index >= components.Length)
                throw new IndexOutOfRangeException("Индекс выходит за границы вектора");
            return components[index];
        }
        set
        {
            if (index < 0 || index >= components.Length)
                throw new IndexOutOfRangeException("Индекс выходит за границы вектора");
            components[index] = value;
        }
    }
    public override string ToString()
    {
        return "[" + string.Join(", ", components) + "]";
    }
    public int Dimension => components.Length;
    public Vector(Vector other)
    {
        this.components = (double[])other.components.Clone();
    }
}
class Program
{
    static void Main()
    {
        var v1 = new Vector(1, 2, 3);
        var v2 = new Vector(4, 5, 6);
        Console.WriteLine(v1 * v2); 
        v1[1] = 10;
        Console.WriteLine(v1);    
        Console.WriteLine($"Размерность v1: {v1.Dimension}");
        Console.WriteLine($"v1[0] = {v1[0]}");
        Console.WriteLine($"v1[2] = {v1[2]}");
    }
}