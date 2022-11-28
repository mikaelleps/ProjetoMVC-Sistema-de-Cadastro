using Sistema_de_Cadastro.Data;
using Sistema_de_Cadastro.Models;

namespace Sistema_de_Cadastro.Repositório
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _context;
        public ContatoRepositorio(Data.BancoContext bancoContext)
        {
            this._context = bancoContext;
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no banco de dados
            _context.Contatos.Add(contato);
            _context.SaveChanges();

            return contato;
        }
    }
}
