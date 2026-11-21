using System;

public class BieuThucNhanh1
{
	public static void Chay(string[] args)
	{
        double x, fx;
        Console.Write("Moi ban nhap so thuc x: ");
        x = double.Parse(Console.ReadLine());
        double x2 = x * x;
        double x3 = x2 * x;
        fx = 1 + 2 * x + 3 * x2 - 4 * x3;
        Console.WriteLine("f({0}) = {1:F2}", x, fx);
    }
}
