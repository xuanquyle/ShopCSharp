namespace WindowsFormsApplication1
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlCustomer = new System.Windows.Forms.TabControl();
            this.tabPageCus = new System.Windows.Forms.TabPage();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbNameLogin = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbNameLogin = new System.Windows.Forms.TextBox();
            this.tabPageAd = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlCustomer.SuspendLayout();
            this.tabPageCus.SuspendLayout();
            this.tabPageAd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlCustomer);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tabControlCustomer
            // 
            resources.ApplyResources(this.tabControlCustomer, "tabControlCustomer");
            this.tabControlCustomer.Controls.Add(this.tabPageCus);
            this.tabControlCustomer.Controls.Add(this.tabPageAd);
            this.tabControlCustomer.Name = "tabControlCustomer";
            this.tabControlCustomer.SelectedIndex = 0;
            // 
            // tabPageCus
            // 
            this.tabPageCus.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCus.Controls.Add(this.button3);
            this.tabPageCus.Controls.Add(this.btExit);
            this.tabPageCus.Controls.Add(this.btLogin);
            this.tabPageCus.Controls.Add(this.lbPassWord);
            this.tabPageCus.Controls.Add(this.lbNameLogin);
            this.tabPageCus.Controls.Add(this.tbPassWord);
            this.tabPageCus.Controls.Add(this.tbNameLogin);
            resources.ApplyResources(this.tabPageCus, "tabPageCus");
            this.tabPageCus.Name = "tabPageCus";
            this.tabPageCus.Click += new System.EventHandler(this.tabPageCus_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btExit, "btExit");
            this.btExit.Name = "btExit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.Name = "btLogin";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click_1);
            // 
            // lbPassWord
            // 
            resources.ApplyResources(this.lbPassWord, "lbPassWord");
            this.lbPassWord.BackColor = System.Drawing.SystemColors.Control;
            this.lbPassWord.ForeColor = System.Drawing.Color.Black;
            this.lbPassWord.Name = "lbPassWord";
            // 
            // lbNameLogin
            // 
            resources.ApplyResources(this.lbNameLogin, "lbNameLogin");
            this.lbNameLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lbNameLogin.ForeColor = System.Drawing.Color.Black;
            this.lbNameLogin.Name = "lbNameLogin";
            // 
            // tbPassWord
            // 
            this.tbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbPassWord, "tbPassWord");
            this.tbPassWord.Name = "tbPassWord";
            // 
            // tbNameLogin
            // 
            this.tbNameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbNameLogin, "tbNameLogin");
            this.tbNameLogin.Name = "tbNameLogin";
            // 
            // tabPageAd
            // 
            this.tabPageAd.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAd.Controls.Add(this.button1);
            this.tabPageAd.Controls.Add(this.button2);
            this.tabPageAd.Controls.Add(this.label1);
            this.tabPageAd.Controls.Add(this.label2);
            this.tabPageAd.Controls.Add(this.textBox1);
            this.tabPageAd.Controls.Add(this.textBox2);
            resources.ApplyResources(this.tabPageAd, "tabPageAd");
            this.tabPageAd.Name = "tabPageAd";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fLogin_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlCustomer.ResumeLayout(false);
            this.tabPageCus.ResumeLayout(false);
            this.tabPageCus.PerformLayout();
            this.tabPageAd.ResumeLayout(false);
            this.tabPageAd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlCustomer;
        private System.Windows.Forms.TabPage tabPageCus;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbNameLogin;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbNameLogin;
        private System.Windows.Forms.TabPage tabPageAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}

