using System.ComponentModel.DataAnnotations;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        [PrimeraLetraMayuculaAtribute]
        [StringLength(maximumLength: 250)]
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string IdiomaOriginal { get; set; }
        public string FechaPublicacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
    }
}
