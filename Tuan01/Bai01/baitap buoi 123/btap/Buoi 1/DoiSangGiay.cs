using System;

public class DoiSangGiay
{
	public static void Chay()
	{
		Console.Write("Nhap so gio:");
		int h = int.Parse(Console.ReadLine());
		Console.Write("Nhap so phut:");
		int m = int.Parse(Console.ReadLine());
		Console.Write("Nhap so giay:");
		int s = int.Parse(Console.ReadLine());
		int TongGiay = h * 3600 + m * 60 + s;
		Console.WriteLine($"Tong so giay cua {h}:{m}:{s} la {TongGiay} giay");
	}
}
