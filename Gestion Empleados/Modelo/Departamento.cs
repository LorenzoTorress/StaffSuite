using System.ComponentModel.DataAnnotations;

namespace Gestion_Empleados.Modelo
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingresa el nombre del departamento")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese de que se encarga el departamento")]
        public string Descripcion { get; set; }

    }
}
