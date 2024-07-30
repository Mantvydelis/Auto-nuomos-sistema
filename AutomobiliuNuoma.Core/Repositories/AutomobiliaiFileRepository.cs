using AutomobiliuNuoma.Core.Contracts;
using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Repositories
{
    public class AutomobiliaiFileRepository : IAutomobiliaiRepository
    {
        private readonly string _filePath;
        public AutomobiliaiFileRepository(string autoFilePath)
        {
            _filePath = autoFilePath;
        }

        public List<Automobilis> NuskaitytiAutomobilius()
        {
            List<Automobilis> automobiliai = new List<Automobilis>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    if (values.Length == 5)
                    {
                        automobiliai.Add(new NaftosKuroAutomobilis(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), int.Parse(values[4])));
                        
                    }
                    else
                    {
                        automobiliai.Add(new Elektromobilis(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
                    }

                   
                }

            }
            return automobiliai;
        }

        public void IrasytiAutomobilius(List<Automobilis> automobiliai)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                foreach (Automobilis automobilis in automobiliai)
                {
                    if (automobilis is NaftosKuroAutomobilis naftosKuroAutomobilis)
                    {
                        sw.WriteLine($"{naftosKuroAutomobilis.Id},{naftosKuroAutomobilis.Marke},{naftosKuroAutomobilis.Modelis},{naftosKuroAutomobilis.NuomosKaina},{naftosKuroAutomobilis.DegaluSanaudos}");
                    }
                    else if (automobilis is Elektromobilis elektromobilis)
                    {
                        sw.WriteLine($"{elektromobilis.Id},{elektromobilis.Marke},{elektromobilis.Modelis},{elektromobilis.NuomosKaina},{elektromobilis.BaterijosTalpa},{elektromobilis.KrovimoLaikas}");
                    }
                }

            }
        }


    }
}
