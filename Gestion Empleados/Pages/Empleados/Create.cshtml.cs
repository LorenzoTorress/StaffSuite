using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;

namespace Gestion_Empleados.Pages.Empleados
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Empleado Empleado { get; set; }

        private readonly ServicioEmpleados servicio;
        public CreateModel()
        {
            IAccesoDatos<Empleado> acceso = new AccesoDatosJson<Empleado>("Empleados.json");
            IRepositorio<Empleado> repo = new RepositorioCrudJson<Empleado>(acceso);
            servicio = new ServicioEmpleados(repo);
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Empleado);

            return RedirectToPage("Index");
        }
    }
}
