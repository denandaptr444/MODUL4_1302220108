using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_1302220108
{
    internal class KodeBuah
    {
        public String Buah;
        public int kodebuah;
        public List<KodeBuah> listKodebuah = new List<KodeBuah>();
        public KodeBuah(string a = "", int k = 0)
        {
            this.Buah = a;
            this.kodebuah = k;
        }
        public void setKodeBuah()
        {
            this.listKodebuah.Add(new KodeBuah("Apel", A00));
            this.listKodebuah.Add(new KodeBuah("Aprikot", B00));
            this.listKodebuah.Add(new KodeBuah("Alpukat", C00));
            this.listKodebuah.Add(new KodeBuah("Pisang", D00));
            this.listKodebuah.Add(new KodeBuah("Paprika", E00));
            this.listKodebuah.Add(new KodeBuah("Blackberry", F00));
            this.listKodebuah.Add(new KodeBuah("Ceri", H00));
            this.listKodebuah.Add(new KodeBuah("Kelapa", I00));
            this.listKodebuah.Add(new KodeBuah("Jagung", J00));
            this.listKodebuah.Add(new KodeBuah("Kurma", K00));
            this.listKodebuah.Add(new KodeBuah("Durian", L00));
            this.listKodebuah.Add(new KodeBuah("Anggur", M00));
            this.listKodebuah.Add(new KodeBuah("Melon", N00));
            this.listKodebuah.Add(new KodeBuah("Semangka", O00));

        }

        public void getKodeBuah()
        {
            Console.WriteLine("Buah\tKode Buah");
            foreach (KodeBuah k in this.listKodebuah)
            {
                string buhPad = k.Buah.PadRight(15);
                Console.Write(buhPad + "\t" + k.kodebuah);
                Console.WriteLine();
            }
        }
    }
}
