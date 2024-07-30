using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Contracts
{
    public interface IKlientaiService
    {
        List<Klientas> GautiVisusKlientus();
        void IrasytiIFaila();
        void NuskaitytiIsFailo();
        void PridetiKlienta(Klientas klientas);
        Klientas PaieskaPagalVardaPavarde(string vardas, string pavarde);

    }
}
