namespace TheBakery.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }

        public decimal ValorTotal { get; set; }
        public string FormaPagamento { get; set; }

        public DateTime DataVenda { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public Cliente Cliente { get; internal set; }
    }
}
