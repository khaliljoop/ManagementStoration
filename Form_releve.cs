using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStorage
{
    public partial class Form_releve : UserControl
    {
        int indexRow;
        int id = 0,qte,pu,pt;
        string client, tel, etat, designation;

        gestionReleve releve = new gestionReleve();
        Ventes ventes = new Ventes();

        private void select_etat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form_releve()
        {
            InitializeComponent();
            dataGridView_releve.AllowUserToAddRows = false;
        }

        private void Form_releve_Load(object sender, EventArgs e)
        {
            releve.charge_datagrid_releve(dataGridView_releve);
            ventes.remplirCombobox_pro(select_prodR);
        }

        private void dataGridView_releve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView_releve.Rows[indexRow];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                zone_client.Text = row.Cells[1].Value.ToString();
                zone_tel.Text = row.Cells[2].Value.ToString();
                etat= row.Cells[3].Value.ToString();
                zone_quantite.Text= row.Cells[4].Value.ToString();
                designation = row.Cells[5].Value.ToString();
                zone_pu.Text= row.Cells[6].Value.ToString();
                

            }
            catch
            {

            }
            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            releve.modifierReleve(zone_client.Text,zone_tel.Text,etat, Convert.ToInt32(zone_quantite.Text), designation,Convert.ToInt32(zone_pu.Text),pt,DateTime.Now,id);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            releve.recherche(zone_search.Text,dataGridView_releve);
        }
    }
}
