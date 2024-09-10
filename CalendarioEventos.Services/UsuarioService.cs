using CalendarioEventos.Data;
using CalendarioEventos.Entities;

namespace CalendarioEventos.Service
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;

        public UsuarioService ( IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario CrearUsuario ( Usuario usuario )
        {
            return _usuarioRepository.Crear(usuario);
        }

        public Usuario ObtenerPorId ( int id)
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
