namespace BlazorApp1.Models
{
    public class CalculadoraImc
    { 
     public int Id {get; set;}
     public string? Nome {get; set;}
     public double? Peso { get; set;}
     public double? Altura {get; set;} 

        public double? CalcularImc()
        {
            return Peso/(Altura * Altura);
        }

        public string? Situacao()
        {
            string? result = null;
            if (CalcularImc() < 18.5) result = "peso abaixo do normal";
            if (CalcularImc() >= 18.5 && CalcularImc() <= 24.9) result = "peso normal";
            if (CalcularImc() >= 25 && CalcularImc() <= 29.9) result = "sobrepeso";
            if (CalcularImc() >= 30) result = "Obesidade";

            return result;
        }
    }
}
