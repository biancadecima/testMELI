using Newtonsoft.Json;

namespace CountriesByRegion
{
    internal class Program
    {
        // No recuerdo exactamente si la firma de la función era así
        static async Task<List<string>> findCountries(string keyword, string region)
        {
            HttpClient client = new HttpClient();
            List<string> countriesList = new List<string>();
            try
            {
                int currentPage = 1; //Comienzo en la primera pagina para ir avanzandando hacia las demás
                do
                { 
                    string url = $"https://jsonmock.hackerrank.com/api/countries/search?region={region}&name={keyword}&page={currentPage}";
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var databaseResponse = JsonConvert.DeserializeObject<DatabaseResponse>(jsonResponse);

                        if (databaseResponse.data.Any())
                        { 
                            var filteredData = databaseResponse.data // Filtro y obtengo los datos de la respuesta
                                .Where(w => w.region == region && w.name.Contains(keyword))
                                .OrderBy(w => w.population)
                                .ThenBy(w => w.name);
                            
                            foreach (var record in filteredData)// Creo la lista de países con población y formato solicitado
                            {
                                string countryInfo = $"{record.name}, {record.population}";
                                countriesList.Add(countryInfo);
                            }

                            currentPage++;// Avanzo a la siguiente página si hay más datos
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        break;
                    }

                } while (true);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return countriesList;
        }

        // Clase para representar la estructura de la respuesta de la base de datos
        public class DatabaseResponse
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<WeatherRecord> data { get; set; }
        }

        // Clase para representar la estructura de los registros climaticos
        public class WeatherRecord
        {
            public string name { get; set; }
            public string region { get; set; }
            public int population { get; set; }
        }
    }
}