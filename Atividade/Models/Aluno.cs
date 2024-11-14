using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Models
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Nome};{CPF};{DataNascimento.ToShortDateString()};{Telefone};{Email}";
        }
    }
}
