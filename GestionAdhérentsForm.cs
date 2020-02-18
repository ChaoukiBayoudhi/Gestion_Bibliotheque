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
    public partial class GestionAdhérentsForm : Form
    {
        public GestionAdhérentsForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        Adhérent _bindedObject = new Adhérent();//{ Nom = "Initialized value"};
        private void GestionAdhérentsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Adhérent ad = new Adhérent();
                ad.Id = int.Parse(txt_Id.Text);
                ad.Nom = txt_Name.Text;
                ad.DateNaiss = dtp_BirthDay.Value;
                
                bool res=Form1.OurBib.EnsembleAdhérents.Add(ad);
                if (!res)
                    throw new Exception("L'adhérent existe déjà\n  Verifier Id");
                MessageBox.Show("Adhérent ajouté avec succés...");
                //update the dataGridView's Content
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Form1.OurBib.EnsembleAdhérents.lstAdhérents;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
