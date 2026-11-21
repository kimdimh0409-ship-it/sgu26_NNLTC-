using System;

public class PhuongTrinhBac2
{
	public static void Chay(string[] args)
	{
        Console.Write("Moi ban nhap he so a, b, c: ");
        string[] input = Console.ReadLine().Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh vo so nghiem.");
                else
                    Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phuong trinh bac 1 co 1 nghiem, x = {0:F2}.", x);
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh bac 2 {0}x^2 + {1}x + {2} = 0 co 1 nghiem kep, x = {3:F2}.", a, b, c, x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh bac 2 {0}x^2 + {1}x + {2} = 0 co 2 nghiem, x1 = {3:F2}, x2 = {4:F2}.", a, b, c, x1, x2);
            }
        }
    }
}
