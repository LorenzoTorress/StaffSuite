using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gestion_Empleados.Pages.Departamentos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Departamento Departamento { get; set; }

        private readonly ServicioDepartamento servicio;
        public CreateModel()
        {
            IAccesoDatos<Departamento> acceso = new AccesoDatosJson<Departamento>("Departamento.json");
            IRepositorio<Departamento> repo = new RepositorioCrudJson<Departamento>(acceso);
            servicio = new ServicioDepartamento(repo);
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

            servicio.Agregar(Departamento);

            return RedirectToPage("Index");
        }
    }
}
