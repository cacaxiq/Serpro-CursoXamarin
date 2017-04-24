using System;
namespace Serpro.Shared.Model
{
    public class Pessoa
    {
        public string Id
        {
            get; set;
        }
        public string Nome
        {
            get;
            set;
        }
        public string Sexo
        {
            get; set;
        }

        public DateTime DataNascimento
        {
            get; set;
        }

        public bool Ativo
        {
            get; set;
        }

        public string Ocupacao
        {
            get; set;
        }

        public int QtdadeFilhos
        {
            get; set;
        }

        public long CPF
        {
            get; set;
        }

    }
}
