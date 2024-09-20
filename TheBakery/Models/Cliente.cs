namespace TheBakery.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public bool TemFidelidade { get; set; }
        public int PontosFidelidade { get; set; }

    }
}
