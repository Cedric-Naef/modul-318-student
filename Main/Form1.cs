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

namespace Main
{
    public partial class Form1 : Form
    {
        string StartBahnhof = null;
        string EndBahnhof = null;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListAusgabe.Items.Clear();

            StartBahnhof = textBoxVon.Text;
            EndBahnhof = textBoxBis.Text;

            if (string.IsNullOrEmpty(StartBahnhof))
            {
                //Meldung, das keine Station ausgewählt wurde, einschalten
                LableWarnung.Visible = true;
            }
            else if (string.IsNullOrEmpty(EndBahnhof))
            {
                //Verbindungen von Start Station aus anzeigen
                ListAusgabe.Items.Add("Verbindungen von " + StartBahnhof);
            }
            else
            {
                //Verbindungen anzeigen
                ListAusgabe.Items.Add("Von " + StartBahnhof + " nach " + EndBahnhof);
                
            }
        }

        private void textBoxVon_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxVon.Text))
            {
                //Meldung, dass das Feld nicht leer sein darf anzeigen
                LableWarnung.Visible = true;
            }
            else
                LableWarnung.Visible = false;
        }
    }
}