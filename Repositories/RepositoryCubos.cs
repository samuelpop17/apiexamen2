using Microsoft.EntityFrameworkCore;
using WebApiExamen2.Data;
using WebApiExamen2.Models;

namespace WebApiExamen2.Repositories
{
    public class RepositoryCubos
    {
        private CubosContext context;

        public RepositoryCubos(CubosContext context)
        {
            this.context = context;
        }

        public async Task<List<Cubo>> GetCubos()
        {
            return await this.context.Cubos.ToListAsync();
        }

        public async Task<List<Cubo>> FindCubosMarcasAsync(string marca)
        {
            return await this.context.Cubos.Where(x => x.Marca == marca).ToListAsync();
        }


        public async Task InsertarUsuarioAsync(UsuarioCubo user)
        {
            this.context.UsuariosCubos.Add(user);
            await this.context.SaveChangesAsync();
        }

        public async Task<UsuarioCubo> PerfilUsuarioAsync(int id)
        {
            return await this.context.UsuariosCubos.FirstOrDefaultAsync(x => x.IdUsuario == id);
        }

        public async Task<List<CompraCubo>> PedidosUsuarioAsync(int id)
        {
            return await this.context.ComprasCubos.Where(x => x.id_usuario == id).ToListAsync();
        }

        public async Task RealizarPedidoUsuarioAsync(CompraCubo pedido)
        {
            this.context.ComprasCubos.Add(pedido);
            await this.context.SaveChangesAsync();
        }

        public async Task<UsuarioCubo> LoginAsync(string nombre, string password)
        {
            return await this.context.UsuariosCubos.Where(x => x.Nombre == nombre && x.Pass == password).FirstOrDefaultAsync();
        }
    }
}
