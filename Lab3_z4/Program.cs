using System;

namespace Lab3_z4
{
    class Program
    {
        static int ispredRijeciEtf(List<string> lista)
        {
            int suma = 0;
            lista.ForEach(s => suma += string.Compare(s, "etf") == -1 ? 1 : 0);
            return suma;
        }

        static int isteRijeciEtf(List<string> lista)
        {
            int suma = 0;
            lista.ForEach(s => suma += s == "etf" ? 1 : 0);
            return suma;
        }

        static int medjusobnoJednakeRijeci(List<string> lista)
        {
            List<string> revidirani = new List<string>();
            lista.ForEach(s1 =>
            {
                if(lista.Where(s2 => s1 == s2).ToList().Count > 1 && revidirani.Any(s3 => s1 == s3) == false)
                    revidirani.Add(s1);
            });

            return revidirani.Count;
        }

        static void Main(string[] args)
        {
            List<string> lista = new List<string>()
            {
                "aki",
                "beba",
                "margarita",
                "etf",
                "etf",
                "etf",
                "jaje",
                "stampedo",
                "beč",
                "aki"
            };

            Console.WriteLine("Lista rijeci: ");
            foreach (var rijec in lista)
                Console.Write("{0} ", rijec);

            Console.WriteLine("\n\nBroj stringova koji su abecedno ispred riječi 'etf': {0}",
                ispredRijeciEtf(lista));
            Console.WriteLine("Broj stringova koji su isti kao rijec 'etf': {0}",
                isteRijeciEtf(lista));
            Console.WriteLine("Broj stringova koji su međusobno jednaki: {0}",
                medjusobnoJednakeRijeci(lista));
        }
    }
}