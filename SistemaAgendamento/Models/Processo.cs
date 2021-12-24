using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Models
{
    class Processo
    {
        public bool Status { get; set; }
        public string Numero { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        public Processo(bool status, string numero, double valor, DateTime inicio, string estado)
        {
            Status = status;
            Numero = numero;
            Valor = valor;
            Inicio = inicio;
            Estado = estado;
        }



    }
}
