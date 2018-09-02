using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace latihan_Prosedure
{
    class Program
    {
        static void Main(string[] args)
        {
            //My10.Tulis(20, 8, Mysiswa.UangPendaftaran.ToString());

            //Mysiswa imas = new Mysiswa();
            //Mysiswa syamsul = new Mysiswa();

            //imas.TambahTotalBayar(100000);
            //imas.TambahTotalBayar(200000);
            //syamsul.TambahTotalBayar(500000);

            //My10.Tulis(20, 9, syamsul.GetTotalBayar().ToString());


            My10.BuatKotak(5, 1, 115, 5);
            My10.BuatKotak(5, 6, 17, 25);
            My10.BuatKotak(18, 6, 115, 25);

            string judul = "Wearnes Education Center Madiun ";
            My10.TulisWarna((120 - judul.Length) / 2, 2, judul,ConsoleColor.Red,ConsoleColor.Black);

            string subjudul = "Informatika 1 -2018 ";
            My10.Tulis((120 - subjudul.Length) / 2, 3, subjudul);

            My10.TulisWarna(6, 7, ":: MENU ::", ConsoleColor.Cyan, ConsoleColor.Blue);

            //membuat array menu sebanyak 7
            string[] menu = new string[7];
            menu[0] = " Siswa "; //index mulai dari 0
            menu[1] = " Dosen ";
            menu[2] = " Matkul ";
            menu[3] = " Nilai ";
            menu[4] = " Absen ";
            menu[5] = " Bayar ";
            menu[6] = " keluar ";

            for (int i = 0; i < 7; i++)
            {
                //tampilkan array menggunakan for
                My10.Tulis(6, 8 + i, menu[i]);
            }
            int pilihan = 0;//default pilihan
            //kasih warna yang berbeda untuk menu terpilih 

            My10.TulisWarna(6, 8, menu[pilihan], ConsoleColor.Black, ConsoleColor.Cyan);

            //buat perulangan untuk terima input selama 
            //yang ditekan bukan tombol enter

            ConsoleKeyInfo tombol;
            do
            {
                //baca tombol tanpa memunculkan teks
                tombol = Console.ReadKey(true);
                //jika ditekan tombol panah bawah

                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    //menu yang terpilih dibuat warna normal hitam merah
                    My10.TulisWarna(6, 8 + pilihan, menu[pilihan], ConsoleColor.Green, ConsoleColor.Black);
                    if (menu[pilihan] == menu[6])
                    {
                        pilihan = 0;
                    }
                    else { pilihan++; };

                    //rubah warna yang terpilih menjadi warna tersorot
                    My10.TulisWarna(6, 8 + pilihan, menu[pilihan], ConsoleColor.Black, ConsoleColor.Cyan);
                }

                if (tombol.Key == ConsoleKey.UpArrow)
                {
                    //menu yang terpilih dibuat warna normal hitam merahC:\Users\arbi\Downloads\downloud wa\latihan Prosedure\latihan Prosedure\latihan Prosedure\hmm.accdb
                    My10.TulisWarna(6, 8 + pilihan, menu[pilihan], ConsoleColor.Green, ConsoleColor.Black);
                    if (menu[pilihan] == menu[0])
                    {
                        pilihan = 6;
                    }
                    else { pilihan--; };

                    //rubah warna yang terpilih menjadi warna tersorot
                    My10.TulisWarna(6, 8 + pilihan, menu[pilihan], ConsoleColor.Black, ConsoleColor.Cyan);
                }
                //cari event untuk warna panah atas
                if (tombol.Key == ConsoleKey.Enter)
                {
                    if (menu[pilihan] == menu[0])
                    {
                        My10.Tulis(20, 10, "Nis   : ");
                        My10.Tulis(20, 12, "Nama  : ");
                        My10.Tulis(20, 14, "Kelas : ");

                        string nis = My10.Input(28, 10);
                        string nama = My10.Input(28, 12);
                        string kelas = My10.Input(28, 14);

                        My10.Tulis(20, 16, "simpan data siswa [Y/N] : ");
                        string jawab = Console.ReadLine();

                        if (jawab.ToUpper() == "Y")
                        {
                            //simpan ke database

                            //ciptakan query
                            string query = "INSERT INTO siswa (nis,nama,kelas) VALUES (@nis,@nama,@kelas)";
                            //buat koneksi / penghubung
                            string koneksiString = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=hmm.accdb;";
                            OleDbConnection koneksi = new OleDbConnection(koneksiString);
                            koneksi.Open();
                            //buat perintah dan eksesuksi query
                            OleDbCommand cmd = new OleDbCommand(query, koneksi);
                            cmd.Parameters.AddWithValue("nis", nis);
                            cmd.Parameters.AddWithValue("nama", nama);
                            cmd.Parameters.AddWithValue("kelas", kelas);
                            cmd.ExecuteNonQuery();

                        }

                    }
                }

                if (tombol.Key == ConsoleKey.Enter)
                {
                    if (menu[pilihan] == menu[1])
                    {
                        My10.Tulis(20, 10, "Nip      : ");
                        My10.Tulis(20, 12, "Nama     : ");
                        My10.Tulis(20, 14, "Jabatan  : ");

                        string nip = My10.Input(31, 10);
                        string nama = My10.Input(31, 12);
                        string jabatan = My10.Input(31, 14);

                        My10.Tulis(20, 16, "simpan data guru [Y/N] : ");
                        string jawab = Console.ReadLine();

                        if (jawab.ToUpper() == "Y")
                        {
                            //simpan ke database

                            //ciptakan query
                            string query = "INSERT INTO guru (nip,nama,jabatan) VALUES (@nip,@nama,@jabatan)";
                            //buat koneksi / penghubung
                            string koneksiString = "Provider=Microsoft.Ace.OleDB.12.0;Data Source=hmm.accdb;";
                            OleDbConnection koneksi = new OleDbConnection(koneksiString);
                            koneksi.Open();
                            //buat perintah dan eksesuksi query
                            OleDbCommand cmd = new OleDbCommand(query, koneksi);
                            cmd.Parameters.AddWithValue("nip", nip);
                            cmd.Parameters.AddWithValue("nama", nama);
                            cmd.Parameters.AddWithValue("jabatan", jabatan);
                            cmd.ExecuteNonQuery();

                        }

                    }
                }



































            } while (tombol.Key != ConsoleKey.Enter);

            
         
























            





            Console.ReadKey();



        }//tutupe voidmain
    
    }
}
