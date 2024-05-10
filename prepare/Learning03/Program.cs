using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

    }

}


public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top=1;
        _bottom=1;
    }
    public Fraction(int wholenumber)
    {
         _top= wholenumber;
         _bottom=1;
    }
    public Fraction(int top, int bottom)
    {
        _top=top;
        _bottom=bottom;
    }
    public string GetFractionstring()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimal()
    {
        return (double)_top/ (double)_bottom;
    }

}


















