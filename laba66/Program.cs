using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое сопротивление (Ом):");
        double R1 = GetValidResistance();

        Console.WriteLine("Введите второе сопротивление (Ом):");
        double R2 = GetValidResistance();

        double R_seq = ResistanceInSeries(R1, R2);
        Console.WriteLine($"Сопротивление в последовательном соединении: {R_seq} Ом");

        double R_parallel = ResistanceInParallel(R1, R2);
        Console.WriteLine($"Сопротивление в параллельном соединении: {R_parallel} Ом");

        Console.ReadLine();
    }

    public static double GetValidResistance(string prompt = "")
    {
        double resistance;
        while (!double.TryParse(Console.ReadLine(), out resistance) || resistance <= 0)
        {
            Console.WriteLine($"Некорректное значение сопротивления. {prompt}");
        }
        return resistance;
    }

    public static double ResistanceInSeries(double R1, double R2)
    {
        return R1 + R2;
    }

    public static double ResistanceInParallel(double R1, double R2)
    {
        double oneOverR = (1 / R1) + (1 / R2);
        return 1 / oneOverR;
    }
}