using System.Net.Http;
using System.Security.Cryptography;


internal static class Programm
{
    private static async Task Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.Write("Btw nummer: ");
            string? btwNummer = Console.ReadLine();
            Bedrijf bedrijf;
            try
            {
                bedrijf = await Bedrijf.CheckBtwNummer(btwNummer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                continue;
            }

            if (!bedrijf.Valid)
            {
                Console.WriteLine("Btwnummer bestaat niet");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine($"Naam: " + bedrijf.Name);
            Console.WriteLine($"BtwNummer: " + bedrijf.VatNumber);
            Console.WriteLine($"CountryCode: " + bedrijf.CountryCode);

            Console.WriteLine("\nAdres:");
            Console.WriteLine($"City: " + bedrijf.Address.City);
            Console.WriteLine($"Country: " + bedrijf.Address.Country);
            Console.WriteLine($"Number: " + bedrijf.Address.Number);
            Console.WriteLine($"Street: " + bedrijf.Address.Street);
            Console.WriteLine($"ZipCode: " + bedrijf.Address.ZipCode);

            Console.ReadKey(false);
        } while (true);
    }
}