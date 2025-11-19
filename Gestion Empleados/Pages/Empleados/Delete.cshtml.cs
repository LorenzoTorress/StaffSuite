using Gestion_Empleados.Modelo;
using Gestion_Empleados.Servicios;
using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gestion_Empleados.Pages.Empleados
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Empleado Empleado { get; set; }
        private readonly ServicioEmpleados servicio;

        public DeleteModel()
        {
            IAccesoDatos<Empleado> acceso = new AccesoDatosJson<Empleado>("Empleados.json");
            IRepositorio<Empleado> repo = new RepositorioCrudJson<Empleado>(acceso);
            servicio = new ServicioEmpleados(repo);
        }
        public IActionResult OnGet(int id)
        {
            var empleado = servicio.BuscarPorId(id);
            if (empleado == null)
            {
                return RedirectToPage("Index");
            }
            Empleado = empleado;
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            servicio.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}
