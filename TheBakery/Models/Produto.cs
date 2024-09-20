namespace TheBakery.Models
{
    public class Produto
    {
        internal object Vendas;

        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
