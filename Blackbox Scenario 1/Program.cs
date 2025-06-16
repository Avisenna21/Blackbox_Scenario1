using System;

class Program
{
    static void Main()
    {
        // Array yang menyimpan jumlah hari dalam setiap bulan untuk tahun non-kabisat
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Masukkan bulan (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        // Validasi input bulan
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Bulan tidak valid. Silakan masukkan angka antara 1 dan 12.");
        }
        else
        {
            // Mengambil jumlah hari dari array
            int days = daysInMonth[month - 1];
            Console.WriteLine($"Jumlah hari dalam bulan {month} adalah {days} hari.");
        }
    }
}
