using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_BryanDeCarlo_GestioneArticoli
{
    public class Dettagliarticolo
    {
        string codice;
        string descrizione;
        string unitaMisura;
        double prezzo;


        public Dettagliarticolo(string codice, string descrizione, string unitaMisura, double prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
        }
        public string Codice { get { return codice; } }
        public string Descrizione { get { return descrizione; } }
        public string UnitaMisura { get { return unitaMisura; } }
        public double Prezzo { get { return prezzo; } }




        public partial class Form1 : Form
    {

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
