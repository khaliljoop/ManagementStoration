using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStorage
{
    class Produit
    {

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khalil\source\repos\ManagementStorage\StockPr.accdb");
        OleDbCommand command, cmd2;
        OleDbDataAdapter adapter;
        //DataSet dataset;
        OleDbDataReader reader;

        public void insertProduit(String nom, int prix, int qte)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produit(designation,prix,stock) values('" + nom + "'," + prix + "," + qte + ")";
            int v = command.ExecuteNonQuery();
            
            if (v > 0)
            {

                MessageBox.Show("vous avez ajoute le produit  " + nom);

            }
            else
            {
                MessageBox.Show("erreur insertion");
            }
            connection.Close();
        }

        

        public void modifierP(string nom, int prix, int qte, int id)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update produit set designation='" + nom + "',prix=" + prix + ",stock=" + qte + " where produitID =" + id;
            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {

                MessageBox.Show("modification reussie");
            }
            else
            {
                MessageBox.Show("erreur de modification");
            }
            connection.Close();
        }


        public void modifierf(int qte,String designation, int prix,int pt,String nm)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update facture set QUANTITE='"+qte+"', DESIGNATION='" + designation + "',PU=" + prix + ",prixTotal="+pt+" where DESIGNATION='"+nm+"'";
            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {

                MessageBox.Show("modification reussie");
            }
            else
            {
                MessageBox.Show("erreur de modification");
            }
            connection.Close();
        }

      
        public void supprimerP(int id_pro)
        {
                connection.Open();
                cmd2 = connection.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete from produit where produitID=" + id_pro;

                int r = cmd2.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("suppression reussie");
                }
                connection.Close();
                // 
           
        }

        public void recherche_pro(string word, DataGridView view)
        {
            connection.Open();

            String query = "select * from produit where designation like '%" + word + "%'";
            command = new OleDbCommand(query, connection);

            adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            view.DataSource = dt;


            connection.Close();

        }

         public int exist_produit(string m)
     {

            int res = 0;

            connection.Open();
            command = connection.CreateCommand();
           command.CommandType = CommandType.Text;
            command.CommandText = "select * from produit where designation='" + m + "'";

            res = command.ExecuteNonQuery();

            /*reader = command.ExecuteReader();

            while(reader.HasRows)
               {

                   if (reader.Read())
                   {
                       designation = reader.GetString(0);
                       if (m==designation)
                       {
                           res = 1;
                       }


                   }
                   reader.NextResult();
               }
            */


            connection.Close();
         return res;

     }

       
            public bool getProduitName (string des)
            {
            bool b = false;
                try
                {
                        string req = "select designation from produit ";
                        string nom = "";

                        command = new OleDbCommand(req, connection);
                        connection.Open();
                    
                    using (var r = command.ExecuteReader())
                    {
                        foreach (DbDataRecord s in r)
                        {
                            nom = s.GetString(0);
                            if (nom.Equals(des))
                                b = true;
                            Console.WriteLine("designation : "+nom);
                        }
                    }
                    connection.Close();
                }
                catch
                {

                }
                return b;

            }


            public void LOADP(DataGridView view)
        {
            String query = "select * from produit";
            command = new OleDbCommand(query, connection);
            connection.Open();

            adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            
            adapter.Fill(dt);
            view.DataSource = dt;


            connection.Close();

           
        }

        public void risk_stock(DataGridView view)
        {
            int qte = 5;

            foreach (DataGridViewRow row in view.Rows)
            {
                foreach (DataGridViewCell cells in row.Cells)
                {

                    if (cells.Value != null)
                    {

                        qte = Convert.ToInt32(row.Cells[3].Value.ToString());


                    }
               

                }
               
                if (qte < 5)
                {
                    
                    row.DefaultCellStyle.BackColor = Color.Red;
                 
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }

            }
        }

    }
}
