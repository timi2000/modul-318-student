using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportGui
{
    public partial class fahrplan : Form
    {
        public fahrplan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void AbfahrtsOrtWählen_DropDown(object sender, EventArgs e)
        {
            if (AbfahrtsOrtWählen.Text.Count() > 2)
             {

                string suche = AbfahrtsOrtWählen.Text + ",";


                ITransport tran = new Transport();
                var stations = tran.GetStations(suche);
                //  comboBox2.Items.Clear();

                AbfahrtsOrtWählen.Items.Clear();

                foreach (Station s in stations.StationList)
                {
                    
                    AbfahrtsOrtWählen.Items.Add(s.Name);

                }
                //comboBox2.DataSource = stations.StationList;
                //comboBox2.DisplayMember = "Name";

                AbfahrtsOrtWählen.Select(AbfahrtsOrtWählen.Text.Length, 1);
            }
        }

        private void Abfahrtstafel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerbindungenSuchen_Click(object sender, EventArgs e)
        {
            
            
            string station = AbfahrtsOrtWählen.Text;
            string id = AbfahrtsOrtWählen.Text;

            ITransport AnschlussOrt = new Transport();
            StationBoardRoot anschlüsse = AnschlussOrt.GetStationBoard(station, id);

            Abfahrtstafel.Items.Clear();

            foreach (StationBoard s in anschlüsse.Entries)
            {
                
                Abfahrtstafel.Items.Add("Abfahrt Zeit: " +"\t" + s.Stop.Departure.ToString("g")+ "\t" + " (" +  s.Name +")" + "\t" + s.To);

            }
            /*  Abfahrtstafel.Items.Clear();
              for (int i = 0; i < anschlüsse.GetStationBoard.Count; i++)
              {
                  DateTime departureDate = Convert.ToDateTime(connections.ConnectionList[i].From.Departure);
                  DateTime arriveDate = Convert.ToDateTime(connections.ConnectionList[i].To.Arrival);
                  string[] durTime = connections.ConnectionList[i].Duration.Split('d')[1].Split(':');
                  string hours = durTime[0];
                  string minutes = durTime[1];

                  string eintrag = "Abfahrt auf Gleis: " + connections.ConnectionList[i].From.Platform;
                  eintrag += "\t" + "um: " + departureDate.ToShortTimeString();
                  eintrag += "\t" + "Abfahte auf Station: " + connections.ConnectionList[i].From.Station.Name;
                  eintrag += "\t" + "Ankunft: " + arriveDate.ToShortTimeString();
                  eintrag += "\t" + "Dauer: " + hours + ":" + minutes;
                  Verbindungen.Items.Add(eintrag);
              }*/
        }
    }
}
