namespace ManagementStorage
{
    partial class form_produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_produit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zone_nomp = new System.Windows.Forms.TextBox();
            this.zone_prixp = new System.Windows.Forms.TextBox();
            this.zone_qtep = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_savep = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.zone_searchp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_stock = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_affiche = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produit)).BeginInit();
            this.panel_stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_produit
            // 
            this.dataGridView_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produit.Location = new System.Drawing.Point(3, 45);
            this.dataGridView_produit.Name = "dataGridView_produit";
            this.dataGridView_produit.Size = new System.Drawing.Size(466, 484);
            this.dataGridView_produit.TabIndex = 0;
            this.dataGridView_produit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_produit_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix Unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantite";
            // 
            // zone_nomp
            // 
            this.zone_nomp.Location = new System.Drawing.Point(105, 79);
            this.zone_nomp.Name = "zone_nomp";
            this.zone_nomp.Size = new System.Drawing.Size(132, 25);
            this.zone_nomp.TabIndex = 5;
            this.zone_nomp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_nomp_KeyPress);
            // 
            // zone_prixp
            // 
            this.zone_prixp.Location = new System.Drawing.Point(105, 133);
            this.zone_prixp.Name = "zone_prixp";
            this.zone_prixp.Size = new System.Drawing.Size(132, 25);
            this.zone_prixp.TabIndex = 7;
            this.zone_prixp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_prixp_KeyPress);
            // 
            // zone_qtep
            // 
            this.zone_qtep.Location = new System.Drawing.Point(105, 192);
            this.zone_qtep.Name = "zone_qtep";
            this.zone_qtep.Size = new System.Drawing.Size(132, 25);
            this.zone_qtep.TabIndex = 8;
            this.zone_qtep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_qtep_KeyPress);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(475, 417);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 39);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(472, 277);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 39);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_savep
            // 
            this.btn_savep.Location = new System.Drawing.Point(154, 259);
            this.btn_savep.Name = "btn_savep";
            this.btn_savep.Size = new System.Drawing.Size(83, 39);
            this.btn_savep.TabIndex = 11;
            this.btn_savep.Text = "Enregistrer";
            this.btn_savep.UseVisualStyleBackColor = true;
            this.btn_savep.Click += new System.EventHandler(this.btn_savep_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(457, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 36);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Rechercher";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // zone_searchp
            // 
            this.zone_searchp.Location = new System.Drawing.Point(299, 10);
            this.zone_searchp.Name = "zone_searchp";
            this.zone_searchp.Size = new System.Drawing.Size(152, 25);
            this.zone_searchp.TabIndex = 13;
            this.zone_searchp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_searchp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vous pouvez rechercher un produit sur la table";
            // 
            // panel_stock
            // 
            this.panel_stock.Controls.Add(this.label2);
            this.panel_stock.Controls.Add(this.dataGridView_produit);
            this.panel_stock.Controls.Add(this.label5);
            this.panel_stock.Controls.Add(this.btn_update);
            this.panel_stock.Controls.Add(this.zone_searchp);
            this.panel_stock.Controls.Add(this.btn_delete);
            this.panel_stock.Controls.Add(this.btn_search);
            this.panel_stock.Location = new System.Drawing.Point(243, 14);
            this.panel_stock.Name = "panel_stock";
            this.panel_stock.Size = new System.Drawing.Size(564, 553);
            this.panel_stock.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pour supprimer ou modifier un produit cliquer sur la ligne correspondante";
            // 
            // btn_affiche
            // 
            this.btn_affiche.Location = new System.Drawing.Point(6, 14);
            this.btn_affiche.Name = "btn_affiche";
            this.btn_affiche.Size = new System.Drawing.Size(206, 35);
            this.btn_affiche.TabIndex = 16;
            this.btn_affiche.Text = "Afficher le stock global";
            this.btn_affiche.UseVisualStyleBackColor = true;
            this.btn_affiche.Click += new System.EventHandler(this.btn_affiche_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(15, 518);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(206, 35);
            this.btn_fermer.TabIndex = 16;
            this.btn_fermer.Text = "Fermer le stock global";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // form_produit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_affiche);
            this.Controls.Add(this.panel_stock);
            this.Controls.Add(this.btn_savep);
            this.Controls.Add(this.zone_qtep);
            this.Controls.Add(this.zone_prixp);
            this.Controls.Add(this.zone_nomp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form_produit";
            this.Size = new System.Drawing.Size(810, 570);
            this.Load += new System.EventHandler(this.form_produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produit)).EndInit();
            this.panel_stock.ResumeLayout(false);
            this.panel_stock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_produit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zone_nomp;
        private System.Windows.Forms.TextBox zone_prixp;
        private System.Windows.Forms.TextBox zone_qtep;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_savep;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox zone_searchp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_affiche;
        private System.Windows.Forms.Button btn_fermer;
    }
}
