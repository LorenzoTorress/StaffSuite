using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gestion_Empleados.Pages.Empleados
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Empleado Empleado { get; set; }
        private readonly ServicioEmpleados servicio;
        public EditModel()
        {
            IAccesoDatos<Empleado> acceso = new AccesoDatosJson<Empleado>("Empleados.json");
            IRepositorio<Empleado> repo = new RepositorioCrudJson<Empleado>(acceso);
            servicio = new ServicioEmpleados(repo);
        }
        public void OnGet(int id)
        {
            Empleado? empleado = servicio.BuscarPorId(id);
            if (empleado != null)
            {
                Empleado = empleado;
            }
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            servicio.Editar(Empleado);
            return RedirectToPage("Index");
        }
    }
}
