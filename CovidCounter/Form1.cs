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
using System.Xml;
using System.Xml.Linq;

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

                //if (cases.InnerText == "0") { continue; }
            }
        }

        /*void Refresh()
        {
            Records.Clear();

        }*/

        void SaveCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File |*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                string delimiter = ",";

                XDocument.Load(@"D:\Suli\Tananyag\V. félév\IRF\Gyak\Beadando\CovidCounter\Covid Cases.xml").Descendants("record").ToList().ForEach(
                    element => sb.Append(element.Element("dateRep").Value + delimiter +
                                         element.Element("cases").Value + delimiter +
                                         element.Element("deaths").Value + delimiter +
                                         element.Element("countriesAndTerritories").Value + delimiter +
                                         element.Element("countryterritoryCode").Value + delimiter +
                                         element.Element("continentExp").Value + "\r\n"));

                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCSV();
        }
    }
}
