namespace TrabalhandoComListas.Modelos
{
    public class Fornecedor
    {
        public Fornecedor(
            int id,
            string nome,
            string sobrenome,
            string endereco,
            string contato,
            bool exclusivo)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            Contato = contato;
            Exclusivo = exclusivo;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Endereco { get; private set; }
        public string Contato { get; private set; }
        public bool Exclusivo { get; private set; }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome} | {Endereco} | {Contato} {(Exclusivo ? "Exclusivo" : "Não Exclusivo")}";
        }
    }
}
