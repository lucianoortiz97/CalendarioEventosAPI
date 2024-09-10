using CalendarioEventos.Entities;
using CalendarioEventos.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalendarioEventos.API.Controllers
{
    [APIController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController ( IUsuarioService usuarioService )
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            var nuevoUsuario = _usuarioService.CrearUsuario(usuario);
            return Ok(nuevoUsuario);
        }

        [HttpGet("(id)")]
        public IActionResult ObtenerUsuarioPorId(int id)
        {
        var usuario = _usuarioService.ObtenerUsuarioPorId(id);
        if ( usuario == null ){
            return NotFound();
        }
        return Ok(usuario);
        }
        [HttpPut("{id}")]
        public IActionResult ActualizarUsuario( int id, [FromBody] Usuario usuario)
        {
            usuario.ID = id;
            _usuarioService.ActualizarUsuario(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarUsuario(int id)
        {
            _usuarioService.EliminarUsuario(id);
            return NoContent();
        }    
    }
}