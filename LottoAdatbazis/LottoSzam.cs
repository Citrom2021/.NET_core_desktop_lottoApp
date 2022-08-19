using System;
using System.Collections.Generic;
using System.Linq;

namespace LottoAdatbazis
{
    public class LottoSzam
    {
        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }
        public int Szam6 { get; set; }

        public LottoSzam()
        {
        }

        public LottoSzam(string sor)
        {
            string[] tombSzoveg = sor.Trim().Split(";");
            if (tombSzoveg.Length == 6)
            {
                int[] tombSzam = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        tombSzam[i] = Convert.ToInt32(tombSzoveg[i].Trim());
                    }
                    catch (Exception)
                    {

                        throw new Exception();
                    }
                    if ((tombSzam[i] < 1) || (tombSzam[i] > 48)) throw new Exception();
                }

                HashSet<int> halmaz = new HashSet<int>(tombSzam);
                if (halmaz.Count() != 6) throw new Exception();

                Szam1 = tombSzam[0];
                Szam2 = tombSzam[1];
                Szam3 = tombSzam[2];
                Szam4 = tombSzam[3];
                Szam5 = tombSzam[4];
                Szam6 = tombSzam[5];
            }
            else
            {
                throw new ArgumentException("üzenet", "sor");
            }

        }
    }
}
