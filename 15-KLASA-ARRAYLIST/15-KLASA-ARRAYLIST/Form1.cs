using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _15_KLASA_ARRAYLIST
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            IsključiKontrole();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            UključiKontrole();
            textBoxNovi.Clear();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(textBoxNovi.Text);
            listaAutomobila.Add(a);
            richTextBox1.AppendText((listaAutomobila.IndexOf(a) + 1) + ". " + a.DajMarku() + "\n");
            IsključiKontrole();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            listaAutomobila.Clear();
            richTextBox1.Clear();
        }
        private void IsključiKontrole()
        {
            textBoxNovi.Enabled = false;
            buttonUnesi.Enabled = false;
        }

        private void UključiKontrole()
        {
            textBoxNovi.Enabled = true;
            buttonUnesi.Enabled = true;
        }
        class Automobil

        {

            private string marka;

            public Automobil(string m)

            {

                marka = m;

            }

            public string DajMarku()

            {

                return marka;

            }

        }
    }
}
