using CalendarioEventos.Entities;

namespace CalendarioEventos.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public Usuario Crear ( Usuario usuario )
        {
            usuario.Id = _usuarios.count++;
            _usuarios.Add(usuario);
            return usuario;
        }

        public void Actualizar ( Usuario usuario )
        {
            var UsuarioExistente = ObtenerPorId (usuario.id);
            if (UsuarioExistente != null)
            {
                UsuarioExistente.Nombre = usuario.Nombre;
                UsuarioExistente.Apellido = usuario.Apellido;
                UsuarioExistente.Password = usuario.Password;
                }
        }

        public void Eliminar ( int id )
        {
            var usuario = ObtenerPorId (id);
            if (usuario != null)
            {
                _usuarios.Remove(usuario);
                }
            }
    }
}