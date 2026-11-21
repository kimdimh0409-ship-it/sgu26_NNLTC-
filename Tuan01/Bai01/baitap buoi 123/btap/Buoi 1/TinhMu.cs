using System;

public class TinhMu
{
	public static void Chay()
	{
		Console.WriteLine("Nhap so thuc a:");
		double a = double.Parse(Console.ReadLine());
		Console.WriteLine("Nhap so mu n:");
		double n = double.Parse(Console.ReadLine());
		double Ketqua = Math.Pow(a,n);
        Console.WriteLine($"Ket qua = {Ketqua:F3}");
    }
}
