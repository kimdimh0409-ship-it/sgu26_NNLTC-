using System;

public class HinhTron {
	public static void Chay() {
		Console.WriteLine("Nhap ban kinh R:");
		double R = double.Parse(Console.ReadLine());
		double S = 3.14 * R * R;
		double P = 2 * 3.14 * R;
		Console.WriteLine($"Dien tich hinh tron= {S:F1}");
        Console.WriteLine($"Chu vi hinh tron= {P:F1}");

    }
}
