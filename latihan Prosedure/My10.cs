using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_Prosedure
{
    class My10
    {
        static public void BuatKotak(int kiri,int atas,int kanan,int bawah )
        {
            Console.SetCursorPosition(kiri, atas);
            Console.Write("╔" );

            for (int i = kiri + 1; i <= kanan - 1; i++)
            {
               Console.SetCursorPosition(i, atas);
                Console.Write("═");
            }
              Console.SetCursorPosition(kanan,atas);
            Console.Write("╗");

            for(int i = atas + 1; i <= bawah -1; i++)
            {
                Console.SetCursorPosition(kanan,i);
                Console.Write("║");
            }

            Console.SetCursorPosition(kanan,bawah);
            Console.Write("╝");
   
                //tengah bawah
            for (int i =kanan -1; i >= kiri + 1; i--)
            {
                Console.SetCursorPosition(i, bawah);
                Console.Write("═");
            }

            //pojok kiri bawah
            Console.SetCursorPosition(kiri,bawah);
            Console.Write("╚");

            //tengah kiri
            for (int i = bawah -1; i >= atas + 1; i--)
            {
                Console.SetCursorPosition(kiri, i);
                Console.Write("║");
            }

            }
            
            

             static public void Tulis(int kiri,int atas ,string teks)
         {
            Console.SetCursorPosition(kiri,atas);
            Console.Write(teks);
         }
     
            static public void TulisWarna(int kiri,int atas,string teks,ConsoleColor warnaTeks,
                ConsoleColor warnaBackground)
            {
                Console.SetCursorPosition(kiri,atas);
                Console.ForegroundColor = warnaTeks;
                Console.BackgroundColor = warnaBackground;
                Console.Write(teks);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
             
        static public string Input(int kiri,int atas)
        {
            string hasil;
            do
            {
                Console.SetCursorPosition(kiri,atas);
                hasil = Console.ReadLine();
            }while (hasil == "");
            return hasil;
        }

                
               

    
             
    }
}
