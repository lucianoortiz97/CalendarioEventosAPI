using CalendarioEventos.Entities;

namespace CalendarioEventos.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public Usuario Crear ( Usuario usuario )
        {
            usuario.Id = _usuarios.Count() + 1;
            _usuarios.Add(usuario);
            return usuario;
        }

        public  Usuario ObtenerPorId ( int id ) {
            return _usuarios.FirstOrDefault( u => u.Id == id );
        }

        public void Actualizar ( Usuario usuario )
        {
            var UsuarioExistente = ObtenerPorId (usuario.Id);
            if (UsuarioExistente != null)
            {
                UsuarioExistente.Nombre = usuario.Nombre;
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
    // CARGAR AUTOMATICAMENTE UN USUARIO
    // public void CargarUsuarioEjemplo()
    // {
    //     Usuario usuarioEjemplo = new Usuario
    //     {
    //         Id = 1,
    //         Nombre = "Lucho Ortiz",
    //         Email = "bdsjkndsa@asd.com",
    //         Password = "asbdnjk"
    //     };
    //     _usuarioRepository.CrearUsuario(usuarioEjemplo);
    // }

