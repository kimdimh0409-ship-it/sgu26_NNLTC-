using System;

public class DoiSangGioPhutGiay
{
	public static void Chay()
	{
        Console.Write("Nhap vao tong so giay: ");
        int TongGiay = int.Parse(Console.ReadLine());

        int h = TongGiay / 3600;
        int m = (TongGiay % 3600) / 60;
        int s = TongGiay % 60;

        Console.WriteLine(
            $"{TongGiay} giay = {h}:{m}:{s}");
    }
}
