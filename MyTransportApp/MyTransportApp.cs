using SwissTransport.Core;
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
            var verbindungen = transport.GetConnections(StartortTextBox.Text, ZielortTextBox.Text);
            for (int i = 0; i < 4; i++)
            {
                VerbindungenGridView.Rows.Add(new String[]
                {
                    verbindungen.ConnectionList[i].From.Departure.ToString(),
                    verbindungen.ConnectionList[i].To.Arrival.ToString(),
                    verbindungen.ConnectionList[i].Duration.ToString(),
                    verbindungen.ConnectionList[i].From.Platform.ToString(),
                });
            }
        }
    }
}
