namespace ManagementStorage
{
    partial class Form_releve
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
            this.zone_client = new System.Windows.Forms.TextBox();
            this.zone_tel = new System.Windows.Forms.TextBox();
            this.zone_quantite = new System.Windows.Forms.TextBox();
            this.zone_pu = new System.Windows.Forms.TextBox();
            this.dataGridView_releve = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.zone_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.select_etat = new System.Windows.Forms.ComboBox();
            this.select_prodR = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_releve)).BeginInit();
            this.SuspendLayout();
            // 
            // zone_client
            // 
            this.zone_client.Location = new System.Drawing.Point(37, 495);
            this.zone_client.Name = "zone_client";
            this.zone_client.Size = new System.Drawing.Size(100, 25);
            this.zone_client.TabIndex = 0;
            // 
            // zone_tel
            // 
            this.zone_tel.Location = new System.Drawing.Point(159, 495);
            this.zone_tel.Name = "zone_tel";
            this.zone_tel.Size = new System.Drawing.Size(112, 25);
            this.zone_tel.TabIndex = 0;
            // 
            // zone_quantite
            // 
            this.zone_quantite.Location = new System.Drawing.Point(466, 495);
            this.zone_quantite.Name = "zone_quantite";
            this.zone_quantite.Size = new System.Drawing.Size(100, 25);
            this.zone_quantite.TabIndex = 0;
            // 
            // zone_pu
            // 
            this.zone_pu.Location = new System.Drawing.Point(727, 495);
            this.zone_pu.Name = "zone_pu";
            this.zone_pu.Size = new System.Drawing.Size(100, 25);
            this.zone_pu.TabIndex = 0;
            // 
            // dataGridView_releve
            // 
            this.dataGridView_releve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_releve.Location = new System.Drawing.Point(30, 80);
            this.dataGridView_releve.Name = "dataGridView_releve";
            this.dataGridView_releve.Size = new System.Drawing.Size(890, 368);
            this.dataGridView_releve.TabIndex = 1;
            this.dataGridView_releve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_releve_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des relevés";
            // 
            // zone_search
            // 
            this.zone_search.Location = new System.Drawing.Point(130, 47);
            this.zone_search.Name = "zone_search";
            this.zone_search.Size = new System.Drawing.Size(328, 25);
            this.zone_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(647, 47);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(155, 25);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Recherche";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(33, 550);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 42);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(184, 550);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 42);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Etat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Désignation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prix Unitaire";
            // 
            // select_etat
            // 
            this.select_etat.FormattingEnabled = true;
            this.select_etat.Items.AddRange(new object[] {
            "Nom Payé et non Livré",
            "Nom Payé et  Livré",
            "Payé et non Livré"});
            this.select_etat.Location = new System.Drawing.Point(288, 495);
            this.select_etat.Name = "select_etat";
            this.select_etat.Size = new System.Drawing.Size(128, 25);
            this.select_etat.TabIndex = 8;
            this.select_etat.SelectedIndexChanged += new System.EventHandler(this.select_etat_SelectedIndexChanged);
            // 
            // select_prodR
            // 
            this.select_prodR.FormattingEnabled = true;
            this.select_prodR.Location = new System.Drawing.Point(590, 495);
            this.select_prodR.Name = "select_prodR";
            this.select_prodR.Size = new System.Drawing.Size(121, 25);
            this.select_prodR.TabIndex = 9;
            // 
            // Form_releve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.select_prodR);
            this.Controls.Add(this.select_etat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.zone_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_releve);
            this.Controls.Add(this.zone_pu);
            this.Controls.Add(this.zone_quantite);
            this.Controls.Add(this.zone_tel);
            this.Controls.Add(this.zone_client);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_releve";
            this.Size = new System.Drawing.Size(1035, 644);
            this.Load += new System.EventHandler(this.Form_releve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_releve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zone_client;
        private System.Windows.Forms.TextBox zone_tel;
        private System.Windows.Forms.TextBox zone_quantite;
        private System.Windows.Forms.TextBox zone_pu;
        private System.Windows.Forms.DataGridView dataGridView_releve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zone_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox select_etat;
        private System.Windows.Forms.ComboBox select_prodR;
    }
}
