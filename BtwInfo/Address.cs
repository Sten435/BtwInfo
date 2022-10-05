using Newtonsoft.Json;

internal class Address
{
    [JsonProperty("street")]
    public string Street { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }

    [JsonProperty("zip_code")]
    public string ZipCode { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }
}