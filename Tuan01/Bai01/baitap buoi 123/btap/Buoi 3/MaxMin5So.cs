using System;

public class MaxMin5So
{
	public static void Chay(string[] args)
	{
        Console.Write("Moi ban nhap 5 so a, b, c, d, e: ");
        string[] input = Console.ReadLine().Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        double d = double.Parse(input[3]);
        double e = double.Parse(input[4]);
        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        if (e > max) max = e;

        double min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        if (e < min) min = e;
        Console.WriteLine("Gia tri lon nhat cua {0}, {1}, {2}, {3}, {4} la {5}.", a, b, c, d, e, max);
        Console.WriteLine("Gia tri nho nhat cua {0}, {1}, {2}, {3}, {4} la {5}.", a, b, c, d, e, min);
    }
}
