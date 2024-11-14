using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Models
{
    internal class Escola
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public override string ToString()
        {

            {
                return $"{NomeFantasia};{RazaoSocial};{CNPJ};{Rua};{Numero};{Bairro};{Cidade};{Estado}";
            }
        }
    }
}
