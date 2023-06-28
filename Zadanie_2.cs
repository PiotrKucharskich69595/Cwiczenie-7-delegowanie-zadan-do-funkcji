using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędne punktu początkowego:");
        Console.Write("X1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędne punktu końcowego:");
        Console.Write("X2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine($"Długość odcinka wynosi: {dlugoscOdcinka}");
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;

        double dlugoscOdcinka = Math.Sqrt(dx * dx + dy * dy);

        return dlugoscOdcinka;
    }
}