namespace Gestion_Empleados.AccesoDatos
{
    public interface IAccesoDatos<T>
    {
        List<T> Leer();
        void Guardar(List<T> lista);
    }
}
