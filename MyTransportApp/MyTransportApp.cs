using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class MyTransportApp : Form
    {
        ITransport transport = new Transport();
        public MyTransportApp()
        {
            InitializeComponent();
        }

        private void VerbindungSuchenButton_Click(object sender, EventArgs e)
        {
            if (StartortTextBox.Text.Length < 1 && ZielortTextBox.Text.Length < 1)
            {
                MessageBox.Show("Geben Sie bitte einen Startort und einen Zielort ein.");
            }
            else if (StartortTextBox.Text.Length < 1)
            {
                MessageBox.Show("Geben Sie bitte einen Startort ein.");
            }
            else if (ZielortTextBox.Text.Length < 1)
            {
                MessageBox.Show("Geben Sie bitte einen Zielort ein.");
            }
            else
            {
                VerbindungenGridView.Rows.Clear();
                var verbindungen = transport.GetConnections(StartortTextBox.Text, ZielortTextBox.Text);
                for (int i = 0; i < verbindungen.ConnectionList.Count; i++)
                {
                    VerbindungenGridView.Rows.Add(new String[]
                    {
                        verbindungen.ConnectionList[i].From.Station.Name,
                        verbindungen.ConnectionList[i].To.Station.Name,
                        verbindungen.ConnectionList[i].From.Departure.Value.ToString("HH:mm"),
                        verbindungen.ConnectionList[i].To.Arrival.Value.ToString("HH:mm"),
                        verbindungen.ConnectionList[i].Duration.Substring(4),
                        verbindungen.ConnectionList[i].From.Platform
                    });
                }
                StartortTextBox.Clear();
                ZielortTextBox.Clear();
            }
        }

        private void VerbindungSuchenAbfahrtstafelButton_Click(object sender, EventArgs e)
        {
            if (StartortAbfahrtstafelTextBox.Text.Length < 1)
            {
                MessageBox.Show("Geben Sie bitte einen Startort ein.");
            }
            else
            {
                AbfahrtstafelGridView.Rows.Clear();
                string StartortId = transport.GetStations(StartortAbfahrtstafelTextBox.Text).StationList[0].Id;
                var StartortAbfahrtstafel = transport.GetStationBoard(StartortAbfahrtstafelTextBox.Text, StartortId).Entries;
                foreach (StationBoard connection in StartortAbfahrtstafel)
                {
                    string Zielort = connection.To;
                    string Abfahrt = connection.Stop.Departure.ToString("HH:mm");
                    AbfahrtstafelGridView.Rows.Add(Zielort, Abfahrt);
                }
            }
        }
    }
}
