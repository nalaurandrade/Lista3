namespace atv002.Models
{
    public class Frete
    {
        public string Produto { get; set; }
        public float PesoProduto { get; set; }
        public float AlturaProduto { get; set; }
        public float LarguraProduto { get; set; }
        public float ComprimentoProduto { get; set; }
        public string estado { get; set; }

        public float GetLarguraProduto()
        {
            return LarguraProduto;
        }

        public double Volume; (float larguraProduto) AlturaProduto* LarguraProduto;
    }
}
