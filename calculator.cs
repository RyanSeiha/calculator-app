class Calculator
{
	static void Main (string[] args)
	{
        int a;
        int b;
        double c, d;
        int pilih;

        Console.WriteLine("Pilih Menu Kalkulator");
        Console.WriteLine("1. Penjumlahan/n");
        Console.WriteLine("2. Pengurangan/n");
        Console.WriteLine("3. Perkalian/n");
        Console.WriteLine("4. Pembagian/n");

        Console.WriteLine("Pilih Menu Kalulator (1/2/3/4)");
        pilih = Convert.ToInt32(Console.ReadLine());

        if (pilih == 1)
        {
            Console.Write("Masukan Angka 1 :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Angka 2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil : " + penambahan(a, b));
        }
        else if (pilih == 2)
        {
            Console.Write("Masukan Angka 1 :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Angka 2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil : " + pengurangan(a, b));
        }
        else if (pilih == 3)
        {
            Console.Write("Masukan Angka 1 :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Angka 2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil : " + perkalian(a, b));
        }
        else if (pilih == 4)
        {
            Console.Write("Masukan Angka 1 :");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Angka 2 : ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hasil : " + pembagian(c, d));
        }
        else
        {
            Console.WriteLine("Kode Salah Bro!!!");
        }

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
    }
    static int penambahan(int a, int b)
    {
        return a + b;
    }
    static int pengurangan(int a, int b)
    {
        return a - b;
    }
    static int perkalian(int a, int b)
    {
        return a * b;
    }
    static double pembagian(double a, double b)
    {
        return a / b;
    }
}