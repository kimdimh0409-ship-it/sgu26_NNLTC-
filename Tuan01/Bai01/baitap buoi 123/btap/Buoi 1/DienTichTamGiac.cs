using System;

public class DienTichTamGiac
{
	public static void Chay()
	{
        Console.WriteLine("Nhap do dai canh a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap do dai canh b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap do dai canh c:");
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Dien tich tam giac S = {S:F2}");

    }
}
