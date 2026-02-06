using Dto;
using Model;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Repository
{
    public class ApiReta
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions;

        public ApiReta(string http)
        {
            _http = new HttpClient { BaseAddress = new System.Uri(http) };
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
            string path = ruta;
            if (Session.Rol == null) path+="/validadas";

            try
            {
                var resp = await _http.GetAsync(path);
                resp.EnsureSuccessStatusCode();
                var json = await resp.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<T>>(json, _jsonOptions) ?? new List<T>();
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return new List<T>();
            }

        }



        public async Task<T?> GetByIdAsync<T>(string ruta, string idPath)
        {
            ApplyAuthHeader();
            try
            {
                var response = await _http.GetAsync($"{ruta}/{idPath}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return default;
            }
        }



        public async Task<T?> Create<T>(string ruta, T objeto)
        {
            ApplyAuthHeader();

            try
            {
                var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return default;
            }
        }



        public async Task<T?> Update<T>(string ruta, string idPath, T objeto)
        {
            ApplyAuthHeader();
            try
            {
                var response = await _http.PutAsJsonAsync($"{ruta}/{idPath}", objeto, _jsonOptions);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return default;
            }
        }



        public async Task Delete(string ruta, string idPath)
        {
            ApplyAuthHeader();
            try
            {
                var response = await _http.DeleteAsync($"{ruta}/{idPath}");
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
            }
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
            try
            {
                var response = await _http.GetAsync($"api/reta3/rutas/{idRuta}/fichas/organizacion");
                response.EnsureSuccessStatusCode();

                var bytes = await response.Content.ReadAsByteArrayAsync();
                File.WriteAllBytes(rutaDestino, bytes);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
            }
        }

        public async Task DescargarFichaUsuarioAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();
            try
            {
                var response = await _http.GetAsync($"api/reta3/rutas/{idRuta}/fichas/usuario");
                response.EnsureSuccessStatusCode();

                var bytes = await response.Content.ReadAsByteArrayAsync();
                File.WriteAllBytes(rutaDestino, bytes);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
            }
        }

        public async Task DescargarFichaSeguridadAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();
            try
            {
                var response = await _http.GetAsync($"api/reta3/rutas/{idRuta}/fichas/seguridad");
                response.EnsureSuccessStatusCode();

                var bytes = await response.Content.ReadAsByteArrayAsync();
                File.WriteAllBytes(rutaDestino, bytes);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
            }
        }


        // Muestra mensaje de aviso en peticiones sin autorización
        public void MostrarErrorHttp(HttpRequestException ex)
        {

            int codigo = (int?) ex.StatusCode ?? -1;
            string titulo = ex.StatusCode?.ToString() ?? "ERROR";
            string mensaje = $"ERROR_CODE {codigo}: ";
            var icono = MessageBoxIcon.Warning;


            if (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                mensaje += "Se requieren credenciales de acceso (token inválido, expirado o inexistente).";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                mensaje += "No tienes permiso para realizar esta acción.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                mensaje += "Petición mal formada.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                mensaje += "Recurso inexistente.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                mensaje += "Error interno en el servidor.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.BadGateway)
            {
                mensaje += "Error en la conexión al servidor.";
            }
            else
            {
                mensaje += $"{ex.Message}";
                icono = MessageBoxIcon.Error;
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
    }
}
