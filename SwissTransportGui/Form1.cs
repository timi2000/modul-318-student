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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Suchen_Click(object sender, EventArgs e)
        {
            //  var startStation = ;
            // var endStation = Station. ;
            string From = this.From.Text;
            string To = this.To.Text;

            ITransport ort = new Transport();
            var connections = ort.GetConnections(From, To);

            Verbindungen.Items.Clear();
            for (int i = 0; i < connections.ConnectionList.Count; i++)
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
            }
           
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            if (To.Text.Count() > 2)
            {

                string suche = To.Text + ",";


                ITransport tran = new Transport();
                var stations = tran.GetStations(suche);
                //  comboBox2.Items.Clear();

                To.Items.Clear();

                foreach (Station s in stations.StationList)
                {
                    //comboBox1.Items.Add("Name: " + s.Name +"X:" + s.Coordinate.XCoordinate.ToString() + " Score: " + s.Score);
                    To.Items.Add(s.Name);

                }
                //comboBox2.DataSource = stations.StationList;
                //comboBox2.DisplayMember = "Name";

                To.Select(From.Text.Length, 1);

            }

        
        }

        

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (From.Text.Count() > 2)
            {
               string suche = From.Text + ",";
                
               ITransport tran = new Transport();
               var stations = tran.GetStations(suche);

               From.Items.Clear();

                foreach (Station s in stations.StationList)
                {
                    From.Items.Add( s.Name );
                }
               
From.Select(From.Text.Length, 1);

            }
        }

        private void Fahrplan_Click(object sender, EventArgs e)
        {
            fahrplan f = new fahrplan(); //öffnet ein neues From namens fahrplan
            f.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
