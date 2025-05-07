using System.ComponentModel.DataAnnotations.Schema;

namespace AppMulta.Models
{
    [Table("Multa")]
    public class Multa
    {
        [Column("id_vei")]
        public int Id {get; set;}
        [Column("descricao")]
        public string? Descricao {get; set;}
        [Column("valor_multa")]
        public decimal? ValorMulta {get; set;}
        [Column("id_veiculo")]
        public int IdVeiculo {get; set;}

        [ForeignKey("id_veiculo_fk")] // informa o atributo da classe que irá armazenar a FK
        public Veiculo? Veiculo {get; set;} // indica o veículo multado
    }
}