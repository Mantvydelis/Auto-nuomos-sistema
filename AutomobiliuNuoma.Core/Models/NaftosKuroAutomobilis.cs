using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Models
{
    public class NaftosKuroAutomobilis : Automobilis
    {
        public double DegaluSanaudos { get; set; }

        public NaftosKuroAutomobilis(int id, string marke, string modelis, double nuomosKaina, double degaluSanaudos)
        {
            Id = id;
            Marke = marke;
            Modelis = modelis;
            NuomosKaina = nuomosKaina;
            DegaluSanaudos = degaluSanaudos;

        }

        public override string ToString()
        {
            return $"{Id}, {Marke} {Modelis}, {NuomosKaina} eur., {DegaluSanaudos} l/100km  ";
        }



    }
}
