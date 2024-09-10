public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddScoped<IUsuarioRepository, UsuarioRepository>();
    services.AddScoped<IUsuarioService, UsuarioService>();
}