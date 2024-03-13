using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_1302220108
{
    internal class BuahKode
    {
        public enum NameBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka};
        public enum NameKodeBuah { kA00, kB00, kC00, kD00, kE00, kF00, kH00, kI00, kJ00, kK00, kL00, kM00, kN00, kO00 }

        public void getKodeBuah()
        {
            Console.WriteLine("Buah\tKode Buah");
            for (int i = 0; i < 14; i++)
            {
                string buhPad = ((NameBuah)i).ToString().PadRight(18);
                Console.WriteLine(buhPad + "\t" + ((NameKodeBuah)i).ToString().Substring(1));
                Console.WriteLine();
            }
        }
    }
}
