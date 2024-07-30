using AutomobiliuNuoma.Core.Contracts;
using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Service
{
    public class AutonuomosService : IAutonuomaService
    {
        private readonly IKlientaiService _klientaiService;
        private readonly IAutomobiliaiService _automobiliaiService;

        private List<Automobilis> VisiAutomobiliai;

        private List<NuomosUzsakymas> VisiUzsakymai;

        public List<Automobilis> GautiVisusAutomobilius()
        {
            return VisiAutomobiliai;
        }
        public AutonuomosService(IKlientaiService klientaiService, IAutomobiliaiService automobiliaiService)
        {
            _automobiliaiService = automobiliaiService;
            _klientaiService = klientaiService;
            VisiAutomobiliai = _automobiliaiService.GautiVisusAutomobilius();
            VisiUzsakymai = new List<NuomosUzsakymas>();
        }

        public List<NuomosUzsakymas> GautiVisusUzsakymus()
        {
            return VisiUzsakymai;

        }

        public void PridetiNaujaAutomobili(Automobilis automobilis)
        {
            _automobiliaiService.PridetiAutomobili(automobilis);
            VisiAutomobiliai = _automobiliaiService.GautiVisusAutomobilius();
        }

        public List<Klientas> GautiVisusKlientus()
        {
            return _klientaiService.GautiVisusKlientus();
        }

        public void IrasytiKlientus(string vardas, string pavarde, DateOnly gimimoData)
        {
            var klientas = new Klientas(vardas, pavarde, gimimoData);
            _klientaiService.PridetiKlienta(klientas);
        }

        public void SukurtiNuoma(string klientoVardas, string klientoPavarde, int autoId, DateTime nuomosPradzia, int dienos)
        {
            Klientas klientas = _klientaiService.PaieskaPagalVardaPavarde(klientoVardas, klientoPavarde);

            Automobilis automobilis = new Automobilis();

            foreach (Automobilis a in VisiAutomobiliai)
            {
                if (a.Id == autoId)
                    automobilis = a;
            }

            NuomosUzsakymas nuomosUzsakymas = new NuomosUzsakymas
            {
                Uzsakovas = klientas,
                NuomuojamasAuto = automobilis,
                NuomosPradzia = nuomosPradzia,
                DienuKiekis = dienos
            };
            VisiUzsakymai.Add(nuomosUzsakymas);

        }

        public void PridetiKlienta(Klientas klientas)
        {
            _klientaiService.PridetiKlienta(klientas);
        }


        //void skaiciuotiBendraNuomosKaina()
        //{

        //}

        public List<NuomosUzsakymas> gautiUzsakymusPagalKlienta(string klientoVardas, string klientoPavarde)
        {
            Klientas klientas = _klientaiService.PaieskaPagalVardaPavarde(klientoVardas, klientoPavarde);

            if (klientas == null)
            {
                return new List<NuomosUzsakymas>();
            }

            return VisiUzsakymai.Where(u => u.Uzsakovas == klientas).ToList();
        }
    }
}
