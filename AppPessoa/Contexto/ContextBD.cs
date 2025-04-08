using AppPessoa.Models;

namespace AppPessoa.Contexto
{
    public class ContextBD
    {

        public List<Pessoa>? Pessoas {get; set;}
        public ContextBD()
        {
            Pessoas = new List<Pessoa>();
        }

        
    }
}