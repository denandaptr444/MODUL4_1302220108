using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_1302220108
{
    internal class PosisiKarakterGame
    {
        public enum NameKeys { Jongkok, Berdiri, Tengkurap, Terbang};
        public enum NameKunci { TombolW, TombolS};

        public void run()
        {
            NameKeys defaults = NameKeys.Tengkurap;
            String Command = "Jongkok";
            while (defaults != NameKeys.Terbang)
            {
                switch (defaults)
                {
                    case NameKeys.Jongkok:
                        Console.WriteLine("Jongkok");
                        break;
                    case NameKeys.Tengkurap:
                        Console.WriteLine("Tengkurap");
                        break;
                    case NameKeys.Terbang:
                        Console.WriteLine("Terbang");
                        break;
                }
                Console.WriteLine("Masukan Perintah : ");
                Command = Console.ReadLine();

                if (Command == "Buka Pintu" ||  Command == "buka")

            }
        }
    }
}
