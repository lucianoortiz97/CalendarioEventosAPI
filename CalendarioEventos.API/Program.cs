using System;
using CalendarioEventos.Entities;
using CalendarioEventos.Services;
using CalendarioEventos.Data;

class Program
{
    static void Main(string[] args)
    {
        IUsuarioRepository usuarioRepository = new UsuarioRepository();
        IUsuarioService usuarioService = new UsuarioService(usuarioRepository);

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("==== Menu de Usuarios ====");
            Console.WriteLine("1. Crear Usuario");
            Console.WriteLine("2. Obtener Usuario por ID");
            Console.WriteLine("3. Actualizar Usuario");
            Console.WriteLine("4. Eliminar Usuario");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opcion: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearUsuario(usuarioService);
                    break;
                case "2":
                    ObtenerUsuarioPorId(usuarioService);
                    break;
                case "3":
                    ActualizarUsuario(usuarioService);
                    break;
                case "4":
                    EliminarUsuario(usuarioService);
                    break:
                case "0":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void CrearUsuario(IUsuarioService usuarioService)
    {
        Console.Write("Ingrese el nombre del usuario: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el email del usuario: ");
        string email = Console.ReadLine();
        Console.Write("Ingrese la contraseña del usuario: ");
        string password = Console.ReadLine();

        var usuario = new Usuario
        {
            Nombre = nombre,
            Email = email,
            Password = password
        };

        var nuevoUsuario = usuarioService.CrearUsuario(usuario);
        Console.WriteLine($"Usuario creado con éxito. ID: {nuevoUsuario.Id}");
    }

    static void ObtenerUsuarioPorId(IUsuarioService usuarioService)
    {
        Console.Write("Ingrese el ID del usuario: ");
        int id = int.Parse(Console.ReadLine());

        var usuario = usuarioService.ObtenerUsuarioPorId(id);
        if (usuario != null)
        {
            Console.WriteLine($"Usuario: {usuario.Nombre}, Email: {usuario.Email}");
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }

    static void ActualizarUsuario(IUsuarioService usuarioService)
    {
        Console.Write("Ingrese el ID del usuario a actualizar: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el nuevo nombre del usuario: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el nuevo email del usuario: ");
        string email = Console.ReadLine();
        Console.Write("Ingrese la nueva contraseña del usuario: ");
        string password = Console.ReadLine();

        var usuario = new Usuario
        {
            Id = id,
            Nombre = nombre,
            Email = email,
            Password = password
        };

        usuarioService.ActualizarUsuario(usuario);
        Console.WriteLine("Usuario actualizado con éxito.");
    }

    static void EliminarUsuario(IUsuarioService usuarioService)
    {
        Console.Write("Ingrese el ID del usuario a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        usuarioService.EliminarUsuario(id);
        Console.WriteLine("Usuario eliminado con éxito.");
    }
}
