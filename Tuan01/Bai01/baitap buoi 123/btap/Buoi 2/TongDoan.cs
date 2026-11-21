using System;

public class TongDoan
{
	public static void Chay(string[] args)
	{
        int a, b, tongDoan;
        Console.Write("Moi ban nhap so a, b: ");
        string[] input = Console.ReadLine().Split(' ');
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        int tongB = b * (b + 1) / 2;
        int tongA_sub_1 = (a - 1) * a / 2;
        tongDoan = tongB - tongA_sub_1;
        Console.WriteLine("Tong cua cac so trong doan [{0}, {1}] la {2}.", a, b, tongDoan);
    }
}
