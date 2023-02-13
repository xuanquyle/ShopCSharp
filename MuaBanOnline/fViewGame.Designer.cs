namespace WindowsFormsApplication1
{
    partial class fViewGame
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sẮPSẾPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIÁCAOTRƯỚCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIÁTHẤPTRƯỚCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHỔBIẾNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-13, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(832, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 33);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sẮPSẾPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(169, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sẮPSẾPToolStripMenuItem
            // 
            this.sẮPSẾPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gIÁCAOTRƯỚCToolStripMenuItem,
            this.gIÁTHẤPTRƯỚCToolStripMenuItem,
            this.pHỔBIẾNToolStripMenuItem});
            this.sẮPSẾPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sẮPSẾPToolStripMenuItem.Name = "sẮPSẾPToolStripMenuItem";
            this.sẮPSẾPToolStripMenuItem.Padding = new System.Windows.Forms.Padding(50, 0, 4, 0);
            this.sẮPSẾPToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.sẮPSẾPToolStripMenuItem.Text = "SẮP SẾP";
            // 
            // gIÁCAOTRƯỚCToolStripMenuItem
            // 
            this.gIÁCAOTRƯỚCToolStripMenuItem.Name = "gIÁCAOTRƯỚCToolStripMenuItem";
            this.gIÁCAOTRƯỚCToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.gIÁCAOTRƯỚCToolStripMenuItem.Text = "GIÁ CAO TRƯỚC";
            this.gIÁCAOTRƯỚCToolStripMenuItem.Click += new System.EventHandler(this.gIÁCAOTRƯỚCToolStripMenuItem_Click);
            // 
            // gIÁTHẤPTRƯỚCToolStripMenuItem
            // 
            this.gIÁTHẤPTRƯỚCToolStripMenuItem.Name = "gIÁTHẤPTRƯỚCToolStripMenuItem";
            this.gIÁTHẤPTRƯỚCToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.gIÁTHẤPTRƯỚCToolStripMenuItem.Text = "GIÁ THẤP TRƯỚC";
            this.gIÁTHẤPTRƯỚCToolStripMenuItem.Click += new System.EventHandler(this.gIÁTHẤPTRƯỚCToolStripMenuItem_Click);
            // 
            // pHỔBIẾNToolStripMenuItem
            // 
            this.pHỔBIẾNToolStripMenuItem.Name = "pHỔBIẾNToolStripMenuItem";
            this.pHỔBIẾNToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.pHỔBIẾNToolStripMenuItem.Text = "PHỔ BIẾN";
            this.pHỔBIẾNToolStripMenuItem.Click += new System.EventHandler(this.pHỔBIẾNToolStripMenuItem_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(383, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(76, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // fViewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1096, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 150);
            this.Name = "fViewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewGame";
            this.Load += new System.EventHandler(this.ViewGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sẮPSẾPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIÁCAOTRƯỚCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIÁTHẤPTRƯỚCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHỔBIẾNToolStripMenuItem;




    }
}