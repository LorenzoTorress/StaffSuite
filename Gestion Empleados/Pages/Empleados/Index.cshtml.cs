using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;

namespace Gestion_Empleados.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        public List<Empleado> Empleados { get; set; }

        private readonly ServicioEmpleados servicio;

        public IndexModel()
        {
            IAccesoDatos<Empleado> acceso = new AccesoDatosJson<Empleado>("Empleados.json");
            IRepositorio<Empleado> repo = new RepositorioCrudJson<Empleado>(acceso);
            servicio = new ServicioEmpleados(repo);
        }
        public void OnGet()
        {
            Empleados = servicio.ObtenerTodos();
        }
    }
}
