using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub_Collab
{
    public class Audi
    {
        public string Navn { get; set; }
        public string Model { get; set; }
        public int Årgang { get; set; }
        public double Pris { get; set; }
        
        public Audi(string navn, string model, int årgang, double pris)
        {
            Navn = navn;
            Model = model;
            Årgang = årgang;
            Pris = pris;
        }

        public override string ToString()
        {
            return $"Navn: {Navn}\n" +
                $"Model: {Model}\n" +
                $"Årgang {Årgang}\n" +
                $"Pris {Pris}";

        }
        
    }
}
