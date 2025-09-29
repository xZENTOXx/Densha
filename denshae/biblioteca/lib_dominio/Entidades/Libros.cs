namespace lib_dominio.Entidades
{
    public class Libros
    {
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public string? Nombre { get; set; }
        public string? Autor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
