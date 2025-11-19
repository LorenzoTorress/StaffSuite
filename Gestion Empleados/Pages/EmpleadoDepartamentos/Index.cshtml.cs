using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using Gestion_Empleados.Servicios;

namespace Gestion_Empleados.Pages.EmpleadoDepartamentos
{
    public class IndexModel : PageModel
    {
        public List<EmpleadoDepartamento> Encargado { get; set; }

        private readonly ServicioEmpleadoDepartamento servicio;


        public IndexModel()
        {
            IAccesoDatos<EmpleadoDepartamento> acceso = new AccesoDatosJson<Modelo.EmpleadoDepartamento>("EmpleadoDepartamento.json");
            IRepositorio<EmpleadoDepartamento> repo = new RepositorioCrudJson<Modelo.EmpleadoDepartamento>(acceso);

            servicio = new ServicioEmpleadoDepartamento(repo);

        }
        public void OnGet()
        {
            Encargado = servicio.ObtenerTodos();
        }
    }
}
