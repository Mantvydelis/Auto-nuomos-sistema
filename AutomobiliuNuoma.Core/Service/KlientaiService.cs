using AutomobiliuNuoma.Core.Contracts;
using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Service
{
    public class KlientaiService : IKlientaiService
    {
        private readonly IKlientaiRepository _klientaiRepository;
        private List<Klientas> VisiKlientai = new List<Klientas>();
        

        public KlientaiService(IKlientaiRepository klientaiRepository)
        {
            _klientaiRepository = klientaiRepository;
        }

        public List<Klientas> GautiVisusKlientus()
        {
            if (VisiKlientai.Count == 0)
                VisiKlientai = _klientaiRepository.GautiVisusKlientus();
            return VisiKlientai;
        }

        public void IrasytiIFaila()
        {
            _klientaiRepository.IrasytiKlientus(VisiKlientai);
        }

        public void NuskaitytiIsFailo()
        {
            _klientaiRepository.GautiVisusKlientus();
        }

        public void PridetiKlienta(Klientas klientas)
        {
            VisiKlientai.Add(klientas); 
            _klientaiRepository.IrasytiKlientus(VisiKlientai); 
        }


        public Klientas PaieskaPagalVardaPavarde(string vardas, string pavarde)
        {
            Klientas klientas = new Klientas();
            foreach (Klientas k in VisiKlientai)
            {
                if (k.Vardas == vardas && k.Pavarde == pavarde)
                {
                    klientas = k;
                    break;
                }
            }
            return klientas;


        }


    }
} 
