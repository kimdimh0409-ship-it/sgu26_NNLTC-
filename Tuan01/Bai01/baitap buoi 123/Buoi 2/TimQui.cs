using System;

public class TimQui
{
	public static void Chay(string[] args)
	{
        int thang, qui;
        Console.Write("Moi ban nhap thang: ");
        thang = int.Parse(Console.ReadLine());
        qui = (thang - 1) / 3 + 1;
        Console.WriteLine("Thang {0} thuoc qui {1}.", thang, qui);
    }
}
