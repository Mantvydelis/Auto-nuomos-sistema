using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Models
{
    public class Klientas
    {
        private string v;

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateOnly GimimoMetai { get; set; }

        public Klientas(string vardas, string pavarde, DateOnly gimimoMetai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoMetai;
        }
        public Klientas() { }

        public override string ToString()
        {
            return $"{Vardas}, {Pavarde}, {GimimoMetai} ";
        }

    }
}
