using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void zoekknop_Click(object sender, EventArgs e)
        {
            string locatie = ComboLoc.SelectedText;
            string datumvan = TextVan.Text;
            string datumtot = TextTot.Text;
            string activiteit = ComboZoek.SelectedText;

            try
            {
                StringBuilder queryloc = new StringBuilder();
                queryloc.Append("http://maps.google.com/maps?q=");

                if (locatie != string.Empty)
                    queryloc.Append(locatie + ",+");
                if (datumvan != string.Empty)
                    queryloc.Append(datumvan + ",+");
                if (datumtot != string.Empty)
                    queryloc.Append(datumtot + ",+");
                if (activiteit != string.Empty)
                    queryloc.Append(activiteit + ",+");

                webBrowser1.Navigate(queryloc.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Er is een fout opgetreden");
            }
        }


    }
}
