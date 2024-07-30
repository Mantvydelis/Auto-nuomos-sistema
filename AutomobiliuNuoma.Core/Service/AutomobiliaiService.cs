using AutomobiliuNuoma.Core.Contracts;
using AutomobiliuNuoma.Core.Models;
using AutomobiliuNuoma.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Service
{
    public class AutomobiliaiService : IAutomobiliaiService
    {
        private readonly IAutomobiliaiRepository _automobiliaiRepository;
        private List<Automobilis> _automobiliai;

        public AutomobiliaiService(IAutomobiliaiRepository automobiliaiRepository)
        {
            _automobiliaiRepository = automobiliaiRepository;
            _automobiliai = _automobiliaiRepository.NuskaitytiAutomobilius();
        }
        public List<Automobilis> GautiVisusAutomobilius()
        {
            return _automobiliai;
        }

        public void IrasytiIFaila()
        {
            _automobiliaiRepository.IrasytiAutomobilius(_automobiliai);

        }

        public void NuskaitytiIsFailo()
        {
            _automobiliaiRepository.NuskaitytiAutomobilius();
        }

        public List<Automobilis> PaieskaPagalMarke(string marke)
        {
            List<Automobilis> paieskosRezultatai = new List<Automobilis>();
            List<Automobilis> automobiliai = _automobiliaiRepository.NuskaitytiAutomobilius();
            foreach (Automobilis a in automobiliai)
            {
                if (a.Marke == marke)
                    paieskosRezultatai.Add(a);
            }
            return paieskosRezultatai;
        }

        public void PridetiAutomobili(Automobilis automobilis)
        {
            _automobiliai.Add(automobilis);
            IrasytiIFaila();
        }



    }
}
