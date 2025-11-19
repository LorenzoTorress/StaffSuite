using Gestion_Empleados.Modelo;
using Gestion_Empleados.Repositorio;
namespace Gestion_Empleados.Servicios
{
    public class ServicioDepartamento
    {
        private readonly IRepositorio<Departamento> _repo;
        public ServicioDepartamento(IRepositorio<Departamento> repo)
        {
            _repo = repo;
        }
        public List<Departamento> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }
        public Departamento? BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }
        public void Agregar(Departamento departamento)
        {
            _repo.Agregar(departamento);
        }
        public void Editar(Departamento departamento)
        {
            _repo.Editar(departamento);
        }
        public void EliminarPorId(int id)
        {
            _repo.EliminarPorId(id);
        }
        
    }
}
