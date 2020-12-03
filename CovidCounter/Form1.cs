using CovidCounter.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CovidCounter
{
    public partial class Form1 : Form
    {
        BindingList<Record> Records = new BindingList<Record>();
        public Form1()
        {
            InitializeComponent();
            CreateXML();
            dataGridView1.DataSource = Records;
        }

        void CreateXML()
        {
            var xml = new XmlDocument();
            xml.Load("Covid Cases.xml");

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rec = new Record();
                Records.Add(rec);

                var date = (XmlElement)element.ChildNodes[0];
                if (date.Name == "dateRep") { rec.Date = date.InnerText; }

                var day = (XmlElement)element.ChildNodes[1];
                if (day.Name == "day") { rec.Day = int.Parse(day.InnerText); }

                var month = (XmlElement)element.ChildNodes[2];
                if (month.Name == "month") { rec.Month = int.Parse(month.InnerText); }

                var year = (XmlElement)element.ChildNodes[3];
                if (year.Name == "year") { rec.Year = int.Parse(year.InnerText); }

                var cases = (XmlElement)element.ChildNodes[4];
                if (cases.Name == "cases") { rec.Cases = int.Parse(cases.InnerText); }

                var deaths = (XmlElement)element.ChildNodes[5];
                if (deaths.Name == "deaths") { rec.Deaths = int.Parse(deaths.InnerText); }

                var countriesAndTerritories = (XmlElement)element.ChildNodes[6];
                if (countriesAndTerritories.Name == "countriesAndTerritories") { rec.Countries = countriesAndTerritories.InnerText; }

                var geoId = (XmlElement)element.ChildNodes[7];
                if (geoId.Name == "geoId") { rec.GeoID = geoId.InnerText; }

                var countryterritoryCode = (XmlElement)element.ChildNodes[8];
                if (countryterritoryCode.Name == "countryterritoryCode") { rec.CountryCode = countryterritoryCode.InnerText; }

                var continentExp = (XmlElement)element.ChildNodes[9];
                if (continentExp.Name == "continentExp") { rec.Continent = continentExp.InnerText; }

                var Cumulative = (XmlElement)element.ChildNodes[10];
                if (Cumulative.Name == "Cumulative_number_for_14_days_of_COVID-19_cases_per_100000") { rec.Cumulative_number = double.Parse(Cumulative.InnerText); }

                //if (element == null) { continue; }
            }
        }
    }
}
