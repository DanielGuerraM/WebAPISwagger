using System.ComponentModel.DataAnnotations;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [PrimeraLetraMayuculaAtribute]
        public string Nombres { get; set; }
        [PrimeraLetraMayuculaAtribute]
        public string PrimerApellido { get; set; }
        [PrimeraLetraMayuculaAtribute]
        public string SegundoApellido { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
