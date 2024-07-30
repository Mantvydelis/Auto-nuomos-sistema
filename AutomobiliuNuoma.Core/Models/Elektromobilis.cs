using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Models
{
    public class Elektromobilis : Automobilis
    {
        public int BaterijosTalpa { get; set; }
        public int KrovimoLaikas { get; set; }

        public Elektromobilis(int id, string marke, string modelis, double nuomosKaina, int baterijosTalpa, int krovimoLaikas)
        {
            Id = id;
            Marke = marke;
            Modelis = modelis;
            NuomosKaina = nuomosKaina;
            BaterijosTalpa = baterijosTalpa;
            KrovimoLaikas = krovimoLaikas;
        }

        public override string ToString()
        {
            return $"{Id}, {Marke} {Modelis}, {NuomosKaina} eur., {BaterijosTalpa} KmW, {KrovimoLaikas} valandu";
        }
    }


}
