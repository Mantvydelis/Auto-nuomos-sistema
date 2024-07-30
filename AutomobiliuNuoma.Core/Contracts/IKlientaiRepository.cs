using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Contracts
{
    public interface IKlientaiRepository
    {
        void IrasytiKlientus(List<Klientas> klientai);
       
        List<Klientas> GautiVisusKlientus();

        void PridetiKlienta(Klientas klientas);

    }

}
