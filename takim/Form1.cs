using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTürkiye_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "Türkiye";
            lblTakim.BackColor = Color.Red;
            lblTakim.ForeColor = Color.White;
        }

        private void btnGalatasaray_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "Galatasaray";
            lblTakim.BackColor = Color.Yellow;
            lblTakim.ForeColor = Color.Red;


        }

        private void btnBesiktas_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "besiktas";
            lblTakim.BackColor = Color.Black;
            lblTakim.ForeColor = Color.White;
        }

        private void btnFener_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "Fenerbahçe";
            lblTakim.BackColor = Color.Blue;
            lblTakim.ForeColor = Color.Yellow;
        }
    }
}
