using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Contracts
{
    public interface IAutomobiliaiService
    {
        List<Automobilis> GautiVisusAutomobilius();
        void IrasytiIFaila();
        void NuskaitytiIsFailo();
        List<Automobilis> PaieskaPagalMarke(string marke);
        void PridetiAutomobili(Automobilis automobilis);

    }

   
}
