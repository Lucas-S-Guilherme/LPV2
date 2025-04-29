// PessoaService.cs
using AppInventario.Contexto;
using AppInventario.Models;
using Microsoft.EntityFrameworkCore;

namespace AppInventario.Services
{
    public class PessoaService
    {
        private readonly ContextoBD _context;

        public PessoaService(ContextoBD con)
        {
            _context = con ?? throw new ArgumentNullException(nameof(con));
        }

        public async Task<List<Pessoa>> Pessoas()
        {
            return await _context.Pessoas
                .Include(p => p.Propriedades)
                .ToListAsync() ?? new List<Pessoa>();
        }

        public async Task<Pessoa?> GetPessoa(int id)
        {
            return await _context.Pessoas
                .Include(p => p.Propriedades)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Pessoa?> GetPessoa(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return null;

            return await _context.Pessoas
                .Include(p => p.Propriedades)
                .FirstOrDefaultAsync(p => p.Cpf == cpf);
        }

        public async Task Add(Pessoa pessoa)
        {
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa));

            await _context.Pessoas.AddAsync(pessoa);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }
    }
}