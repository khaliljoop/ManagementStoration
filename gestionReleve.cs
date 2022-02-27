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
    class gestionReleve
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khalil\source\repos\ManagementStorage\StockPr.accdb");
        OleDbCommand command;
        OleDbDataAdapter adapter;
        OleDbDataReader reader;
        DataSet dataset;
        public void recherche(String nom ,DataGridView view)
        {
            connection.Open();

            String query = "select * from releve where client like '%" + nom + "%'";
            command = new OleDbCommand(query, connection);

            adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            view.DataSource = dt;


            connection.Close();

        }

        public void supprimerReleve(int id)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from releve where NumReleve=" + id;

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

        public void charge_datagrid_releve(DataGridView view)
        {
            String query = "select * from releve ";
            command = new OleDbCommand(query, connection);
            connection.Open();

            adapter = new OleDbDataAdapter(command);
            DataTable dts = new DataTable();
            adapter.Fill(dts);
            view.DataSource = dts;


            connection.Close();
        }

        public void insertReleve(string client, string tel, string etat, int qte, string designation, int pu, int prixtotal, DateTime date)
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            connection.Open();

            command.CommandText = "insert into releve(client,telephone,designation,quantite,pu,pt,dates) values('" +client + "', '" + tel+"','"+etat+"', " + qte + ",'"+designation+"','"+pu+"','"+prixtotal+"', '" + date + "' )";
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
        public void modifierReleve(string client, string tel, string etat, int qte, string designation,int pu, int prixtotal, DateTime date, int id)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update releve set client='" + client + "',telephone='" + tel + ",etat='"+etat+"',quantite=" + qte +",pu="+pu+",pt=" + prixtotal + ",dates='" + date + "' where NumReleve=" + id;
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

        public int getQte(String designation)
        {
            //::::::/
            int quant = -1;
            string req = "select qte from produit where designation='"+designation+"'";

            command = new OleDbCommand(req, connection);
            connection.Open();
            // int v = command.ExecuteNonQuery();
            reader = command.ExecuteReader();

            if (reader.Read())
            {

                quant = reader.GetInt32(0);

            }


            connection.Close();
            return quant;

        }

    }
}
