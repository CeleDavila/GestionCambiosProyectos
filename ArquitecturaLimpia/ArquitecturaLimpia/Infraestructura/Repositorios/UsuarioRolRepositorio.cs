using ArquitecturaLimpia.Dominio.Entidades;
using ArquitecturaLimpia.Dominio.Interfaces;
using ArquitecturaLimpiaAPP.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Infraestructura.Repositorios
{
    public class UsuarioRolRepositorio : IUsuarioRolRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public UsuarioRolRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<UsuarioRol> CrearAsync(UsuarioRol usuariorol)
        {
            _appDbContext.UsuariosRoles.Add(usuariorol);
        }

        public Task ActualizarAsync(UsuarioRol usuariorol)
        {
            throw new NotImplementedException();
        }

       
        public Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioRol> ListaPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioRol>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
