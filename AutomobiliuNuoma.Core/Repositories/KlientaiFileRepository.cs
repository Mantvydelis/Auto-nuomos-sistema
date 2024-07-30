using AutomobiliuNuoma.Core.Contracts;
using AutomobiliuNuoma.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobiliuNuoma.Core.Repositories
{
    public class KlientaiFileRepository : IKlientaiRepository
    {
        private readonly string _filePath;
        public KlientaiFileRepository(string klientaiFilePath)
        {
            _filePath = klientaiFilePath;
        }

        public void IrasytiKlientus(List<Klientas> klientai)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, false))
            {
                foreach (Klientas klientas in klientai)
                {
                    sw.WriteLine($"{klientas.Vardas},{klientas.Pavarde},{klientas.GimimoMetai:yyyy-MM-dd}");
                }
            }
        }

        public List<Klientas> GautiVisusKlientus()
        {
            List<Klientas> klientai = new List<Klientas>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    if (values.Length == 3) // Ensure correct number of values
                    {
                        klientai.Add(new Klientas(values[0], values[1], DateOnly.Parse(values[2])));
                    }
                }
            }
            return klientai;
        }

        public void PridetiKlienta(Klientas klientas)
        {
            string klientasLine = $"{klientas.Vardas},{klientas.Pavarde},{klientas.GimimoMetai:yyyy-MM-dd}";
            File.AppendAllLines(_filePath, new[] { klientasLine });
        }
    }

}
