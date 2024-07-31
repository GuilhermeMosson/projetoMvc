namespace projetoMvc.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public string Proprietario { get; set; } = string.Empty;
        public DateTime DataLancamento { get; set; }
        public string Desc { get; set; } = string.Empty;
    }
}
