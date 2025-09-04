namespace denshae.Conexion;

class Modelo
{
    public class Equipos
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public List<Jugadores>? Jugadores { get; set; }

    }

    public class Jugadores
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Equipo { get; set; }
        public Equipos? Equipos { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public decimal Estatura { get; set; }

    }
}