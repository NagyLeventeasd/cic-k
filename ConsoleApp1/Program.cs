using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Szine { Zold, Barna, szüreke, lila}

    enum Neme {fiú, lány }

    class Cica
    {
        public int ID { get; set; }
        public string Neve { get; set; }

        public Szine Szine { get; set; }
        
        public DateTime Szuetes { get; set; }
        
        public Neme Neme { get; set; }

        public int Suly { get; set; }

        public int Kor => DateTime.Now.Year - Szuetes.Year;

        public override string ToString()
        {
            return $"{ID, -5}{Neve,-20}{Szine,-10}{Szuetes.ToString("yyy.MM.dd"),-15} {Neme,-10}{Suly,-5}{Kor}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Cica> cicak = new List<Cica>()
            {
                new Cica()
                {
                    ID = 1,
                    Neme = Neme.fiú,
                    Neve = "megatron",
                    Suly = 10,
                    Szine = Szine.Barna,
                    Szuetes = new DateTime(2022, 12, 20),

                },
                new Cica()
                {
                    ID = 2,
                    Neme = Neme.fiú,
                    Neve = "Valaki bajban van",
                    Suly = 10,
                    Szine = Szine.Barna,
                    Szuetes = new DateTime(2022, 12, 20),

                },
                new Cica()
                {
                    ID = 3,
                    Neme = Neme.lány,
                    Neve = "ptimus",
                    Suly = 10,
                    Szine = Szine.Barna,
                    Szuetes = new DateTime(2022, 12, 20),

                },
                new Cica()
                {
                    ID = 4,
                    Neme = Neme.fiú,
                    Neve = "maradj",
                    Suly = 10,
                    Szine = Szine.Barna,
                    Szuetes = new DateTime(2022, 12, 20),

                },
            };

            Cica elsoCica = cicak.First();
            Console.WriteLine(elsoCica);
            Cica utolsoCica = cicak.Last();
            Console.WriteLine(utolsoCica);
            int osszSuly = cicak.Sum(x => x.Suly);
            Console.WriteLine($"Össz súly: {osszSuly} kg");
            double atlagKor = cicak.Average(x => x.Kor);
            Console.WriteLine($"Átlag életkor: {atlagKor:0.00}");
            int lamyDB = cicak.Count(x => x.Neme == Neme.lány);
            Console.WriteLine($"Lány cicák: {lamyDB}");
            int legveknyabb = cicak.Min(x => x.Suly);
            Console.WriteLine(legveknyabb);
            cicak.Where(x => x.Kor > 3).ToList().ForEach(x => Console.WriteLine(x.Neve));
            cicak.Where(x => x.Szine == Szine.Barna).ToList().ForEach(x => Console.WriteLine(x.Neve));
            Console.ReadKey();

        }        
    }
}
