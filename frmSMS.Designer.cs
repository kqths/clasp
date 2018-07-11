namespace CLASP
{
    partial class frmSMS
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
            this.cboPorts = new MetroFramework.Controls.MetroComboBox();
            this.txtMobileNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMsg = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.ItemHeight = 23;
            this.cboPorts.Location = new System.Drawing.Point(122, 90);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 29);
            this.cboPorts.TabIndex = 0;
            this.cboPorts.UseSelectable = true;
            // 
            // txtMobileNum
            // 
            // 
            // 
            // 
            this.txtMobileNum.CustomButton.Image = null;
            this.txtMobileNum.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtMobileNum.CustomButton.Name = "";
            this.txtMobileNum.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMobileNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobileNum.CustomButton.TabIndex = 1;
            this.txtMobileNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobileNum.CustomButton.UseSelectable = true;
            this.txtMobileNum.CustomButton.Visible = false;
            this.txtMobileNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMobileNum.Lines = new string[0];
            this.txtMobileNum.Location = new System.Drawing.Point(124, 150);
            this.txtMobileNum.MaxLength = 32767;
            this.txtMobileNum.Name = "txtMobileNum";
            this.txtMobileNum.PasswordChar = '\0';
            this.txtMobileNum.PromptText = "Mobile Number";
            this.txtMobileNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobileNum.SelectedText = "";
            this.txtMobileNum.SelectionLength = 0;
            this.txtMobileNum.SelectionStart = 0;
            this.txtMobileNum.ShortcutsEnabled = true;
            this.txtMobileNum.Size = new System.Drawing.Size(197, 29);
            this.txtMobileNum.TabIndex = 1;
            this.txtMobileNum.UseSelectable = true;
            this.txtMobileNum.WaterMark = "Mobile Number";
            this.txtMobileNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobileNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "COMPORT";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(233, 405);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 31);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "&SEND";
            this.btnSend.UseCustomBackColor = true;
            this.btnSend.UseCustomForeColor = true;
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(26, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "TO";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 236);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "MESSAGE";
            // 
            // txtMsg
            // 
            // 
            // 
            // 
            this.txtMsg.CustomButton.Image = null;
            this.txtMsg.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtMsg.CustomButton.Name = "";
            this.txtMsg.CustomButton.Size = new System.Drawing.Size(135, 135);
            this.txtMsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMsg.CustomButton.TabIndex = 1;
            this.txtMsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMsg.CustomButton.UseSelectable = true;
            this.txtMsg.CustomButton.Visible = false;
            this.txtMsg.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMsg.Lines = new string[0];
            this.txtMsg.Location = new System.Drawing.Point(124, 236);
            this.txtMsg.MaxLength = 32767;
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.PasswordChar = '\0';
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMsg.SelectedText = "";
            this.txtMsg.SelectionLength = 0;
            this.txtMsg.SelectionStart = 0;
            this.txtMsg.ShortcutsEnabled = true;
            this.txtMsg.Size = new System.Drawing.Size(197, 137);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.UseSelectable = true;
            this.txtMsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 474);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtMobileNum);
            this.Controls.Add(this.cboPorts);
            this.Name = "frmSMS";
            this.Text = "SMS TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboPorts;
        private MetroFramework.Controls.MetroTextBox txtMobileNum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMsg;
    }
}