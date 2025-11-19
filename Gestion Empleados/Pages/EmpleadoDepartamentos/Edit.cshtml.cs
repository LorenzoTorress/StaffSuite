using Gestion_Empleados.AccesoDatos;
using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
using Gestion_Empleados.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gestion_Empleados.Pages.EmpleadoDepartamentos
{
    public class EditModel : PageModel
    {
        public List<SelectListItem> ListaEmpleados { get; set; }
        public List<SelectListItem> ListaDepartamentos { get; set; }

        [BindProperty]
        public EmpleadoDepartamento EmpleadoDepartamento { get; set; }
        private readonly ServicioEmpleadoDepartamento servicio;
        private readonly ServicioEmpleados servicioEmpleados;
        private readonly ServicioDepartamento servicioDepartamentos;

        public EditModel()
        {
            IAccesoDatos<EmpleadoDepartamento> acceso = new AccesoDatosJson<EmpleadoDepartamento>("EmpleadoDepartamento.json");
            IRepositorio<EmpleadoDepartamento> repo = new RepositorioCrudJson<EmpleadoDepartamento>(acceso);
            IAccesoDatos<Empleado> accesoEmpleados = new AccesoDatosJson<Empleado>("Empleados.json");
            IRepositorio<Empleado> repoEmpleados = new RepositorioCrudJson<Empleado>(accesoEmpleados);
            IAccesoDatos<Departamento> accesoDepartamentos = new AccesoDatosJson<Departamento>("Departamento.json");
            IRepositorio<Departamento> repoDepartamentos = new RepositorioCrudJson<Departamento>(accesoDepartamentos);
            servicio = new ServicioEmpleadoDepartamento(repo);
            servicioEmpleados = new ServicioEmpleados(repoEmpleados);
            servicioDepartamentos = new ServicioDepartamento(repoDepartamentos);
        }
        public void ListarEmpleados()
        {
            ListaEmpleados = servicioEmpleados.ObtenerTodos().Select(e => new SelectListItem
            {
                Text = e.Nombre + " " + e.Apellido,
                Value = e.Nombre + " " + e.Apellido
            }).ToList();
        }
        public void ListarDepartamentos()
        {
            ListaDepartamentos = servicioDepartamentos.ObtenerTodos().Select(d => new SelectListItem
            {
                Text = d.Nombre,
                Value = d.Nombre
            }).ToList();
        }
        public void OnGet(int id)
        {
            EmpleadoDepartamento? encargado = servicio.BuscarPorId(id);
            if (encargado != null)
            {
                EmpleadoDepartamento = encargado;
            }
            ListarEmpleados();
            ListarDepartamentos();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            servicio.Editar(EmpleadoDepartamento);
            return RedirectToPage("Index");
        }
    }
}
