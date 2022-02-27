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
    public partial class form_produit : UserControl
    {
        int id =0,indexRow,prixU,quantite;
        Produit produit = new Produit();
        Control_click click = new Control_click();
        public form_produit()
        {
            InitializeComponent();
            dataGridView_produit.AllowUserToAddRows = false;
            produit.risk_stock(dataGridView_produit);
            dataGridView_produit.AllowUserToDeleteRows = false;
            dataGridView_produit.AllowUserToDeleteRows = false;
           


        }

        private void form_produit_Load(object sender, EventArgs e)
        {
            click.Button_Enable(btn_update, id);
            click.Button_Enable(btn_delete, id);
            produit.risk_stock(dataGridView_produit);
            produit.LOADP(dataGridView_produit);
            panel_stock.Visible = false;
            btn_fermer.Visible = false;
            zone_nomp.Text = "";
            zone_prixp.Text = "";
            zone_qtep.Text = "";

        }

        private void btn_savep_Click(object sender, EventArgs e)
        {
            
            bool b = false;

            if(zone_nomp.Text == "")
            {
                b = false;
            }
            else
            {
                b = true;
            }

            if(zone_prixp.Text!="")
            {
                b = true;
                prixU = Convert.ToInt32(zone_prixp.Text);
            }
            else
            {
                b = false;
            }
            if (zone_qtep.Text != "")
            {
                b = true;
                quantite = Convert.ToInt32(zone_qtep.Text);
            }
            else
            {
                b = false;
            }
            
            if(b)
            {
                bool a=produit.getProduitName(zone_nomp.Text);
                if(a==false)
                {
                    produit.insertProduit(zone_nomp.Text, prixU, quantite);
                    produit.LOADP(dataGridView_produit);
                    zone_nomp.Text = "";
                    zone_prixp.Text = "";
                    zone_qtep.Text = "";
                }
                else
                {
                    MessageBox.Show("Le produit "+zone_nomp.Text+" existe déj'à");
                }
              
            }
            else
            {
                MessageBox.Show("verifier les champs");
            }
            
        }

        private void zone_qtep_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void zone_prixp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void zone_nomp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void zone_searchp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_affiche_Click(object sender, EventArgs e)
        {
            panel_stock.Visible = true;
            btn_affiche.Enabled = false;
            btn_fermer.Visible = true;
            produit.risk_stock(dataGridView_produit);
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            panel_stock.Visible = false;
            btn_affiche.Enabled = true;
            btn_fermer.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
             

            if (id!=0)
            {

               
                    produit.modifierP(zone_nomp.Text, Convert.ToInt32(zone_prixp.Text), Convert.ToInt32(zone_qtep.Text), id);
                    produit.LOADP(dataGridView_produit);
                    zone_nomp.Text = "";
                    zone_prixp.Text = "";
                    zone_qtep.Text = "";
             
            }
            produit.risk_stock(dataGridView_produit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(id!=0)
            {
                produit.supprimerP(id);
                produit.LOADP(dataGridView_produit);
                produit.risk_stock(dataGridView_produit);
            }
            else
            {
                MessageBox.Show("selectionner un produit");
            }
        }

        private void dataGridView_produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView_produit.Rows[indexRow];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                zone_nomp.Text = row.Cells[1].Value.ToString();
                zone_prixp.Text = row.Cells[2].Value.ToString();
                zone_qtep.Text = row.Cells[3].Value.ToString();

                click.Button_Enable(btn_savep,0);
                click.Button_Enable(btn_update, e.RowIndex+1);
                click.Button_Enable(btn_delete, e.RowIndex + 1);
                produit.risk_stock(dataGridView_produit);
            }
            catch
            {
                click.Button_Enable(btn_savep, 1);
                click.Button_Enable(btn_update,0);
                click.Button_Enable(btn_delete,0);
                zone_nomp.Text = "";
                zone_prixp.Text = "";
                zone_qtep.Text = "";
                produit.risk_stock(dataGridView_produit);

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(zone_searchp.Text!="")
            {
                produit.recherche_pro(zone_searchp.Text,dataGridView_produit);
            }
            else
            {
                MessageBox.Show("taper nom du produit");
            }
            produit.risk_stock(dataGridView_produit);
        }
    }
}
