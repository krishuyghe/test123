using System;
using System.Collections.Generic;
using System.Text;

namespace ARS.Lib
{
    public class Report
    {
        public ReportInfo report_Gegevens;
        public Persoon rapporteerder;
        public Accident omschrijving_Acc;
        public Mens menselijke_schade;
        public Materieel materiele_schade;
        public Bijlage bijlage;
        public int Id; 
    }
}
