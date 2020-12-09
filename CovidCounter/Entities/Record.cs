using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCounter.Entities
{
    class Record
    {
        private int _cases;

        public string Date { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Cases
        {
            get { return _cases; }
            set
            {
                if (value >= 150000) { _cases = 150000; }
                else if (value < 11) { _cases = 0; }
                else { _cases = value; }
            } 
        }
        public int Deaths { get; set; }
        public string Countries { get; set; }
        public string GeoID { get; set; }
        public string CountryCode { get; set; }
        public string Continent { get; set; }
        public string CumulativeNumber { get; set; }
        //Kummulált érték 2 heti esetszám alpján 100 000 főre nézve 
    }
}
