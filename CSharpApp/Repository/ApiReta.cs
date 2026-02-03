using Dto;
using Model;
using System.Net.Http.Headers;
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


        // ---------------------------
        // Aplica header con token de autorizacion
        // ---------------------------
        private void ApplyAuthHeader()
        {
            if (!string.IsNullOrWhiteSpace(Session.Token))
                _http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", Session.Token);
            else
                _http.DefaultRequestHeaders.Authorization = null;
        }



        // ---------------------------
        // Operaciones CRUD genericas
        // ---------------------------

        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            ApplyAuthHeader();
            var resp = await _http.GetAsync(ruta);
            resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<T>>(json, _jsonOptions) ?? new List<T>();
        }



        public async Task<T?> GetByIdAsync<T>(string ruta, string idPath)
        {
            ApplyAuthHeader();
            return await _http.GetFromJsonAsync<T>($"{ruta}/{idPath}", _jsonOptions);
        }



        public async Task<T?> Create<T>(string ruta, T objeto)
        {
            ApplyAuthHeader();
            var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }



        public async Task<T?> Update<T>(string ruta, string idPath, T objeto)
        {
            ApplyAuthHeader();
            var response = await _http.PutAsJsonAsync<T>($"{ruta}/{idPath}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }



        public async Task Delete(string ruta, string idPath)
        {
            ApplyAuthHeader();
            var response = await _http.DeleteAsync($"{ruta}/{idPath}");
            response.EnsureSuccessStatusCode();
        }


        // Usado para la peticion de login
        public async Task<LoginResponse?> LoginAsync(LoginRequest req)
        {
            var response = await _http.PostAsJsonAsync("/api/reta3/auth/login", req, _jsonOptions);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<LoginResponse>(_jsonOptions);
        }


        // Metodos para descarga de ficheros
        public async Task DescargarFichaOrganizacionAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();
            var response = await _http.GetAsync($"api/reta3/rutas/{idRuta}/fichas/organizacion");
            
            response.EnsureSuccessStatusCode();

            var bytes = await response.Content.ReadAsByteArrayAsync();

            File.WriteAllBytes(rutaDestino, bytes);
        }

        public async Task DescargarFichaUsuarioAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();
            var response = await _http.GetAsync($"api/reta3/rutas/{idRuta}/fichas/usuario");

            response.EnsureSuccessStatusCode();

            var bytes = await response.Content.ReadAsByteArrayAsync();

            File.WriteAllBytes(rutaDestino, bytes);
        }

        public async Task DescargarFichaSeguridadAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();
            var response = await _http.GetAsync($"api/reta3/rutas/{idRuta}/fichas/seguridad");

            response.EnsureSuccessStatusCode();

            var bytes = await response.Content.ReadAsByteArrayAsync();

            File.WriteAllBytes(rutaDestino, bytes);
        }

    }
}
