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
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());  //Evita errores al serializar enums
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());           //Evita errores al serializar DateOnly
        }

        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            var lista = await _http.GetFromJsonAsync<List<T>>(ruta, _jsonOptions);
            return lista ?? new List<T>();
        }

        public async Task<T> GetByIdAsync<T>(string ruta, int id)
        {
            var objeto = await _http.GetFromJsonAsync<T>($"{ruta}/{id}", _jsonOptions);
            return objeto;
        }

        public async Task<T?> Create<T>(string ruta, string id)
        {
            var response = await _http.PostAsJsonAsync(ruta, _jsonOptions);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine(json);
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        public async Task<T> Update<T>(string ruta, int id, T objeto)
        {
            var response = await _http.PutAsJsonAsync<T>($"{ruta}/{id}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        public async Task Delete(string ruta, int id)
        {
            var response = await _http.DeleteAsync($"{ruta}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
