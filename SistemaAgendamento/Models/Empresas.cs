using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Models
{
    class Empresas
    {
        public List<Empresa> empresas = new List<Empresa>();

        public Empresas()
        {
            CarregarEmpresas();
        }

        public void AddEmpresa(Empresa e)
        {
            empresas.Add(e);
        }

        public void CarregarEmpresas()
        {

            Empresa a = new Empresa("Empresa A", 000000000001, "Rio de Janeiro");
            a.processos.AddProcessos(new Processo(true, "00001CIVELRJ", 200000, DateTime.Parse("10/10/2007"), "Rio de Janeiro"));
            a.processos.AddProcessos(new Processo(true, "00002CIVELSP", 100000, DateTime.Parse("20/10/2007"), "São Paulo"));
            a.processos.AddProcessos(new Processo(false, "00003TRABMG", 10000, DateTime.Parse("30/10/2007"), "Minas Gerais"));
            a.processos.AddProcessos(new Processo(false, "00004CIVELRJ", 20000, DateTime.Parse("10/11/2007"), "Rio de Janeiro"));
            a.processos.AddProcessos(new Processo(true, "00005CIVELSP", 35000, DateTime.Parse("15/10/2007"), "São Paulo"));

            Empresa b = new Empresa("Empresa B", 000000000002, "São Paulo");
            b.processos.AddProcessos(new Processo(true, "00006CIVELRJ", 20000, DateTime.Parse("01/05/2007"), "Rio de Janeiro"));
            b.processos.AddProcessos(new Processo(true, "00007CIVELRJ", 700000, DateTime.Parse("02/06/2007"), "Rio de Janeiro"));
            b.processos.AddProcessos(new Processo(false, "00008CIVELSP", 500, DateTime.Parse("03/07/2007"), "São Paulo"));
            b.processos.AddProcessos(new Processo(true, "00009CIVELSP", 32000, DateTime.Parse("04/08/2007"), "São Paulo"));
            b.processos.AddProcessos(new Processo(false, "00010TRABAM", 1000, DateTime.Parse("05/09/2007"), "Amazonas"));

            empresas.Add(a);
            empresas.Add(b);
            
        }
    }
}
