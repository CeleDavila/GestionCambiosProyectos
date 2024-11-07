using ArquitecturaLimpia.Dominio.Interfaces;
using ArquitecturaLimpiaApp.Dominio.Interfaces;

namespace ArquitecturaLimpiaAPP.Dominio.Interfaces
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        IUsuarioRepositorio Usuarios { get; }
        IRolRepositorio Roles { get; }
        IUsuarioRolRepositorio UsuarioRolRepositorio { get; }
        Task<int> GrabarCambiosAsync();
    }
}
