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
    public partial class Form_login : UserControl
    {
        Control_click click = new Control_click();
        
        bool value = false;
        String usr, p, pp,psw;
        
        public Form_login()
        {
            InitializeComponent();
          //  menuToolStripMenuItem.Enabled = false;
        }

        private void btn_conect_Click(object sender, EventArgs e)
        {
               value = click.connect(zone_username.Text.Trim().ToString(),zone_passw.Text.Trim().ToString());
               psw = click.getPass();
            String usr = zone_username.Text.Trim();
               if (value)
               {
                   if((usr.Equals("ibrahima")) && psw.Equals("ibrahima"))
                   {
                       click.updatePass();
                       panel_inscrit.Show();

                       btn_conect.Enabled = false;
                   }
                   else
                   {
                    Class_Global.myGlobal= true;
                    MessageBox.Show("connexion reussie");
                    zone_passw.Text = "";
                    zone_username.Text = "";
                    
                    btn_conect.Enabled = false;
                   }
               }
               else

                    {
                       
                        MessageBox.Show("erreur connexion");
                    }
        }

        private void btn_inscrit_Click(object sender, EventArgs e)
        {
            usr = zone_user_ins.Text; 
            p = zone_pass_ins.Text;
            pp = zone_pass_ins2.Text;

            value = click.add_admin(usr, p, pp);

            if(value)
            {
                panel_inscrit.Hide();
                btn_conect.Enabled = true;
            }


        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            panel_inscrit.Hide();
            click.Password(zone_passw);
            click.Password(zone_pass_ins);//inscr
            click.Password(zone_pass_ins2);//inscr confirm
        }

        public void enableMenu(ToolStripMenuItem menu,bool b)
        {
           // 
            if(b)
            {
             
                menu.Enabled = true;
            }
            else
            {
                menu.Enabled = false;
            }
          
        }
    }
}
