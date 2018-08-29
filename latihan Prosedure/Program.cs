using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_Prosedure
{
    class Program
    {
        static void Main(string[] args)
        {

            My10.BuatKotak(5, 1, 115, 5);
            My10.BuatKotak(5, 6, 17, 25);
            My10.BuatKotak(18, 6, 115, 25);

            string judul = "Wearnes Education Center Madiun ";
            My10.Tulis((120 - judul.Length) / 2, 2, judul);

            string subjudul = "Informstika 1 -2018 ";
            My10.Tulis((120 - subjudul.Length) / 2, 3, subjudul);

            My10.TulisWarna(6, 7, ":: MENU ::", ConsoleColor.Cyan, ConsoleColor.Blue);

            string[] menu = new string[7];
            menu[0] = " Siswa ";
            menu[1] = " Dosen ";
            menu[2] = " Matkul ";
            menu[3] = " Nilai ";
            menu[4] = " Absen ";
            menu[5] = " Bayar ";
            menu[6] = "Keluar ";

            for (int i = 0; i < 7; i++)
            {
                My10.Tulis(6, 8 + 1, menu[i]);
            }
            int pilihan = 0;

            My10.TulisWarna(6, 8, menu[pilihan], ConsoleColor.Black, ConsoleColor.Cyan);

            ConsoleKeyInfo tombol;
            do
            {
                tombol = Console.ReadKey(true);

                if(tombol.Key == ConsoleKey.DownArrow)
                {
                    My10.TulisWarna(6,8 + pilihan,menu[pilihan],ConsoleColor.White,ConsoleColor.Black);
                    pilihan++;

                    My10.TulisWarna(6,8+pilihan,menu[pilihan],ConsoleColor.Black,ConsoleColor.Cyan);
                }

            }while(tombol.Key !=ConsoleKey.Enter);

            My10.Tulis(20, 10, "Nama Siswa : ");
            My10.Tulis(20,12, "Kelas      : ");
            My10.Tulis(20, 14, "Alamat     : ");

            string nama = My10.Input(40, 10);
            string kelas = My10.Input(40, 12);
            string alamat = My10.Input(40, 14);

            Console.ReadKey();



        }
    
    }
}
