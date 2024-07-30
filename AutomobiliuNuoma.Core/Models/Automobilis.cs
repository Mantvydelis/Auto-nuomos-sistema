using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Models
{
    public class Automobilis
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public double NuomosKaina { get; set; }


        public Automobilis() { }

        public string gautiInformacija()
        {
            return $"{Id} {Marke}, {Modelis}, Nuomos kaina: {NuomosKaina}";
        }

        


    }
    
 
}
