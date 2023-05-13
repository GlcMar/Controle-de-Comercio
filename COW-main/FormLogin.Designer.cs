namespace COW
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaL = new System.Windows.Forms.TextBox();
            this.lblSenhaL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPFL = new System.Windows.Forms.TextBox();
            this.lblCPFL = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtSenhaL
            // 
            resources.ApplyResources(this.txtSenhaL, "txtSenhaL");
            this.txtSenhaL.Name = "txtSenhaL";
            this.txtSenhaL.TextChanged += new System.EventHandler(this.txtSenhaL_TextChanged);
            // 
            // lblSenhaL
            // 
            resources.ApplyResources(this.lblSenhaL, "lblSenhaL");
            this.lblSenhaL.Name = "lblSenhaL";
            this.lblSenhaL.Click += new System.EventHandler(this.lblSenhaL_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtCPFL
            // 
            resources.ApplyResources(this.txtCPFL, "txtCPFL");
            this.txtCPFL.Name = "txtCPFL";
            this.txtCPFL.TextChanged += new System.EventHandler(this.txtCPFL_TextChanged);
            // 
            // lblCPFL
            // 
            resources.ApplyResources(this.lblCPFL, "lblCPFL");
            this.lblCPFL.Name = "lblCPFL";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaL);
            this.Controls.Add(this.lblSenhaL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPFL);
            this.Controls.Add(this.lblCPFL);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaL;
        private System.Windows.Forms.Label lblSenhaL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPFL;
        private System.Windows.Forms.Label lblCPFL;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}