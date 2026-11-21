using System;

public class GiaTriHamSo1
{
	public static void Chay(string[] args)
	{
        Console.Write("Moi ban nhap so thuc x: ");
        double x = double.Parse(Console.ReadLine());
        double f1;
        if (x <= 0) {
            f1 = 0;
        }
        else if (x <= 1) {
            f1 = x;
        }
        else {
            f1 = Math.Pow(x, 4);
        }
        double f2;
        if (x <= 2) {
            f2 = x * x + 4 * x + 5;
        }
        else {
            f2 = 1.0 / (x * x + 4 * x + 5);
        }
        Console.WriteLine("f1({0}) = {1}", x, f1);
        Console.WriteLine("f2({0}) = {1}", x, f2);
    }
}
