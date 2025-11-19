using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;

namespace Gestion_Empleados.Servicios
{
    public class ServicioEmpleados
    {
        private readonly IRepositorio<Empleado> _repo;
        public ServicioEmpleados(IRepositorio<Empleado> repo)
        {
            _repo = repo;
        }
        public List<Empleado> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }
        public Empleado? BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }
        public void Agregar(Empleado empleado)
        {
            _repo.Agregar(empleado);
        }
        public void Editar(Empleado empleado)
        {
            _repo.Editar(empleado);
        }
        public void EliminarPorId(int id)
        {
            _repo.EliminarPorId(id);
        }
        
    }
}
