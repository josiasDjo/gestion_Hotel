namespace gestion_Hotel
{
    partial class reserver
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.searchOption = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtNbreJours = new System.Windows.Forms.TextBox();
            this.txtNumChambre = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDatePrevu = new System.Windows.Forms.DateTimePicker();
            this.txtSexe = new System.Windows.Forms.ComboBox();
            this.txtTypeChambre = new System.Windows.Forms.ComboBox();
            this.idRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbreJoursCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeChambreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePrevuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.simpleButton3);
            this.panel4.Controls.Add(this.simpleButton2);
            this.panel4.Controls.Add(this.simpleButton1);
            this.panel4.Location = new System.Drawing.Point(961, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 364);
            this.panel4.TabIndex = 37;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(44, 227);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(237, 53);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Supprimer";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(44, 134);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(237, 53);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Modifier";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(44, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(237, 53);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Valider";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // searchOption
            // 
            this.searchOption.Location = new System.Drawing.Point(928, 421);
            this.searchOption.Name = "searchOption";
            this.searchOption.Size = new System.Drawing.Size(268, 29);
            this.searchOption.TabIndex = 47;
            this.searchOption.Text = "";
            this.searchOption.TextChanged += new System.EventHandler(this.searchOption_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRows,
            this.nomCol,
            this.prenomCol,
            this.sexeCol,
            this.phoneCol,
            this.numChambre,
            this.nbreJoursCol,
            this.typeChambreCol,
            this.montantCol,
            this.datePrevuCol});
            this.dataGridView1.Location = new System.Drawing.Point(33, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1208, 330);
            this.dataGridView1.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nombre de jours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Montant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Type de Chambre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "N° Chambre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Sexe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 33);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 33);
            this.panel1.TabIndex = 35;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(555, 154);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(370, 26);
            this.txtPhone.TabIndex = 32;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(555, 369);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(370, 26);
            this.txtMontant.TabIndex = 31;
            // 
            // txtNbreJours
            // 
            this.txtNbreJours.Location = new System.Drawing.Point(89, 369);
            this.txtNbreJours.Name = "txtNbreJours";
            this.txtNbreJours.Size = new System.Drawing.Size(370, 26);
            this.txtNbreJours.TabIndex = 30;
            // 
            // txtNumChambre
            // 
            this.txtNumChambre.Location = new System.Drawing.Point(89, 301);
            this.txtNumChambre.Name = "txtNumChambre";
            this.txtNumChambre.Size = new System.Drawing.Size(370, 26);
            this.txtNumChambre.TabIndex = 28;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(89, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(370, 26);
            this.txtNom.TabIndex = 34;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(89, 154);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(370, 26);
            this.txtPrenom.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDatePrevu
            // 
            this.txtDatePrevu.Location = new System.Drawing.Point(89, 424);
            this.txtDatePrevu.Name = "txtDatePrevu";
            this.txtDatePrevu.Size = new System.Drawing.Size(370, 26);
            this.txtDatePrevu.TabIndex = 48;
            // 
            // txtSexe
            // 
            this.txtSexe.FormattingEnabled = true;
            this.txtSexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.txtSexe.Location = new System.Drawing.Point(555, 77);
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.Size = new System.Drawing.Size(370, 28);
            this.txtSexe.TabIndex = 49;
            // 
            // txtTypeChambre
            // 
            this.txtTypeChambre.FormattingEnabled = true;
            this.txtTypeChambre.Items.AddRange(new object[] {
            "VIP ",
            "Standard"});
            this.txtTypeChambre.Location = new System.Drawing.Point(555, 301);
            this.txtTypeChambre.Name = "txtTypeChambre";
            this.txtTypeChambre.Size = new System.Drawing.Size(370, 28);
            this.txtTypeChambre.TabIndex = 50;
            this.txtTypeChambre.SelectedIndexChanged += new System.EventHandler(this.txtTypeChambre_SelectedIndexChanged);
            // 
            // idRows
            // 
            this.idRows.HeaderText = "N°";
            this.idRows.Name = "idRows";
            // 
            // nomCol
            // 
            this.nomCol.HeaderText = "Nom";
            this.nomCol.Name = "nomCol";
            // 
            // prenomCol
            // 
            this.prenomCol.HeaderText = "Prénom";
            this.prenomCol.Name = "prenomCol";
            // 
            // sexeCol
            // 
            this.sexeCol.HeaderText = "Sexe";
            this.sexeCol.Name = "sexeCol";
            // 
            // phoneCol
            // 
            this.phoneCol.HeaderText = "Phone";
            this.phoneCol.Name = "phoneCol";
            // 
            // numChambre
            // 
            this.numChambre.HeaderText = "N° Chambre";
            this.numChambre.Name = "numChambre";
            // 
            // nbreJoursCol
            // 
            this.nbreJoursCol.HeaderText = "Nombre de jours";
            this.nbreJoursCol.Name = "nbreJoursCol";
            // 
            // typeChambreCol
            // 
            this.typeChambreCol.HeaderText = "Type de Chambre";
            this.typeChambreCol.Name = "typeChambreCol";
            // 
            // montantCol
            // 
            this.montantCol.HeaderText = "Montant";
            this.montantCol.Name = "montantCol";
            // 
            // datePrevuCol
            // 
            this.datePrevuCol.HeaderText = "Date Prévue";
            this.datePrevuCol.Name = "datePrevuCol";
            // 
            // reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 824);
            this.Controls.Add(this.txtTypeChambre);
            this.Controls.Add(this.txtSexe);
            this.Controls.Add(this.txtDatePrevu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.searchOption);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtNbreJours);
            this.Controls.Add(this.txtNumChambre);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Name = "reserver";
            this.Text = "reserver";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox searchOption;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtNbreJours;
        private System.Windows.Forms.TextBox txtNumChambre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker txtDatePrevu;
        private System.Windows.Forms.ComboBox txtSexe;
        private System.Windows.Forms.ComboBox txtTypeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbreJoursCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeChambreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePrevuCol;
    }
}