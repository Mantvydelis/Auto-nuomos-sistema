using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Contracts
{
    public interface IAutonuomaService
    {
        List<Automobilis> GautiVisusAutomobilius();
        void PridetiNaujaAutomobili(Automobilis automobilis);
        List<Klientas> GautiVisusKlientus();
        void IrasytiKlientus(string vardas, string pavarde, DateOnly gimimoData);
        void SukurtiNuoma(string vardas, string pavarde, int automobilioId, DateTime nuomosPradzia, int nuomosDienos);
        void PridetiKlienta(Klientas klientas);
        List<NuomosUzsakymas> GautiVisusUzsakymus();

        //void skaiciuotiBendraNuomosKaina();

        List<NuomosUzsakymas> gautiUzsakymusPagalKlienta(string klientoVardas, string klientoPavarde);

    }

}
