
using System.Text.Json.Serialization;


namespace Model
{
    public class Usuario
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("apellido")]
        public string Apellido { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("rol")]
        public EnumRoles Rol { get; set; }


        public Usuario()
        {
        }

        public Usuario(string nombre, string apellido, string email, string password, EnumRoles rol)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            Rol = rol;
        }


    }
}
