using Sistema_de_Cadastro.Models;

namespace Sistema_de_Cadastro.Repositório
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
