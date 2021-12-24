using SistemaAgendamento.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace SistemaAgendamento
{
    class Program
    {

        static void Main(string[] args)
        {
            Empresas empresas = new Empresas();
            double total = 0;
            int numProcessos = 0;
            Processos processosSetembro = new Processos();
            Processos processosMesmoEstado = new Processos();
            Processos processosTrab = new Processos();


            foreach (Empresa e in empresas.empresas)
            {
                total = total + e.processos.processos.Where(p => p.Status == true).Sum(p => p.Valor);
                numProcessos = numProcessos + e.processos.processos.Where(p => p.Valor > 100000).Count();
                processosSetembro.processos = e.processos.processos.Where(p => p.Inicio.Month == 9 && p.Inicio.Year == 2007).ToList();
                foreach (Processo p in e.processos.processos.Where(p => p.Estado.Equals(e.Estado)).ToList())
                    processosMesmoEstado.processos.Add(p);
                foreach (Processo p in e.processos.processos.Where(p => p.Numero.Contains("TRAB")).ToList())
                    processosTrab.processos.Add(p);
            }
            double media = empresas.empresas.Where(x => x.Nome == "Empresa A").FirstOrDefault().processos.processos.Where(x => x.Estado == "Rio de Janeiro").Sum(x => x.Valor) / empresas.empresas.Where(x => x.Nome == "Empresa A").FirstOrDefault().processos.processos.Where(x => x.Estado == "Rio de Janeiro").Count();

            Console.WriteLine("Calcular a soma dos processos ativos: " + total);
            Console.WriteLine("Calcular a a média do valor dos processos no Rio de Janeiro para o Cliente Empresa A: " + media);
            Console.WriteLine("Calcular o Número de processos com valor acima de R$ 100.000,00: " + numProcessos);
            Console.WriteLine("Obter a lista de Processos de Setembro de 2007: " + processosSetembro.ToString());
            Console.WriteLine("Obter a lista de processos no mesmo estado do cliente, para cada um dos clientes: ");
            foreach (Empresa e in empresas.empresas)
            {
                Console.WriteLine(e.Nome);
                foreach (Processo p in e.processos.processos)
                {
                    if (processosMesmoEstado.processos.Where(x => x.Numero.Equals(p.Numero)).Any())
                        Console.WriteLine(p.Numero);

                }
            }
            Console.WriteLine("Obter a lista de processos que contenham a sigla “TRAB”: " + processosTrab.ToString());
        }
    }
}
