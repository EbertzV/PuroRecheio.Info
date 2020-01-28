using System;

namespace PuroRecheio.WebAPI.Infra
{
    public class ProdutosViewModel
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public string Tamanho { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
    }
}
