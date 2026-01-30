using Model;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Repository
{
    public class ApiReta
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions;

        public ApiReta(string http)
        {
            _http = new HttpClient { BaseAddress= new System.Uri(http)};
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());
            _jsonOptions.Converters.Add(new TimeSpanConverter());

        }



        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            var resp = await _http.GetAsync(ruta);
            resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<T>>(json, _jsonOptions) ?? new List<T>();
        }



        public async Task<T?> GetByIdAsync<T>(string ruta, string idPath)
        {
            return await _http.GetFromJsonAsync<T>($"{ruta}/{idPath}", _jsonOptions);
            
        }



        public async Task<T?> Create<T>(string ruta, T objeto)
        {
            var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }



        public async Task<T?> Update<T>(string ruta, string idPath, T objeto)
        {
            var response = await _http.PutAsJsonAsync<T>($"{ruta}/{idPath}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }



        public async Task Delete(string ruta, string idPath)
        {
            var response = await _http.DeleteAsync($"{ruta}/{idPath}");
            response.EnsureSuccessStatusCode();
        }
    }
}
