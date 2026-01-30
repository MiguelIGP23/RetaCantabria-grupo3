using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Repository
{
    public class ApiReta
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        public ApiReta(string http)
        {
            _http = new HttpClient { BaseAddress= new System.Uri(http)};
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());                     //Evita errores al serializar enums
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());                       //Evita errores al serializar DateOnly
            _jsonOptions = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};  //IgnoreCase para los nombres de propiedades al serializar
        }

        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            var lista = await _http.GetFromJsonAsync<List<T>>(ruta, _jsonOptions);
            return lista ?? new List<T>();
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
