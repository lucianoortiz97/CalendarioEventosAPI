using CalendarioEventos.Entities;

    namespace CalendarioEventos.Data
{
    public interface IUsuarioRepository
    {
        Usuario Crear( Usuario usuario );
        Usuario ObtenerPorId ( int id );
        void Actualizar ( Usuario usuario );
        void Eliminar ( int id );
    }
}