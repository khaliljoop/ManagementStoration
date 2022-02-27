using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.html.simpleparser;
using System.Runtime.InteropServices;

namespace ManagementStorage
{
    public partial class Form_vente : UserControl
    {
        Control_click control = new Control_click();
        Exportation exp = new Exportation();
        Produit produit = new Produit();
        Ventes ventes = new Ventes();

        int id = 0,indexRow, quantite,qte=-1, qte_prod,restant,pu, prixT;
        String client, tel, etat, designation, produitName;

        public Form_vente()
        {
            InitializeComponent();
            control.Button_Enable(btn_update, id);
        }
        private void zone_qte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void zone_telcli_KeyPress(object sender, KeyPressEventArgs e)
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

        private void zone_nomcli_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_valide_imp_Click(object sender, EventArgs e)
        {
            string chaine = zone_telcli.Text;
           
            if (chaine=="")
                chaine = "non renseigné";
          if(select_etat.SelectedItem!=null && zone_nomcli.Text!="")
            {
                string etat = select_etat.SelectedItem.ToString();
                insert_datagrid_to_releve(dataGridView_vente,chaine,zone_nomcli.Text,etat);
                exp.ExportToPdf(dataGridView_vente, zone_nomcli.Text, chaine, etat);
                zone_nomcli.Text = "";
                zone_prix.Text = "";
                zone_qte.Text = "";
                zone_telcli.Text = "";
               ventes.vider_facture();
               ventes.charge_datagrid_facture(dataGridView_vente);

                panel_valide_imp.Visible = false;
                control.Button_Enable(btn_save,1);
                control.Button_Enable(btn_print, 1);

            }
          else
            {
                MessageBox.Show("Client et etat sont obligatoire");
            }
        }

        private void select_etat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           // MessageBox.Show("salut");
        }

      
       

        private void Form_vente_Load(object sender, EventArgs e)
        {
            dataGridView_vente.AllowUserToAddRows = false;
           
            panel_valide_imp.Hide();
            ventes.remplirCombobox_pro(select_pro);
       
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            if(zone_prix.Text!="" && zone_qte.Text!="")
            {
                qte = Convert.ToInt32(zone_qte.Text);
                pu = Convert.ToInt32(zone_prix.Text);
            }
            if ((select_pro.SelectedItem != null) && (qte >0))
            {
                produitName = select_pro.SelectedItem.ToString();
               
                qte_prod = ventes.getQte(produitName);
              
                if (pu > 0 && qte_prod > 0)
                {
                    restant = qte_prod - qte;
                    if (restant >= 0)
                    {
                     
                        prixT = pu * qte;
                       
                        ventes.insertVente_fat( qte, produitName, pu, prixT);
             
                        ventes.charge_datagrid_facture(dataGridView_vente);
                    }
                    else
                    {
                        MessageBox.Show("quantite restante pour ce produit est " + qte_prod);
                    }



                }
                else
                {
                    MessageBox.Show("erreur sur le prix");
                }
            }
            else
            {
                MessageBox.Show("Verifier les champs");
            }
            panel_vente.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (zone_prix.Text != "" && zone_qte.Text != "")
            {
                qte = Convert.ToInt32(zone_qte.Text);
                pu = Convert.ToInt32(zone_prix.Text);
            }
            if ((select_pro.SelectedItem != null) && (qte >0))
            {
                produitName = select_pro.SelectedItem.ToString();

                qte_prod =ventes.getQte(produitName);

                if (pu > 0 && qte_prod > 0)
                {
                    restant = qte_prod - qte;
                    if (restant >= 0)
                    {

                        prixT = pu * qte;

                        if (select_pro.SelectedItem != null)
                            designation = select_pro.SelectedItem.ToString();
                        produit.modifierf(qte, designation, pu, prixT,designation);


                        ventes.charge_datagrid_facture(dataGridView_vente);
                    }
                    else
                    {
                        MessageBox.Show("quantite restante pour ce produit est " + qte_prod);
                    }



                }
                else
                {
                    MessageBox.Show("erreur sur le prix");
                }
            }
            else
            {
                MessageBox.Show("Verifier les champs");
            }
            
            panel_vente.Show();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            control.Button_Enable(btn_save,0);
            control.Button_Enable(btn_update,0);
            btn_print.Enabled = false;
            panel_valide_imp.Show();
           
        }

        public void insert_datagrid_to_releve(DataGridView v,string client,string tel,string etat)
        {
            int qte=0;
            string des="";
            int pu=0;
            int pt=0;
            foreach (DataGridViewRow row in v.Rows)
            {
                foreach (DataGridViewCell cells in row.Cells)
                {
                    
                    if (cells.Value != null)
                    {
                        
                      
                            qte= Convert.ToInt32(row.Cells[0].Value.ToString());
                            des = row.Cells[1].Value.ToString();
                            pu= Convert.ToInt32(row.Cells[2].Value.ToString());
                            pt= Convert.ToInt32(row.Cells[3].Value.ToString());
                        
                    }

                }
                if (qte>0)
                {
                    ventes.insertReleve(client,tel,etat , qte,des,pu,pt,DateTime.Now);

                }

            }
        }
        private void dataGridView_vente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView_vente.Rows[indexRow];
                id = indexRow+1; //  
                client=row.Cells[0].Value.ToString();
                tel= row.Cells[1].Value.ToString();
              //  etat= row.Cells[2].Value.ToString();
                quantite = Convert.ToInt32(row.Cells[3].Value.ToString());
                designation= row.Cells[4].Value.ToString();
                pu = Convert.ToInt32(row.Cells[5].Value.ToString());
                zone_qte.Text = quantite.ToString();
                zone_prix.Text = pu.ToString();
                control.Button_Enable(btn_update, id);
            }
            catch
            {

            }
        }
    }
}
