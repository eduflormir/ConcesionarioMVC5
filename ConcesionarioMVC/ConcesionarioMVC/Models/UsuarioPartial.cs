namespace ConcesionarioMVC.Models
{
    public partial class Usuario
    {
        public string login { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string apellidos { get; set; }
        public int idRol { get; set; }
        public string email { get; set; }

    }
}