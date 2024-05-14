namespace gestion_Hotel
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.comptabilte = new DevExpress.XtraEditors.SimpleButton();
            this.reservation_btn = new DevExpress.XtraEditors.SimpleButton();
            this.homePage = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.comptabilte);
            this.panel2.Controls.Add(this.reservation_btn);
            this.panel2.Controls.Add(this.homePage);
            this.panel2.Location = new System.Drawing.Point(-2, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 661);
            this.panel2.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(0, 485);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(334, 87);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Autres";
            // 
            // comptabilte
            // 
            this.comptabilte.Location = new System.Drawing.Point(-3, 355);
            this.comptabilte.Name = "comptabilte";
            this.comptabilte.Size = new System.Drawing.Size(334, 87);
            this.comptabilte.TabIndex = 0;
            this.comptabilte.Text = "Comptabilité ";
            // 
            // reservation_btn
            // 
            this.reservation_btn.Location = new System.Drawing.Point(0, 221);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.Size = new System.Drawing.Size(334, 87);
            this.reservation_btn.TabIndex = 0;
            this.reservation_btn.Text = "Reservation";
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // homePage
            // 
            this.homePage.Appearance.ForeColor = System.Drawing.Color.Black;
            this.homePage.Appearance.Options.UseForeColor = true;
            this.homePage.Location = new System.Drawing.Point(0, 84);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(334, 87);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(330, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1181, 712);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 767);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton comptabilte;
        private DevExpress.XtraEditors.SimpleButton reservation_btn;
        private DevExpress.XtraEditors.SimpleButton homePage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

