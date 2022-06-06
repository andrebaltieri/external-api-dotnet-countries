using RestCountries;
using RestSharp;

const string url = "https://restcountries.com/v3.1/name/brazil";
var client = new RestClient(url);
var request = new RestRequest();
var response = await client.GetAsync<List<Root>>(request);

foreach (var item in response)
    Console.WriteLine(item.Name.Official);