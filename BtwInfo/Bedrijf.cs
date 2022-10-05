using Newtonsoft.Json;

internal class Bedrijf
{
    [JsonProperty("valid")]
    public bool Valid { get; set; }

    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }

    [JsonProperty("vatNumber")]
    public string VatNumber { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("address")]
    public Address Address { get; set; }

    [JsonProperty("strAddress")]
    public string StrAddress { get; set; }

    public static async Task<Bedrijf> CheckBtwNummer(string? btwNummer)
    {
        if (btwNummer.Length < 12)
        {
            throw new Exception("Btw nummer moet 12 karakters lang zijn");
        }

        string apiUrl = $"https://controleerbtwnummer.eu/api/validate/{btwNummer}.json";

        using (HttpClient client = new HttpClient())
        {
            string responseString = await client.GetStringAsync(apiUrl);
            Bedrijf bedrijf = JsonConvert.DeserializeObject<Bedrijf>(responseString);
            return bedrijf;
        }
    }
}