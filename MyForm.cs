using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStorage
{
    public partial class MyForm : Form
    {
        Form_login log = new Form_login();
        Control_click click = new Control_click();
        
        public MyForm()
        {
            InitializeComponent();
            
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            ajouterCategorieToolStripMenuItem.Enabled = false;
            ajouterProduitToolStripMenuItem.Enabled = false;
            enregistrerVenteToolStripMenuItem.Enabled = false;
            // log.enableMenu(menuToolStripMenuItem,click.variable);
            form_accueil1.Show();
            form_login1.Hide();
            
            form_produit1.Hide();
            form_vente1.Hide();
            form_releve1.Hide();
            click.Button_Enable(btn_releve, 0);
        }

        private void ajouterCategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            form_accueil1.Hide();
            form_login1.Hide();
            form_produit1.Hide();
            form_vente1.Hide();
            form_releve1.Hide();
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_accueil1.Hide();
            form_login1.Hide();
            form_produit1.Show();
            form_vente1.Hide();
            form_releve1.Hide();
        }

        private void enregistrerVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_accueil1.Hide();
            form_login1.Hide();
         
            form_produit1.Hide();
            form_vente1.Show();
            form_releve1.Hide();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (click.variable)
            {
                log.enableMenu(menuToolStripMenuItem,true);
            }
            form_accueil1.Show();
            form_login1.Hide();
            form_produit1.Hide();
            form_vente1.Hide();
            form_releve1.Hide();
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_accueil1.Hide();
            form_login1.Show();
            form_produit1.Hide();
            form_vente1.Hide();
            form_releve1.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEnable(Class_Global.myGlobal);
        }

        public void MenuEnable(bool b)
        {
            if(b)
            {
                ajouterCategorieToolStripMenuItem.Enabled = true;
                ajouterProduitToolStripMenuItem.Enabled = true;
                enregistrerVenteToolStripMenuItem.Enabled = true;
                click.Button_Enable(btn_releve,1);
                
            }

        }

        private void btn_releve_Click(object sender, EventArgs e)
        {
            form_accueil1.Hide();
            form_login1.Hide();
            form_produit1.Hide();
            form_vente1.Hide();
            form_releve1.Show();
        }

        private void btn_stock_global_Click(object sender, EventArgs e)
        {
            form_accueil1.Hide();
            form_login1.Hide();
            form_produit1.Show();
            form_vente1.Hide();
            form_releve1.Hide();
        }
    }
}
