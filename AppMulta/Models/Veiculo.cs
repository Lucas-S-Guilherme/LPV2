using System.ComponentModel.DataAnnotations.Schema;

namespace AppMulta.Models
{
    [Table("veiculo")]
    public class Veiculo
    {
        [Column("id_vei")]
        public int Id {get; set;}
        [Column("modelo")]
        public string? Modelo {get; set;}
        [Column("marca")]
        public string? Marca {get; set;}
        [Column("placa")]
        public string? Placa {get; set;}

        public List<Multa>? Multas {get; set;}
    }
}