// Models/Produto.cs
namespace ProdutoApi.Models
{
  public class Produto
  {
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public string Categoria { get; private set; }
    public bool Disponivel { get; private set; }

    public Produto(string nome, decimal preco, string categoria, bool disponivel)
    {
      Nome = nome;
      Preco = preco;
      Categoria = categoria;
      Disponivel = disponivel;
    }
  }
}