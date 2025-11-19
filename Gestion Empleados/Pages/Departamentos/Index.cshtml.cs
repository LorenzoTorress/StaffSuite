using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gestion_Empleados.Pages.Departamentos
{
    public class IndexModel : PageModel
    {
        public List<Departamento> Departamentos { get; set; }

        private readonly ServicioDepartamento servicio;

        public IndexModel()
        {
            IAccesoDatos<Departamento> acceso = new AccesoDatosJson<Departamento>("Departamento.json");
            IRepositorio<Departamento> repo = new RepositorioCrudJson<Departamento>(acceso);
            servicio = new ServicioDepartamento(repo);
        }
        public void OnGet()
        {
            Departamentos = servicio.ObtenerTodos();
        }
    }
}
