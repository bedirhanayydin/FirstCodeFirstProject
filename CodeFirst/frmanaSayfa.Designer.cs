namespace CodeFirst
{
    partial class frmanaSayfa
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
            this.btnSeri = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.seriTool = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSeri);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnPersonelListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 85);
            this.panel1.TabIndex = 1;
            // 
            // btnSeri
            // 
            this.btnSeri.BackColor = System.Drawing.Color.Red;
            this.btnSeri.Location = new System.Drawing.Point(204, 15);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(84, 51);
            this.btnSeri.TabIndex = 10;
            this.btnSeri.Text = "Model";
            this.btnSeri.UseVisualStyleBackColor = false;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.BackColor = System.Drawing.Color.Red;
            this.btnMarka.Location = new System.Drawing.Point(117, 15);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(84, 51);
            this.btnMarka.TabIndex = 9;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = false;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.Color.Red;
            this.btnPersonelListele.Location = new System.Drawing.Point(30, 15);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(84, 51);
            this.btnPersonelListele.TabIndex = 4;
            this.btnPersonelListele.Text = "Kişiler";
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.müşterilerToolStripMenuItem.Text = "Kişiler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaTool,
            this.seriTool});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ayarlarToolStripMenuItem.Text = "İşlemler";
            // 
            // markaTool
            // 
            this.markaTool.Name = "markaTool";
            this.markaTool.Size = new System.Drawing.Size(108, 22);
            this.markaTool.Text = "Marka";
            this.markaTool.Click += new System.EventHandler(this.markaTool_Click);
            // 
            // seriTool
            // 
            this.seriTool.Name = "seriTool";
            this.seriTool.Size = new System.Drawing.Size(108, 22);
            this.seriTool.Text = "Model";
            this.seriTool.Click += new System.EventHandler(this.seriTool_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // frmanaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(321, 125);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmanaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçlarım";
            this.Load += new System.EventHandler(this.frmanaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaTool;
        private System.Windows.Forms.ToolStripMenuItem seriTool;
        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnPersonelListele;
    }
}

