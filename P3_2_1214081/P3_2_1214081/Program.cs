using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = true;
            while(start)
            {
                Console.WriteLine("MENU PERSEGI PANJANG");

                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");

                Console.WriteLine("");

                var again1 = true;
                Console.Write("Pilih ");
                while (again1)
                {
                    Console.WriteLine("nomor 1 atau nomor 2");
                    string a = Console.ReadLine();
                    if (a == "1")
                    {
                        Console.WriteLine("Masukkan Panjang");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Masukkan Lebar");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
                        Console.Write(b + "*" + c + "=");
                        Console.WriteLine(b * c);
                        again1 = false;
                    }
                    else if (a == "2")
                    {
                        Console.WriteLine("Masukkan Panjang");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Masukkan Lebar");
                        int c = int.Parse(Console.ReadLine());
                        int d = b + c;
                        Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
                        Console.Write(2 + "(" + b + "+" + c + ")" + "=");
                        Console.WriteLine(2 * d);
                        again1 = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Menu tidak tersedia");
                        Console.WriteLine("");
                        Console.Write("Pilih kembali ");
                        again1 = true;
                    }
                }
                
                //Mengulang atau mengakhiri
                var again = true;
                while (again)
                {
                    Console.WriteLine("");
                    Console.Write("Apakan anda ingin mengulangi lagi? (Y/T): ");

                    var input = Console.ReadLine();
                    if (input == "T" || input == "t")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                        again = false;
                    }
                    else if (input == "Y" || input == "y")
                    {
                        Console.Clear();
                        again = false;
                        start = true;
                    }
                    else
                    {
                        again = true;
                    }
                }
                
            }

        }
    }
}
