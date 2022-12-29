using System.ComponentModel.DataAnnotations;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.DTOs
{
    public class LibroDTO
    {
        public int Id { get; set; }
        [PrimeraLetraMayuculaAtribute]
        [StringLength(maximumLength: 250)]
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string IdiomaOriginal { get; set; }
        public string FechaPublicacion { get; set; }
        public List<ComentarioDTO> comentarios { get; set; }
    }
}
