using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Libros? Libros()
        {
            var entidad = new Libros();
            entidad.ISBN = "ISBN-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Autor = "Autor-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Fecha = DateTime.Now;

            return entidad;
        }
    }
}
