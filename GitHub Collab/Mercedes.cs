using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub_Collab
{
    public class Mercedes
    {
        public string navn { get; set; }
        public int årgang{ get; set; }
        public string Model { get; set; }
        public string Farve { get; set; }

        public Mercedes(string navn, int årgang, string Model, string Farve)
        {
            navn = navn;
            årgang = årgang;
            Model = Model;
            Farve = Farve;
        }

    }
}
