using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;

namespace Gestion_Empleados.Servicios
{
    public class ServicioEmpleadoDepartamento
    {
        private readonly IRepositorio<EmpleadoDepartamento> _repo;
        public ServicioEmpleadoDepartamento(IRepositorio<EmpleadoDepartamento> repo)
        {
            _repo = repo;
        }
        public List<EmpleadoDepartamento> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }
        public EmpleadoDepartamento? BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }
        public void Agregar(EmpleadoDepartamento empleadodepartamento)
        {
            _repo.Agregar(empleadodepartamento);
        }
        public void Editar(EmpleadoDepartamento empleadodepartamento)
        {
            _repo.Editar(empleadodepartamento);
        }
        public void EliminarPorId(int id)
        {
            _repo.EliminarPorId(id);
        }

    }
}
