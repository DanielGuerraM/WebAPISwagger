namespace WebAPIAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
