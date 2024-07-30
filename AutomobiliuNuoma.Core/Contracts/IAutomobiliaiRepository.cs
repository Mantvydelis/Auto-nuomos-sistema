using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Contracts
{
    public interface IAutomobiliaiRepository
    {
        List<Automobilis> NuskaitytiAutomobilius();
        void IrasytiAutomobilius(List<Automobilis> automobiliai);

    }

   
}
