// See https://aka.ms/new-console-template for more information

namespace FabryPerot;

internal class Intensity
{
    private double _wavelength;
    private double _medium;
    private double _distance;
    private double _k => Math.PI / _wavelength;
    private int _n;
    private int _size;
    private int _step => _size / _n;

    private double[,] _value => new double[_n, _n];

    public double[,] Value => _value;

    public Intensity(
        double wavelength,
        double medium,
        double distance,
        int n,
        int size
    )
    {
        _wavelength = wavelength;
        _medium = medium;
        _distance = distance;
        _n = n;
        _size = size;
    }
}

internal class App
{
    private static void Main()
    {
        var i = new Intensity(200, 1, 100, 10, 100);
        for (var i1 = 0; i1 < i.Value.Length; i1++)
        {
            Console.WriteLine(i.Value[0, 0]);
        }

        Console.WriteLine(1);
    }
}