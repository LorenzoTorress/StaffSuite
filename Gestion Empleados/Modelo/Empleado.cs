using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Gestion_Empleados.Modelo
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="Debe ingresar un apellido ")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar un email")]
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Required(ErrorMessage = "Debe ingresar una fecha de contratación")]
        public DateTime FechaContratacion { get; set; }
        [Required(ErrorMessage ="Debe ingresar un salario")]
        public decimal? Salario { get; set; }

    }
}
