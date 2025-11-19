using System.ComponentModel.DataAnnotations;
namespace Gestion_Empleados.Modelo
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Debe ingresar un apellido ")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar un email")]
        public EmailAddressAttribute EmailAddress { get; set; }
        [Required(ErrorMessage = "Debe ingresar una fecha de contratación")]
        public DateOnly FechaContratacion { get; set; }
        [Required(ErrorMessage ="Debe ingresar un salario")]
        public double Salario { get; set; }

    }
}
