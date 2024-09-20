
namespace TheBakery.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public static implicit operator Produto(List<Produto> v)
        {
            throw new NotImplementedException();
        }
    }
}
