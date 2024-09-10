using CalendarioEventos.Data;
using CalendarioEventos.Entities;


namespace CalendarioEventos.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService ( IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

         public Usuario CrearUsuario ( Usuario usuario )
        {
            return _usuarioRepository.Crear(usuario);
        }

        public Usuario ObtenerUsuarioPorId ( int id)
        {
            return _usuarioRepository.ObtenerPorId(id);
        }

        public void ActualizarUsuario ( Usuario usuario )
        {
            _usuarioRepository.Actualizar(usuario);
        }

        public void EliminarUsuario ( int id )
        {
            _usuarioRepository.Eliminar(id);
        }
    }
}
