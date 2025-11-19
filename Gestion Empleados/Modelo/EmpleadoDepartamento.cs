using System.ComponentModel.DataAnnotations;

namespace Gestion_Empleados.Modelo
{
    public class EmpleadoDepartamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar un empleado")]
        public string EmpleadoNombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar un departamento")]
        public string DepartamentoNombre { get; set; }
    }
}
