using System;
using ListViewExample.Infra;

namespace ListViewExample.Model
{
    public class Pessoa
    {
        public string Id
        {
            get; set;
        }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
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
