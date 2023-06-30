using System;

public class Program
{
    public static void Main()
    {
        double x1 = 2;
        double y1 = 2;
        double x2 = 6;
        double y2 = 10;

        Console.WriteLine(DlugoscOdcinka(x1, y1, x2, y2));
    }

    public static double DlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}

