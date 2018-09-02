using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_Prosedure
{
    class Mysiswa
    {
        static public int UangPendaftaran = 200000;

        private int TotalBayar = 0;

        public void TambahTotalBayar(int jumlahUang)
        {
            //totalbayar = totalbayar + jumlahuang;
            TotalBayar += jumlahUang;
        }

        public int GetTotalBayar()
        {
            return TotalBayar;
        }
                
    }
}
