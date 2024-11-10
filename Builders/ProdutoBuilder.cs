// Builders/ProdutoBuilder.cs
namespace ProdutoApi.Builders
{
  using ProdutoApi.Models;

  public class ProdutoBuilder
  {
    private string _nome = "Produto Padrão";
    private decimal _preco = 0.0m;
    private string _categoria = "Geral";
    private bool _disponivel = true;

    public ProdutoBuilder ComNome(string nome)
    {
      _nome = nome;
      return this;
    }

    public ProdutoBuilder ComPreco(decimal preco)
    {
      _preco = preco;
      return this;
    }

    public ProdutoBuilder ComCategoria(string categoria)
    {
      _categoria = categoria;
      return this;
    }

    public ProdutoBuilder ComDisponibilidade(bool disponivel)
    {
      _disponivel = disponivel;
      return this;
    }

    public Produto Build()
    {
      return new Produto(_nome, _preco, _categoria, _disponivel);
    }
  }
}