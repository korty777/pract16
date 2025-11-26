using System;

public class Counter
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Counter(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public static Counter operator +(Counter counter, int increment)
    {
        return new Counter(counter.Name, counter.Value + increment);
    }

    public int this[string key]
    {
        get
        {
            if (key == "value")
            {
                return Value;
            }
            throw new ArgumentException($"Ключ '{key}' не поддерживается");
        }
        set
        {
            if (key == "value")
            {
                Value = value;
            }

            else
            {
                throw new ArgumentException($"Ключ '{key}' не поддерживается");
            }
        }
    }

    public override string ToString()
    {
        return $"{Name}: {Value}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var c = new Counter("Счётчик", 10);
        c = c + 5;
        Console.WriteLine(c);

        c["value"] = 20;
        Console.WriteLine(c["value"]);
    }
}
