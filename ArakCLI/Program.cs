




namespace ArakCLI
{
    public class Program
    {
        public static List<Arak> arakCollection = new List<Arak>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat2();
            Feladat3();
            Feladat5();
            Feladat6();
        }

        private static void Feladat6()
        {
            var csokkentettArak = arakCollection.Where(a => a.Valtozas() < 0);
            StreamWriter streamWriter = new StreamWriter("Olcsobbak.txt");
            foreach (var item in csokkentettArak)
            {
                streamWriter.WriteLine($"{item.Kod};{item.Megnevezes};{Math.Abs(item.Valtozas())}");
            }
            streamWriter.Close();
        }

        private static void Feladat5()
        {
            var legnagyobbEmelkedettAr = arakCollection.MaxBy(a => a.Valtozas());
            Console.WriteLine($"A legnagyobb mértékben a {legnagyobbEmelkedettAr.Megnevezes} emelkedett, {legnagyobbEmelkedettAr.Valtozas()} Ft-tal.");
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. feladat:");
            Console.Write("Kérem adja meg a termék kódját! ");
            string kod = Console.ReadLine();
            var arAtlaga = arakCollection.FirstOrDefault(a => a.Kod == kod);
            if (arAtlaga != null)
            {
                Console.WriteLine($"Termék neve: {arAtlaga.Megnevezes}, átlagára 2024-ben: {(arAtlaga.December + arAtlaga.Januar) / 2:F1} Ft");
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék a listában :(");
            }
        }

        private static void Feladat2()
        {
            Console.WriteLine("1. feladat:");
            Console.WriteLine($"Az állományban {arakCollection.Count} db termék található.");
        }

        private static void Beolvasas()
        {
            StreamReader streamReader = new StreamReader("Arak2024.txt");
            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                Arak arak = new Arak(streamReader.ReadLine());
                arakCollection.Add(arak);
            }
            streamReader.Close();
        }
    }
}
