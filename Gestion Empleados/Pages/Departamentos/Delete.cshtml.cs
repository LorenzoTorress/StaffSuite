using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gestion_Empleados.Pages.Departamentos
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Departamento Departamento { get; set; }
        private readonly ServicioDepartamento servicio;

        public DeleteModel()
        {
            IAccesoDatos<Departamento> acceso = new AccesoDatosJson<Departamento>("Departamento.json");
            IRepositorio<Departamento> repo = new RepositorioCrudJson<Departamento>(acceso);
            servicio = new ServicioDepartamento(repo);
        }
        public IActionResult OnGet(int id)
        {
            var departamento= servicio.BuscarPorId(id);
            if (departamento == null)
            {
                return RedirectToPage("Index");
            }
            Departamento = departamento;
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            servicio.EliminarPorId(id);
            return RedirectToPage("Index");
        }
    }
}
