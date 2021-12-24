using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Models
{
    class Empresa
    {
        public string Nome { get; set; }
        public long Cnpj { get; set; }
        public string Estado { get; set; }

        public Processos processos = new Processos();

        public Empresa(string nome, long cnpj, string estado)
        {
            Nome = nome;
            Cnpj = cnpj;
            Estado = estado;
        }

    
    }
}
