namespace WebAPIAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string IdiomaOriginal { get; set; }
        public string FechaPublicacion { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
