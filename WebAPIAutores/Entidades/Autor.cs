using System.ComponentModel.DataAnnotations;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(maximumLength:100)]
        [PrimeraLetraMayuculaAtribute]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [PrimeraLetraMayuculaAtribute]
        public string PrimerApellido { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [PrimeraLetraMayuculaAtribute]
        public string SegundoApellido { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; } 
    }
}
