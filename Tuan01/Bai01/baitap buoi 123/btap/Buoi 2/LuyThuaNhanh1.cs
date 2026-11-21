using System;

public class LuyThuaNhanh1
{
	public static void Chay(string[] args)
	{
        double a;
        Console.Write("Moi ban nhap so thuc a: ");
        a = double.Parse(Console.ReadLine());
        double a2 = a * a;                 
        double a3 = a2 * a;                
        double a5 = a2 * a3;               
        double a4 = a2 * a2;              
        double a8 = a4 * a4;              
        double a16 = a8 * a8;              
        double a17 = a16 * a;               
        Console.WriteLine("Ket qua: 2^2={0:F2}, 2^5={1:F2}, 2^17={2:F2}", a2, a5, a17);
    }
}
