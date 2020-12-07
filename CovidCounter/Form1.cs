using CovidCounter.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace CovidCounter
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        BindingList<Record> Records = new BindingList<Record>();
        
        public Form1()
        {
            InitializeComponent();
            CreateXML();
            DGW();
            CreateChart();
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
                rec.Date = date.InnerText;

                var day = (XmlElement)element.ChildNodes[1];
                rec.Day = int.Parse(day.InnerText);

                var month = (XmlElement)element.ChildNodes[2];
                rec.Month = int.Parse(month.InnerText);

                var year = (XmlElement)element.ChildNodes[3];
                rec.Year = int.Parse(year.InnerText);

                var cases = (XmlElement)element.ChildNodes[4];
                rec.Cases = int.Parse(cases.InnerText);

                var deaths = (XmlElement)element.ChildNodes[5];
                rec.Deaths = int.Parse(deaths.InnerText);

                var countriesAndTerritories = (XmlElement)element.ChildNodes[6];
                rec.Countries = countriesAndTerritories.InnerText;

                var geoId = (XmlElement)element.ChildNodes[7];
                rec.GeoID = geoId.InnerText;

                var countryterritoryCode = (XmlElement)element.ChildNodes[8];
                rec.CountryCode = countryterritoryCode.InnerText;

                var continentExp = (XmlElement)element.ChildNodes[10];
                rec.Continent = continentExp.InnerText;

                var Cumulative = (XmlElement)element.ChildNodes[11];
                rec.CumulativeNumber = Cumulative.InnerText;
            }
        }

        public void DGW()
        {
            var dgwIn = (from r in Records
                          select new
                          { 
                                Dátum = r.Date,
                                Ország = r.Countries,
                                Országkód = r.CountryCode,
                                Esetszám = r.Cases,
                                Halálozás_szám = r.Deaths,
                                Kummulált_érték = r.CumulativeNumber
                          }).ToList();

            dgwData.DataSource = dgwIn;
        }

        void CreateChart()
        {
            chartCases.DataSource = Records;

            var series = chartCases.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Cases";
            series.BorderWidth = 2;

            var legend = chartCases.Legends[0];
            legend.Enabled = false;

            var chartArea = chartCases.ChartAreas[0];
            chartArea.AxisX.IsReversed = true;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        void SaveCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File |*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    var result = (from r in Records
                                  where r.Countries.Contains(tBCountry.Text) && r.CountryCode.Contains(tBCountryCode.Text) &&
                                  DateTime.Parse(r.Year + "-" + r.Month + "-" + r.Day) >= dateTimePickerstart.Value &&
                                  DateTime.Parse(r.Year + "-" + r.Month + "-" + r.Day) <= dateTimePickerend.Value
                                  select r).ToList();

                    string fejlec = "Datum;Kontinens;Orszag;Orszagkod;Esetszam;Halalozas_szam";
                    sw.WriteLine(fejlec);

                    foreach (var r in result)
                    {
                        
                        string line = r.Date + ";" + r.Continent + ";" + r.Countries + ";" + r.CountryCode + ";" + r.Cases.ToString() + ";" + r.Deaths.ToString();
                        sw.WriteLine(line);
                    }
                }
            }
        }

        void Search()
        {
                var result = (from r in Records
                              where r.Countries.Contains(tBCountry.Text) && r.CountryCode.Contains(tBCountryCode.Text) &&
                              DateTime.Parse(r.Year + "-" + r.Month + "-" + r.Day) >= dateTimePickerstart.Value &&
                              DateTime.Parse(r.Year + "-" + r.Month + "-" + r.Day) <= dateTimePickerend.Value
                              select new
                              {
                                  Dátum = r.Date,
                                  Ország = r.Countries,
                                  Országkód = r.CountryCode,
                                  Esetszám = r.Cases,
                                  Halálozás_szám = r.Deaths,
                                  Kummulált_érték = r.CumulativeNumber
                              }).ToList();
                dgwData.DataSource = result;
                chartCases.DataSource = result;

                var series = chartCases.Series[0];
                series.ChartType = SeriesChartType.Line;
                series.XValueMember = "Dátum";
                series.YValueMembers = "Esetszám";
                series.BorderWidth = 2;

                var legend = chartCases.Legends[0];
                legend.Enabled = false;

                var chartArea = chartCases.ChartAreas[0];
                chartArea.AxisX.IsReversed = true;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisY.IsStartedFromZero = false;
        }

        void Reset()
        {
            tBCountry.Clear();
            tBCountryCode.Clear();
            dateTimePickerstart.Value = DateTime.Parse("2020-01-01 00:00:00");
            dateTimePickerend.Value = DateTime.Today;
            DGW();
            CreateChart();
        }

        void RandomCountry()
        {
            tBCountry.Clear();
            tBCountryCode.Clear();


            int rndNumber = rnd.Next(213);
            string[] countries = new string[214] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antigua_and_Barbuda", "Argentina", "Armenia", "Aruba",
                                                 "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize",
                                                 "Benin", "Bermuda", "Bhutan", "Bolivia", "Bonaire, Saint Eustatius and Saba", "Bosnia_and_Herzegovina", "Botswana", "Brazil", "British_Virgin_Islands", "Brunei_Darussalam",
                                                 "Bulgaria", "Burkina_Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape_Verde", "Cases_on_an_international_conveyance_Japan", "Cayman_Islands", "Central_African_Republic",
                                                 "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa_Rica", "Cote_dIvoire", "Croatia", "Cuba",
                                                 "Curaçao", "Cyprus", "Czechia", "Democratic_Republic_of_the_Congo", "Denmark", "Djibouti", "Dominica", "Dominican_Republic", "Ecuador", "Egypt",
                                                 "El_Salvador", "Equatorial_Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Falkland_Islands_(Malvinas)", "Faroe_Islands", "Fiji", "Finland",
                                                 "France", "French_Polynesia", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland",
                                                 "Grenada", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea_Bissau", "Guyana", "Haiti", "Holy_See", "Honduras",
                                                 "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Isle_of_Man", "Israel", "Italy",
                                                 "Jamaica", "Japan", "Jersey", "Jordan", "Kazakhstan", "Kenya", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos",
                                                 "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi",
                                                 "Malaysia", "Maldives", "Mali", "Malta", "Marshall_Islands", "Mauritania", "Mauritius", "Mexico", "Moldova", "Monaco",
                                                 "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nepal", "Netherlands", "New_Caledonia",
                                                 "New_Zealand", "Nicaragua", "Niger", "Nigeria", "North_Macedonia", "Northern_Mariana_Islands", "Norway", "Oman", "Pakistan", "Palestine",
                                                 "Panama", "Papua_New_Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto_Rico", "Qatar", "Romania",
                                                 "Russia", "Rwanda", "Saint_Kitts_and_Nevis", "Saint_Lucia", "Saint_Vincent_and_the_Grenadines", "San_Marino", "Sao_Tome_and_Principe", "Saudi_Arabia", "Senegal", "Serbia",
                                                 "Seychelles", "Sierra_Leone", "Singapore", "Sint_Maarten", "Slovakia", "Slovenia", "Solomon_Islands", "Somalia", "South_Africa", "South_Korea",
                                                 "South_Sudan", "Spain", "Sri_Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan",
                                                 "Thailand", "Timor_Leste", "Togo", "Trinidad_and_Tobago", "Tunisia", "Turkey", "Turks_and_Caicos_islands", "Uganda", "Ukraine", "United_Arab_Emirates",
                                                 "United_Kingdom", "United_Republic_of_Tanzania", "United_States_of_America", "United_States_Virgin_Islands", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Wallis_and_Futuna",
                                                 "Western_Sahara", "Yemen", "Zambia", "Zimbabwe"};
            string rndCountry = countries[rndNumber];

            var result = (from r in Records
                          where r.Countries.Contains(rndCountry)
                          select new
                          {
                              Dátum = r.Date,
                              Ország = r.Countries,
                              Országkód = r.CountryCode,
                              Esetszám = r.Cases,
                              Halálozás_szám = r.Deaths,
                              Kummulált_érték = r.CumulativeNumber
                          }).ToList(); ;
            dgwData.DataSource = result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCSV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomCountry();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
