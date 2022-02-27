namespace ManagementStorage
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_left = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_bon = new System.Windows.Forms.Button();
            this.btn_releve = new System.Windows.Forms.Button();
            this.btn_stock_global = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_centre = new System.Windows.Forms.Panel();
            this.form_releve1 = new ManagementStorage.Form_releve();
            this.form_vente1 = new ManagementStorage.Form_vente();
            this.form_produit1 = new ManagementStorage.form_produit();
            this.form_login1 = new ManagementStorage.Form_login();
            this.form_accueil1 = new ManagementStorage.Form_accueil();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_centre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.button5);
            this.panel_left.Controls.Add(this.button4);
            this.panel_left.Controls.Add(this.btn_bon);
            this.panel_left.Controls.Add(this.btn_releve);
            this.panel_left.Controls.Add(this.btn_stock_global);
            this.panel_left.Controls.Add(this.menuStrip1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(209, 673);
            this.panel_left.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 440);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_bon
            // 
            this.btn_bon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bon.Location = new System.Drawing.Point(11, 251);
            this.btn_bon.Name = "btn_bon";
            this.btn_bon.Size = new System.Drawing.Size(175, 113);
            this.btn_bon.TabIndex = 9;
            this.btn_bon.Text = "Enregistrer un bon";
            this.btn_bon.UseVisualStyleBackColor = true;
            // 
            // btn_releve
            // 
            this.btn_releve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_releve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_releve.Image = global::ManagementStorage.Properties.Resources.IMG_20200715_WA0039;
            this.btn_releve.Location = new System.Drawing.Point(11, 154);
            this.btn_releve.Name = "btn_releve";
            this.btn_releve.Size = new System.Drawing.Size(175, 91);
            this.btn_releve.TabIndex = 8;
            this.btn_releve.Text = "Releve";
            this.btn_releve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_releve.UseVisualStyleBackColor = true;
            this.btn_releve.Click += new System.EventHandler(this.btn_releve_Click);
            // 
            // btn_stock_global
            // 
            this.btn_stock_global.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock_global.Image = global::ManagementStorage.Properties.Resources.IMG_20200715_WA0044;
            this.btn_stock_global.Location = new System.Drawing.Point(11, 41);
            this.btn_stock_global.Name = "btn_stock_global";
            this.btn_stock_global.Size = new System.Drawing.Size(175, 107);
            this.btn_stock_global.TabIndex = 7;
            this.btn_stock_global.Text = "Stock Global";
            this.btn_stock_global.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stock_global.UseVisualStyleBackColor = true;
            this.btn_stock_global.Click += new System.EventHandler(this.btn_stock_global_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.accueilToolStripMenuItem,
            this.seConnecterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCategorieToolStripMenuItem,
            this.ajouterProduitToolStripMenuItem,
            this.enregistrerVenteToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // ajouterCategorieToolStripMenuItem
            // 
            this.ajouterCategorieToolStripMenuItem.Name = "ajouterCategorieToolStripMenuItem";
            this.ajouterCategorieToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ajouterCategorieToolStripMenuItem.Text = "Ajouter Categorie";
            this.ajouterCategorieToolStripMenuItem.Click += new System.EventHandler(this.ajouterCategorieToolStripMenuItem_Click);
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter Produit";
            this.ajouterProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterProduitToolStripMenuItem_Click);
            // 
            // enregistrerVenteToolStripMenuItem
            // 
            this.enregistrerVenteToolStripMenuItem.Name = "enregistrerVenteToolStripMenuItem";
            this.enregistrerVenteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.enregistrerVenteToolStripMenuItem.Text = "Enregistrer Vente";
            this.enregistrerVenteToolStripMenuItem.Click += new System.EventHandler(this.enregistrerVenteToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.seConnecterToolStripMenuItem.Text = "Se connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // panel_centre
            // 
            this.panel_centre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_centre.Controls.Add(this.form_releve1);
            this.panel_centre.Controls.Add(this.form_vente1);
            this.panel_centre.Controls.Add(this.form_produit1);
            this.panel_centre.Controls.Add(this.form_login1);
            this.panel_centre.Controls.Add(this.form_accueil1);
            this.panel_centre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_centre.Location = new System.Drawing.Point(209, 0);
            this.panel_centre.Name = "panel_centre";
            this.panel_centre.Size = new System.Drawing.Size(1076, 673);
            this.panel_centre.TabIndex = 0;
            // 
            // form_releve1
            // 
            this.form_releve1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.form_releve1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.form_releve1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.form_releve1.Location = new System.Drawing.Point(-1, 0);
            this.form_releve1.Margin = new System.Windows.Forms.Padding(4);
            this.form_releve1.Name = "form_releve1";
            this.form_releve1.Size = new System.Drawing.Size(869, 659);
            this.form_releve1.TabIndex = 5;
            // 
            // form_vente1
            // 
            this.form_vente1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.form_vente1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_vente1.Location = new System.Drawing.Point(-1, 0);
            this.form_vente1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form_vente1.Name = "form_vente1";
            this.form_vente1.Size = new System.Drawing.Size(1076, 663);
            this.form_vente1.TabIndex = 4;
            // 
            // form_produit1
            // 
            this.form_produit1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.form_produit1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_produit1.Location = new System.Drawing.Point(-1, 0);
            this.form_produit1.Name = "form_produit1";
            this.form_produit1.Size = new System.Drawing.Size(1076, 662);
            this.form_produit1.TabIndex = 3;
            // 
            // form_login1
            // 
            this.form_login1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.form_login1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_login1.Location = new System.Drawing.Point(-1, 0);
            this.form_login1.Margin = new System.Windows.Forms.Padding(4);
            this.form_login1.Name = "form_login1";
            this.form_login1.Size = new System.Drawing.Size(1076, 662);
            this.form_login1.TabIndex = 1;
            // 
            // form_accueil1
            // 
            this.form_accueil1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_accueil1.Location = new System.Drawing.Point(-1, -1);
            this.form_accueil1.Margin = new System.Windows.Forms.Padding(4);
            this.form_accueil1.Name = "form_accueil1";
            this.form_accueil1.Size = new System.Drawing.Size(1076, 662);
            this.form_accueil1.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(1085, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(200, 673);
            this.panel_right.TabIndex = 0;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 673);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_centre);
            this.Controls.Add(this.panel_left);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_centre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_centre;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private Form_accueil form_accueil1;
        private Form_login form_login1;
       
        private form_produit form_produit1;
        private Form_vente form_vente1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_bon;
        private System.Windows.Forms.Button btn_releve;
        private System.Windows.Forms.Button btn_stock_global;
        private Form_releve form_releve1;
    }
}