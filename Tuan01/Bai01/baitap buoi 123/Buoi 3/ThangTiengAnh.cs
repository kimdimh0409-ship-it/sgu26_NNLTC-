using System;

public class ThangTiengAnh
{
	public static void Chay(string[] args)
	{
        Console.Write("Moi ban nhap vao thang: ");
        int thang = int.Parse(Console.ReadLine());
        string[] tenThang = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
        if (thang >= 1 && thang <= 12)
        {
            Console.WriteLine("Thang {0} trong tieng Anh la: {1}.", thang, tenThang[thang - 1]);
        }
        else
        {
            Console.WriteLine("Thang khong hop le! Vui lòng nhập từ 1 đến 12.");
        }
    }
}
