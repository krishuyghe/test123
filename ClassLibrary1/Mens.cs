using System;
using System.Collections.Generic;
using System.Text;

namespace ARS.Lib
{
    public class Letsel
    {
        public bool Hoofd { get; set; }
        public bool Nek { get; set; }
        public bool Linkerarm { get; set; }
        public bool Rechteram { get; set; }
        public bool Linkerhand { get; set; }
        public bool Rechterhand { get; set; }
        public bool Romp { get; set; }
        public bool Linkerbeen { get; set; }
        public bool Rechterbeen { get; set; }
        public bool Linkervoet { get; set; }
        public bool Rechtervoet { get; set; }
        public int Id { get; set; }
    }
    public class Mens 
    {
        public Persoon Persoon { get; set; }
        public Letsel Letsel { get; set; }
        public string Omschrijving { get; set; }
        public int Id { get; set; }
    }
}
