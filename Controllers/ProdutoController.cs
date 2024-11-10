// Controllers/ProdutoController.cs
using Microsoft.AspNetCore.Mvc;
using ProdutoApi.Builders;
using ProdutoApi.Models;

namespace ProdutoApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProdutoController : ControllerBase
  {
    [HttpPost]
    public IActionResult CriarProduto(string nome, decimal preco, string categoria, bool disponivel)
    {
      var produtoBuilder = new ProdutoBuilder()
          .ComNome(nome)
          .ComPreco(preco)
          .ComCategoria(categoria)
          .ComDisponibilidade(disponivel);

      Produto produto = produtoBuilder.Build();

      return Ok(produto);
    }

    [HttpGet("exemplo")]
    public IActionResult ExemploProduto()
    {
      var produtoExemplo = new ProdutoBuilder()
          .ComNome("Notebook")
          .ComPreco(3000.00m)
          .ComCategoria("Eletrônicos")
          .ComDisponibilidade(true)
          .Build();

      return Ok(produtoExemplo);
    }
  }
}