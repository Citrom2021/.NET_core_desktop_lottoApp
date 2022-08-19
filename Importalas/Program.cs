using LottoAdatbazis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VikingAdatbazis;

namespace Importalas
{
    class Program
    {
        static void Main(string[] args)
        {
            VikingContext db = new VikingContext();
            if (!db.LottoSzamok.Any())
            {
                string[] sorok = null;
                bool sikeresFileNyitas = true;
                try
                {
                    sorok = File.ReadAllLines(args[0]);
                }
                catch (Exception)
                {
                    sikeresFileNyitas = false;
                    Console.WriteLine("A megadott file nem megfelelő");
                }

                if (sikeresFileNyitas)
                {
                    List<LottoSzam> szamok = new List<LottoSzam>();

                    foreach (var item in sorok)
                    {
                        try
                        {
                            szamok.Add(new LottoSzam(item));
                        }
                        catch (Exception)
                        { }
                    }
                    db.LottoSzamok.AddRange(szamok);
                    db.SaveChanges();
                    Console.WriteLine("Sorok száma:" + db.LottoSzamok.Count());
                }
            }
        }
    }
}
