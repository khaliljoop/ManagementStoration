using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStorage
{
    class Control_click
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khalil\source\repos\ManagementStorage\StockPr.accdb");
        OleDbCommand command;
       // OleDbDataAdapter adapter;
        OleDbDataReader reader;
        //  DataSet dataset;
       public  bool variable = false;
        public void Button_Enable(Button button,int id)
        {
            if (id == 0)
            {
                button.Enabled = false;
    
            }
            else
            {
                button.Enabled = true;
         
            }
        }

        public bool connect(String us,String pss)
        {
            String username="defr",pw="ffg";

            string req = "select username,mdp from admin";
            bool b = false;
            int i = 0;
            command = new OleDbCommand(req, connection);
            connection.Open();
            // int v = command.ExecuteNonQuery();
            reader = command.ExecuteReader();

            while (reader.HasRows)
            {

                i++;

                while(reader.Read())
                {
                    username = reader.GetString(0);
                    pw = reader.GetString(1);

                    if (us.Equals(username) && pss.Equals(pw))
                    {
                        b = true;
                    }
                }


                reader.NextResult();
            }
            reader.NextResult();
            //MessageBox.Show(" nbre i " + i);

            connection.Close();
            

            return b;
        }

        public void updatePass()
        {
             String pass = "diop000123";
            int id = 1;

            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update admin set mdp='" + pass + "' where adminID=" + id;
            int v = command.ExecuteNonQuery();
            connection.Close();
           
            if(v>0)
            {
                MessageBox.Show("Une mise à jour effectuee vous ne pouvez plus utiliser la connection par defaut");
            }
            connection.Close();
        }

        public bool add_admin(String usr, String p, String pp)
        {
            bool value = false;
            if ((usr.Trim().Equals("")) || (p.Trim().Equals("")) || (pp.Trim().Equals("")))
            {
                
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {

                if (p.Equals(pp))
                {
                    value = true;

                    command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    command.CommandText = "insert into admin (username,mdp) values('" + usr + "', '" + p + "' )";
                    int v = command.ExecuteNonQuery();
                    connection.Close();
                    if (v > 0)
                    {
                        MessageBox.Show("inscription reussi");
                    }
                    else
                    {
                        value = false;
                        MessageBox.Show("Erreur d'inscription");
                    }

                }
                else
                {
                    MessageBox.Show("Les deux password ne correspondent pas");
                }
            }        
           

            return value;
        }


        public String getPass()
        {
            string req = "select mdp from admin where adminID="+1;
            String pp = "";
            command = new OleDbCommand(req, connection);
            connection.Open();
            // int v = command.ExecuteNonQuery();
            reader = command.ExecuteReader();

            if (reader.Read())
            {

                pp = reader.GetString(0);

            }


            connection.Close();

            return pp;
        }

        public void Password(TextBox box)
        {
            box.Text = "";
            box.PasswordChar = '*';
            box.MaxLength = 12;
        }
        
    }
}
