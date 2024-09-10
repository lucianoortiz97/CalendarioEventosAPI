using CalendarioEventos.Entities;

namespace CalendarioEventos.Service
{
    public interface IUsuarioService
    {
        Usuario CrearUsuario ( Usuario usuario );
        Usuario ObtenerUsuarioPorId ( int id );
        void ActualizarUsuario ( Usuario usuario);
        void EliminarUsuario ( int id );
    }
}