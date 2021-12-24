using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Models
{
    class Processos
    {
        public List<Processo> processos = new List<Processo>();

        public void AddProcessos(Processo p)
        {
            processos.Add(p);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Processo p in processos)
            {        

                str.Append(p.Numero + " ");
        
            }
            return str.ToString();
        }
    }
}
