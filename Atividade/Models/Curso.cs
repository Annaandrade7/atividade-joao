using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Models
{
    internal class Curso
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Coordenador { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{Nome};{Descricao};{Coordenador};{Status}";
        }
    }
}
