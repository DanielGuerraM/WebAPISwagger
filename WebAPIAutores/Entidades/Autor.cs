using System.ComponentModel.DataAnnotations;
using WebAPIAutores.Validaciones;

namespace WebAPIAutores.Entidades
{
    public class Autor: IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        //[PrimeraLetraMayuculaAtribute]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [PrimeraLetraMayuculaAtribute]
        public string PrimerApellido { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [PrimeraLetraMayuculaAtribute]
        public string SegundoApellido { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaNacimiento { get; set; }
        public List<Libro> Libros { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!string.IsNullOrEmpty(Nombres))
            {
                var primeraLetra = Nombres[0].ToString();

                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayuscula",
                        new string[] {nameof(Nombres) });
                }
            }

            if(Nacionalidad == null)
            {
                yield return new ValidationResult("El campo nacionalidad no puede ir vacio",
                    new string[] {nameof(Nacionalidad)} );
            }
        }
    }
}
