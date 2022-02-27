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
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void ajouterCategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyForm form=new MyForm();
            form.ShowDialog();
        }
    }
}
