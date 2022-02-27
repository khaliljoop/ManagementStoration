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
    class Ventes
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khalil\source\repos\ManagementStorage\StockPr.accdb");
        OleDbCommand command;
        OleDbDataAdapter adapter;
        OleDbDataReader reader;
        DataSet dataset;

        // int restante_qte;

        public void insertReleve(string client, string tel, string etat, int qte, string designation, int pu, int prixtotal, DateTime date)
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            connection.Open();

            command.CommandText = "insert into releve(client,telephone,etat,quantite,designation,pu,pt,dates) values('" + client + "', '" + tel + "','" + etat + "', " + qte + ",'" + designation + "'," + pu + "," + prixtotal + ", '" + date + "' )";
            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {


                // recharge();


                MessageBox.Show("vous avez ajouter une vente ");


            }
            else
            {
                MessageBox.Show("erreur insertion");
            }
            connection.Close();
        }

        public void save_client(String nom,String tel,String etat,DateTime d)
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            connection.Open();

            command.CommandText = "insert into client(nom,telephone,etat,dates) values('" + nom + "', '" + tel +"', '" + etat + "', '" + d + "' )";
            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {


                // recharge();


                MessageBox.Show("vous avez ajouter une vente ");


            }
            else
            {
                MessageBox.Show("erreur insertion");
            }
            connection.Close();
        }
        public void add_vente(int refclient, int produitid, int prixtotal, int qte, DateTime date)
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            connection.Open();

            command.CommandText = "insert into vente(clientName,tel,produitName,quantite,prixTotal,Dates) values(" + refclient + ", " + produitid + ", " + prixtotal + ", " + qte + ", '" + date + "' )";
            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {


                // recharge();


                MessageBox.Show("vous avez ajouter une vente ");


            }
            else
            {
                MessageBox.Show("erreur insertion");
            }
            connection.Close();
        }

        public void insertVente_fat(int QUANTITE, string DESIGNATION, int PU, int PT)
        {

            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            connection.Open();

            command.CommandText = "insert into facture (QUANTITE,DESIGNATION,PU,prixTotal) values(" + QUANTITE + ", '" + DESIGNATION + "', " + PU + ", " + PT + " )";
            int v = command.ExecuteNonQuery();
            if (v > 0)
            {
                MessageBox.Show("facture enregistrer");
            }
            connection.Close();

            //  connection.Close();
        }





        public void modifierVente(int refclient, int produitid, int prixtotal, int qte, DateTime date, int id)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update vente set clientID=" + refclient + ",produitID=" + produitid + ",prixTotal=" + prixtotal + ",quantite=" + qte + ",Dates='" + date + "' where venteID=" + id;
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

        public void supprimerVente(int id)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from vente where venteID=" + id;

            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {
                MessageBox.Show("suppression reussie");
            }
            else
            {
                MessageBox.Show("erreur suppression");
            }
            connection.Close();
        }

        public void vider_facture()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from facture";
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
              
                    MessageBox.Show("Merci pour l'enregistrement");
              
               
            }
            else
            {
                MessageBox.Show("Desole vous n'avez pas d'enregistrement");
            }

                connection.Close();

            }

        public void EffacerFac()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from facture";

            int v = command.ExecuteNonQuery();
            connection.Close();
            if (v > 0)
            {
                MessageBox.Show("suppression reussie");
            }
            else
            {
                MessageBox.Show("erreur suppression");
            }
            connection.Close();
        }

  

        public void recherche_vente(DateTime word, DataGridView view)
        {
            connection.Open();

            String query = "select * from vente where Dates <= '%" + word + "%'";
            command = new OleDbCommand(query, connection);

            adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            view.DataSource = dt;


            connection.Close();

        }

        public void LOADP(DataGridView view)
        {
            String query = "select * from vente order by Dates desc";
            command = new OleDbCommand(query, connection);
            connection.Open();

            adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            view.DataSource = dt;


            connection.Close();
        }

        public void charge_datagrid_facture(DataGridView view)
        {
            String query = "select * from facture ";
            command = new OleDbCommand(query, connection);
           connection.Open();

            adapter = new OleDbDataAdapter(command);
            DataTable dts = new DataTable();
            adapter.Fill(dts);
            view.DataSource = dts;


            connection.Close();
        }

        public int getQte(String des)
        {
            int quant = -1;
            try
            {
                
                string req = "select qte from produit where designation='" + des + "'";

                command = new OleDbCommand(req, connection);
                connection.Open();
                // int v = command.ExecuteNonQuery();
                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    quant = reader.GetInt32(0);

                }


                connection.Close();
                
            }
            catch
            {

            }
            return quant;

        }
   

        public void updateQte(String des, int restante_qte)
        {
            try
            {

                string query = "update produit set qte=" + restante_qte + " where designation='"+des+"'";
                command = new OleDbCommand(query, connection);
                connection.Open();
                int valu = command.ExecuteNonQuery();

                if (valu > 0)
                {
                    MessageBox.Show("une mise a jour effectuee");
                }
                else
                {
                    MessageBox.Show("quelque souci");
                }
                connection.Close();
            }catch(Exception e)
            {
                MessageBox.Show("il est probable que la quantité de votre produit est epuisée: "+e.Message);

                
            }
        }

     

        public void remplirCombobox_pro(ComboBox c)
        {
            
            command = new OleDbCommand("select designation from produit order By produitID", connection);
            adapter = new OleDbDataAdapter(command);
            dataset = new DataSet();
            adapter.Fill(dataset, "produit");
            foreach (DataRow d in dataset.Tables[0].Rows)
            {
                //// select_customer.Items.Add(d[0].ToString());
                c.Items.Add(d[0].ToString());
            }
            
        }


        public string getClient(int client)
        {
            string chaine = "", nom, prenom, tel;
            string req = "select prenom,nom,telephone from client where clientID=" + client;

            command = new OleDbCommand(req, connection);
            connection.Open();
            // int v = command.ExecuteNonQuery();
            reader = command.ExecuteReader();

            if (reader.Read())
            {

                prenom = reader.GetString(0);
                nom = reader.GetString(1);
                tel = reader.GetString(2);

                chaine = prenom + " " + nom + " " + tel;

            }


            connection.Close();
            return chaine;
        }

        public string getProduitName(String name)
        {
            string nom = "";
            string req = "select nom from produit where designation='"+name+"'";

            command = new OleDbCommand(req, connection);
            connection.Open();
            
          try
            {
                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    nom = reader.GetString(0);

                }

            }
            catch
            {
                MessageBox.Show("Erreur pour recuperer le champ designation");
            }

            connection.Close();
            return nom;
        }


    }
}
