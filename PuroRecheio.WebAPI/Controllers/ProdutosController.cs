using Microsoft.AspNetCore.Mvc;
using PuroRecheio.WebAPI.Infra;
using System;
using System.Threading.Tasks;

namespace PuroRecheio.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public sealed class ProdutosController : ControllerBase
    {
        private readonly IProdutosDataAccess _produtosDataAccess;
        public ProdutosController(IProdutosDataAccess produtosDataAccess)
        {
            _produtosDataAccess = produtosDataAccess;
        }
        [HttpGet]
        public async Task<IActionResult> RecuperarProdutos()
        {
            try
            {
                return Ok(await _produtosDataAccess.RecuperarProdutos());
            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
