using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16PessoasMaioresDeIdade.Entities
{
    internal class Pessoa(string nome, uint idade)
    {
        public string Nome { get; private set; } = nome;
        public uint Idade { get; private set; } = idade;

        public override string ToString()
        {
            string idadeMessagem = Idade == 1 ? "1 ano" : $"{Idade} anos";

            return $"{Nome} - {idadeMessagem}";
        }
    }
}
