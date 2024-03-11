//using System.Formats.Asn1;

namespace CP1___PETSHOP.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "Nicky";
        public int Idade { get; set; } = 14;
        public string Raca { get; set; } = "Poodle";
        public string Cor { get; set; } = "Preto";
        public TipoClass Class { get; set; } = TipoClass.Cachorro;
    }
}
