
namespace BloodBankManagementSystem
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbFirst = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblManagementSystem = new System.Windows.Forms.Label();
            this.panelBG = new System.Windows.Forms.Panel();
            this.panelMV = new System.Windows.Forms.Panel();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).BeginInit();
            this.panelBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFirst
            // 
            this.pbFirst.Image = ((System.Drawing.Image)(resources.GetObject("pbFirst.Image")));
            this.pbFirst.Location = new System.Drawing.Point(113, 107);
            this.pbFirst.Name = "pbFirst";
            this.pbFirst.Size = new System.Drawing.Size(151, 137);
            this.pbFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirst.TabIndex = 1;
            this.pbFirst.TabStop = false;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgramName.Location = new System.Drawing.Point(361, 107);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(337, 65);
            this.lblProgramName.TabIndex = 2;
            this.lblProgramName.Text = "BLOOD BANK";
            // 
            // lblManagementSystem
            // 
            this.lblManagementSystem.AutoSize = true;
            this.lblManagementSystem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManagementSystem.Location = new System.Drawing.Point(395, 172);
            this.lblManagementSystem.Name = "lblManagementSystem";
            this.lblManagementSystem.Size = new System.Drawing.Size(265, 37);
            this.lblManagementSystem.TabIndex = 3;
            this.lblManagementSystem.Text = "Management System";
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBG.Controls.Add(this.panelMV);
            this.panelBG.Location = new System.Drawing.Point(0, 349);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(800, 43);
            this.panelBG.TabIndex = 4;
            // 
            // panelMV
            // 
            this.panelMV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelMV.Location = new System.Drawing.Point(3, 3);
            this.panelMV.Name = "panelMV";
            this.panelMV.Size = new System.Drawing.Size(33, 37);
            this.panelMV.TabIndex = 0;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.lblManagementSystem);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.pbFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).EndInit();
            this.panelBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFirst;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblManagementSystem;
        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.Panel panelMV;
        private System.Windows.Forms.Timer timerSplash;
    }
}