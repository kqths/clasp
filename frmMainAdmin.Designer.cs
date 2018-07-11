namespace CLASP
{
    partial class frmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAdmin));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.tileMembers = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tileLoans = new MetroFramework.Controls.MetroTile();
            this.tileSMS = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(123, 28);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(38, 19);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "TIME";
            // 
            // tileMembers
            // 
            this.tileMembers.ActiveControl = null;
            this.tileMembers.BackColor = System.Drawing.Color.Gray;
            this.tileMembers.Location = new System.Drawing.Point(23, 90);
            this.tileMembers.Name = "tileMembers";
            this.tileMembers.Size = new System.Drawing.Size(382, 112);
            this.tileMembers.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileMembers.TabIndex = 1;
            this.tileMembers.Text = "MEMBERS";
            this.tileMembers.UseCustomBackColor = true;
            this.tileMembers.UseSelectable = true;
            this.tileMembers.Click += new System.EventHandler(this.tileMembers_Click);
            this.tileMembers.MouseEnter += new System.EventHandler(this.tileMembers_MouseEnter);
            this.tileMembers.MouseLeave += new System.EventHandler(this.tileMembers_MouseLeave);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(499, 24);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "&LOGOUT";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.Location = new System.Drawing.Point(24, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(550, 2);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // tileLoans
            // 
            this.tileLoans.ActiveControl = null;
            this.tileLoans.BackColor = System.Drawing.Color.Gray;
            this.tileLoans.Location = new System.Drawing.Point(24, 208);
            this.tileLoans.Name = "tileLoans";
            this.tileLoans.Size = new System.Drawing.Size(382, 112);
            this.tileLoans.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLoans.TabIndex = 1;
            this.tileLoans.Text = "LOANS";
            this.tileLoans.UseCustomBackColor = true;
            this.tileLoans.UseSelectable = true;
            this.tileLoans.MouseEnter += new System.EventHandler(this.tileMembers_MouseEnter);
            this.tileLoans.MouseLeave += new System.EventHandler(this.tileMembers_MouseLeave);
            // 
            // tileSMS
            // 
            this.tileSMS.ActiveControl = null;
            this.tileSMS.BackColor = System.Drawing.Color.Gray;
            this.tileSMS.Location = new System.Drawing.Point(23, 326);
            this.tileSMS.Name = "tileSMS";
            this.tileSMS.Size = new System.Drawing.Size(382, 112);
            this.tileSMS.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileSMS.TabIndex = 1;
            this.tileSMS.Text = "SMS";
            this.tileSMS.UseCustomBackColor = true;
            this.tileSMS.UseSelectable = true;
            this.tileSMS.Click += new System.EventHandler(this.tileSMS_Click);
            this.tileSMS.MouseEnter += new System.EventHandler(this.tileMembers_MouseEnter);
            this.tileSMS.MouseLeave += new System.EventHandler(this.tileMembers_MouseLeave);
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 510);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tileSMS);
            this.Controls.Add(this.tileLoans);
            this.Controls.Add(this.tileMembers);
            this.Controls.Add(this.lblDateTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainAdmin";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.frmMainAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private MetroFramework.Controls.MetroTile tileMembers;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileLoans;
        private MetroFramework.Controls.MetroTile tileSMS;
    }
}