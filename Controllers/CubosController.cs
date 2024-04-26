using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExamen2.Models;
using WebApiExamen2.Repositories;

namespace WebApiExamen2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubosController : ControllerBase
    {
        private RepositoryCubos repo;

        public CubosController(RepositoryCubos repo)
        {
            this.repo = repo;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<List<Cubo>>> MostrarCubos()
        {
            return await this.repo.GetCubos();
        }

        [HttpGet("[action]/{marca}")]
        public async Task<ActionResult<List<Cubo>>> CubosMarcas(string marca)
        {
            return await this.repo.FindCubosMarcasAsync(marca);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> InsertarUsuario(UsuarioCubo usu)
        {
            await this.repo.InsertarUsuarioAsync(usu);
            return Ok();
        }

        [Authorize]
        [HttpGet("[action]/{id}")] //El action es para que te ponga el nombre de getpelicula
        public async Task<ActionResult<UsuarioCubo>> PerfilUsuario(int id) //SOLO UNA PELI
        {
            return await this.repo.PerfilUsuarioAsync(id);
        }

        [Authorize]
        [HttpGet("[action]/{id}")] //El action es para que te ponga el nombre de getpelicula
        public async Task<ActionResult<List<CompraCubo>>> PedidosUsuario(int id) //SOLO UNA PELI
        {
            return await this.repo.PedidosUsuarioAsync(id);
        }


        [Authorize]
        [HttpPost("[action]")] //El action es para que te ponga el nombre de getpelicula
        public async Task<ActionResult> RealizarPedidosUsuario(CompraCubo pedido) //SOLO UNA PELI
        {
             await this.repo.RealizarPedidoUsuarioAsync(pedido);
            return Ok();
        }
    }
}
