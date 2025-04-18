using AppPessoa.Contexto;
using AppPessoa.Models;

//Semelhante ao controller
namespace AppPessoa.Services
{
    public class PessoaService
    {
        private readonly ContextBD _context;

        public PessoaService(ContextBD con)
        {
            _context = con;
        }

        public async Task<List<Pessoa>>? Pessoas()
        {
            var pessoas = _context.Pessoas?.ToList();
            return pessoas;
        }

        public async Task<List<Pessoa>>? PessoasOrdenadas ()
        {
            var pessoas = _context.Pessoas?.OrderBy(p => p.Nome).ToList();
            return pessoas;
        }

        public async Task<Pessoa>? GetPessoa(int id)
        {
            var pessoa = _context.Pessoas?.Where(p => p.Id == id).FirstOrDefault();
            return pessoa;
        }

        public async Task<Pessoa>? GetPessoa(string cpf)
        {
            var pessoa = _context.Pessoas?.Where(p => p.Cpf == cpf).FirstOrDefault();
            return pessoa;
        }

        public async Task Add(Pessoa pessoa)
        {
            _context.Pessoas?.Add(pessoa);
        }

    }
}