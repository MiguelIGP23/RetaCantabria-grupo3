using Dto;
using Model;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.Intrinsics.X86;
using System.Text;
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


        // Aplica header con token de autorizacion
        private void ApplyAuthHeader()
        {
            if (!string.IsNullOrWhiteSpace(Session.Token))
                _http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", Session.Token);
            else
                _http.DefaultRequestHeaders.Authorization = null;
        }



        // Operaciones CRUD genericas
        public async Task<List<T>> GetAlAsync<T>(string ruta)
        {
            ApplyAuthHeader();
            string path = ruta;

            var resp = await _http.GetAsync(path);
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<T>>(json, _jsonOptions) ?? new List<T>();
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
                ApiReta.MostrarErrorHttp(ex);
                return default;
            }
        }



        public async Task<T?> Create<T>(string ruta, T objeto)
        {
            ApplyAuthHeader();

            var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);

        }



        public async Task<T?> Update<T>(string ruta, string id, T objeto)
        {
            ApplyAuthHeader();

            var response = await _http.PutAsJsonAsync($"{ruta}/{id}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }


        //Update sin id para validar rutas
        public async Task<T?> Validar<T>(string ruta, T objeto)
        {
            ApplyAuthHeader();

            var response = await _http.PutAsJsonAsync($"{ruta}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }


        public async Task<Boolean> Delete(string ruta, string id)
        {
            ApplyAuthHeader();

            var response = await _http.DeleteAsync($"{ruta}/{id}");
            response.EnsureSuccessStatusCode();
            return true;
        }


        // Peticion de login
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

            var resp = await _http.GetAsync($"/api/reta3/rutas/{idRuta}/fichas/organizacion");
            resp.EnsureSuccessStatusCode();

            byte[] bytes = await resp.Content.ReadAsByteArrayAsync();           

            var cd = resp.Content.Headers.ContentDisposition;                  
            string filename = cd.FileName;                                     

            filename = filename?.Trim('"');                                  

            if (string.IsNullOrWhiteSpace(filename)) filename = "ficha-organizacion.txt";      
            string rutaCompleta = Path.Combine(rutaDestino, filename);          
            await File.WriteAllBytesAsync(rutaCompleta, bytes);                
        }

        public async Task DescargarFichaUsuarioAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();

            var resp = await _http.GetAsync($"/api/reta3/rutas/{idRuta}/fichas/usuario");
            resp.EnsureSuccessStatusCode();

            byte[] bytes = await resp.Content.ReadAsByteArrayAsync();          
            var cd = resp.Content.Headers.ContentDisposition;                 
            string filename = cd.FileName;                                     

            filename = filename?.Trim('"');                                    

            if (string.IsNullOrWhiteSpace(filename)) filename = "ficha-usuario.txt";    

            string rutaCompleta = Path.Combine(rutaDestino, filename);        
            await File.WriteAllBytesAsync(rutaCompleta, bytes);                  
        }

        public async Task DescargarFichaSeguridadAsync(int idRuta, string rutaDestino)
        {
            ApplyAuthHeader();

            var resp = await _http.GetAsync($"/api/reta3/rutas/{idRuta}/fichas/seguridad");
            resp.EnsureSuccessStatusCode();

            byte[] bytes = await resp.Content.ReadAsByteArrayAsync();         

            var cd = resp.Content.Headers.ContentDisposition;                  
            string filename = cd.FileName;                                      

            filename = filename?.Trim('"');                                     

            if (string.IsNullOrWhiteSpace(filename)) filename = "ficha-seguridad.txt";      

            string rutaCompleta = Path.Combine(rutaDestino, filename);        
            await File.WriteAllBytesAsync(rutaCompleta, bytes);                
        }



        // Crea la ruta desde el gpx
        public async Task<Ruta> CrearRutaConGpx(string endpoint, Ruta rutaBorrador, string filePath)
        {
            ApplyAuthHeader();

            try
            {
                using var form = new MultipartFormDataContent();

                // 1) Parte JSON "ruta"
                var json = JsonSerializer.Serialize(rutaBorrador, _jsonOptions);
                var rutaJson = new StringContent(json, Encoding.UTF8, "application/json");
                form.Add(rutaJson, "dto");

                // 2) Parte fichero "file"
                var fileBytes = await File.ReadAllBytesAsync(filePath);
                var gpx = new ByteArrayContent(fileBytes);
                gpx.Headers.ContentType = new MediaTypeHeaderValue("application/gpx+xml");
                form.Add(gpx, "file", Path.GetFileName(filePath));

                // 3) POST
                var resp = await _http.PostAsync(endpoint, form);

                if (!resp.IsSuccessStatusCode)
                {
                    var body = await resp.Content.ReadAsStringAsync();
                    throw new HttpRequestException(
                        $"HTTP {(int)resp.StatusCode} {resp.ReasonPhrase}\n{body}",
                        null,
                        resp.StatusCode
                    );
                }

                var respJson = await resp.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Ruta>(respJson, _jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creando ruta con GPX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        // Metodos para confirmar o eliminar el borrador cuando se crea una ruta
        public async Task<bool> ConfirmarBorrador(string baseRuta, int idRuta, Ruta ruta)
        {
            ApplyAuthHeader();
            var json = JsonSerializer.Serialize(ruta, _jsonOptions);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");
            var resp = await _http.PutAsync($"{baseRuta}/{idRuta}/confirmar", content);
            try
            {
                resp.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return false;
            }
        }


        public async Task<bool> CancelarBorrador(string baseRuta, int idRuta)
        {
            ApplyAuthHeader();
            var resp = await _http.DeleteAsync($"{baseRuta}/{idRuta}/borrador");
            try
            {
                resp.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                MostrarErrorHttp(ex);
                return false;
            }
        }



        // Muestra mensaje de aviso en peticiones sin autorización
        public static void MostrarErrorHttp(HttpRequestException ex)
        {

            int codigo = (int?)ex.StatusCode ?? -1;
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
