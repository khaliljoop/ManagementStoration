namespace ManagementStorage
{
    partial class Form_vente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zone_nomcli = new System.Windows.Forms.TextBox();
            this.zone_prix = new System.Windows.Forms.TextBox();
            this.select_pro = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.zone_telcli = new System.Windows.Forms.TextBox();
            this.panel_vente = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView_vente = new System.Windows.Forms.DataGridView();
            this.select_etat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zone_qte = new System.Windows.Forms.TextBox();
            this.panel_valide_imp = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_valide_imp = new System.Windows.Forms.Button();
            this.panel_vente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vente)).BeginInit();
            this.panel_valide_imp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "prix unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ici vous pouvez enregistrer vos ventes";
            // 
            // zone_nomcli
            // 
            this.zone_nomcli.Location = new System.Drawing.Point(211, 88);
            this.zone_nomcli.Margin = new System.Windows.Forms.Padding(4);
            this.zone_nomcli.Name = "zone_nomcli";
            this.zone_nomcli.Size = new System.Drawing.Size(194, 32);
            this.zone_nomcli.TabIndex = 4;
            this.zone_nomcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_nomcli_KeyPress);
            // 
            // zone_prix
            // 
            this.zone_prix.Location = new System.Drawing.Point(251, 101);
            this.zone_prix.Margin = new System.Windows.Forms.Padding(4);
            this.zone_prix.Name = "zone_prix";
            this.zone_prix.Size = new System.Drawing.Size(143, 32);
            this.zone_prix.TabIndex = 5;
            this.zone_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_qte_KeyPress);
            // 
            // select_pro
            // 
            this.select_pro.FormattingEnabled = true;
            this.select_pro.Location = new System.Drawing.Point(13, 102);
            this.select_pro.Margin = new System.Windows.Forms.Padding(4);
            this.select_pro.Name = "select_pro";
            this.select_pro.Size = new System.Drawing.Size(180, 31);
            this.select_pro.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(649, 100);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(134, 49);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telephone";
            // 
            // zone_telcli
            // 
            this.zone_telcli.Location = new System.Drawing.Point(211, 159);
            this.zone_telcli.Margin = new System.Windows.Forms.Padding(4);
            this.zone_telcli.Name = "zone_telcli";
            this.zone_telcli.Size = new System.Drawing.Size(194, 32);
            this.zone_telcli.TabIndex = 4;
            this.zone_telcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_telcli_KeyPress);
            // 
            // panel_vente
            // 
            this.panel_vente.Controls.Add(this.btn_print);
            this.panel_vente.Controls.Add(this.btn_update);
            this.panel_vente.Controls.Add(this.dataGridView_vente);
            this.panel_vente.Location = new System.Drawing.Point(4, 155);
            this.panel_vente.Margin = new System.Windows.Forms.Padding(4);
            this.panel_vente.Name = "panel_vente";
            this.panel_vente.Size = new System.Drawing.Size(653, 387);
            this.panel_vente.TabIndex = 8;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(355, 320);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(112, 54);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Imprimer";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(62, 320);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 54);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView_vente
            // 
            this.dataGridView_vente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vente.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_vente.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_vente.Name = "dataGridView_vente";
            this.dataGridView_vente.Size = new System.Drawing.Size(653, 296);
            this.dataGridView_vente.TabIndex = 0;
            this.dataGridView_vente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_vente_CellClick);
            // 
            // select_etat
            // 
            this.select_etat.FormattingEnabled = true;
            this.select_etat.Items.AddRange(new object[] {
            "Payé et non Livré",
            "Payé et Livré ",
            "Livré et non Payé "});
            this.select_etat.Location = new System.Drawing.Point(169, 243);
            this.select_etat.Margin = new System.Windows.Forms.Padding(4);
            this.select_etat.Name = "select_etat";
            this.select_etat.Size = new System.Drawing.Size(236, 31);
            this.select_etat.TabIndex = 9;
            this.select_etat.SelectedIndexChanged += new System.EventHandler(this.select_etat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Etat Facture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantite";
            // 
            // zone_qte
            // 
            this.zone_qte.Location = new System.Drawing.Point(461, 100);
            this.zone_qte.Margin = new System.Windows.Forms.Padding(4);
            this.zone_qte.Name = "zone_qte";
            this.zone_qte.Size = new System.Drawing.Size(156, 32);
            this.zone_qte.TabIndex = 5;
            this.zone_qte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zone_qte_KeyPress);
            // 
            // panel_valide_imp
            // 
            this.panel_valide_imp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_valide_imp.Controls.Add(this.label11);
            this.panel_valide_imp.Controls.Add(this.label10);
            this.panel_valide_imp.Controls.Add(this.label13);
            this.panel_valide_imp.Controls.Add(this.label12);
            this.panel_valide_imp.Controls.Add(this.label9);
            this.panel_valide_imp.Controls.Add(this.label8);
            this.panel_valide_imp.Controls.Add(this.btn_valide_imp);
            this.panel_valide_imp.Controls.Add(this.zone_nomcli);
            this.panel_valide_imp.Controls.Add(this.label6);
            this.panel_valide_imp.Controls.Add(this.label1);
            this.panel_valide_imp.Controls.Add(this.select_etat);
            this.panel_valide_imp.Controls.Add(this.zone_telcli);
            this.panel_valide_imp.Controls.Add(this.label5);
            this.panel_valide_imp.Location = new System.Drawing.Point(705, 159);
            this.panel_valide_imp.Margin = new System.Windows.Forms.Padding(4);
            this.panel_valide_imp.Name = "panel_valide_imp";
            this.panel_valide_imp.Size = new System.Drawing.Size(414, 431);
            this.panel_valide_imp.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "sont obligatoires";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Les champs en ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(137, 249);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(137, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(147, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Veuillez valider l\'impression";
            // 
            // btn_valide_imp
            // 
            this.btn_valide_imp.Location = new System.Drawing.Point(195, 316);
            this.btn_valide_imp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_valide_imp.Name = "btn_valide_imp";
            this.btn_valide_imp.Size = new System.Drawing.Size(191, 44);
            this.btn_valide_imp.TabIndex = 11;
            this.btn_valide_imp.Text = "Valider";
            this.btn_valide_imp.UseVisualStyleBackColor = true;
            this.btn_valide_imp.Click += new System.EventHandler(this.btn_valide_imp_Click);
            // 
            // Form_vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel_valide_imp);
            this.Controls.Add(this.panel_vente);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.select_pro);
            this.Controls.Add(this.zone_qte);
            this.Controls.Add(this.zone_prix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_vente";
            this.Size = new System.Drawing.Size(1134, 670);
            this.Load += new System.EventHandler(this.Form_vente_Load);
            this.panel_vente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vente)).EndInit();
            this.panel_valide_imp.ResumeLayout(false);
            this.panel_valide_imp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zone_nomcli;
        private System.Windows.Forms.TextBox zone_prix;
        private System.Windows.Forms.ComboBox select_pro;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zone_telcli;
        private System.Windows.Forms.Panel panel_vente;
        private System.Windows.Forms.DataGridView dataGridView_vente;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox select_etat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zone_qte;
        private System.Windows.Forms.Panel panel_valide_imp;
        private System.Windows.Forms.Button btn_valide_imp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
