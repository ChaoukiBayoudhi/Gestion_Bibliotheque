using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpGestionBibliothèque
{
    public partial class Form1 : Form
    {
        static internal Bibliothèque OurBib = new Bibliothèque();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_GestionLivres_Click(object sender, EventArgs e)
        {
            GestionLivresForm f1 = new GestionLivresForm();
            f1.Show();
        }

        private void bt_GestionAdhérents_Click(object sender, EventArgs e)
        {
            GestionAdhérentsForm f1 = new GestionAdhérentsForm();
            f1.Show();
        }

        private void bt_GestionEmprunts_Click(object sender, EventArgs e)
        {
            GestionEmpruntsForm f1 = new GestionEmpruntsForm();
            f1.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var response = MessageBox.Show(
        "Close Confirmation",
        "Would you really close the window?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (response == DialogResult.No);
        }
    }
}
