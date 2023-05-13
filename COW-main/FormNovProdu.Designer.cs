namespace COW
{
    partial class FormNovProdu
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
            this.txt_valorproduto = new System.Windows.Forms.TextBox();
            this.txt_codigoproduto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_nomeproduto = new System.Windows.Forms.TextBox();
            this.txt_adicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_valorproduto
            // 
            this.txt_valorproduto.Location = new System.Drawing.Point(526, 28);
            this.txt_valorproduto.Name = "txt_valorproduto";
            this.txt_valorproduto.Size = new System.Drawing.Size(215, 20);
            this.txt_valorproduto.TabIndex = 81;
            this.txt_valorproduto.Text = "Digite Valor do Produto...";
            // 
            // txt_codigoproduto
            // 
            this.txt_codigoproduto.Location = new System.Drawing.Point(284, 28);
            this.txt_codigoproduto.Name = "txt_codigoproduto";
            this.txt_codigoproduto.Size = new System.Drawing.Size(215, 20);
            this.txt_codigoproduto.TabIndex = 80;
            this.txt_codigoproduto.Text = "Digite Código do Produto...";
            this.txt_codigoproduto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 79;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 78;
            this.button2.Text = "Concluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(28, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(449, 20);
            this.textBox2.TabIndex = 75;
            this.textBox2.Text = "Nome do Produto";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Location = new System.Drawing.Point(730, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 20);
            this.textBox3.TabIndex = 76;
            this.textBox3.Text = "Valor";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.Location = new System.Drawing.Point(483, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 20);
            this.textBox4.TabIndex = 77;
            this.textBox4.Text = "Código do Produto";
            // 
            // txt_nomeproduto
            // 
            this.txt_nomeproduto.Location = new System.Drawing.Point(13, 28);
            this.txt_nomeproduto.Name = "txt_nomeproduto";
            this.txt_nomeproduto.Size = new System.Drawing.Size(244, 20);
            this.txt_nomeproduto.TabIndex = 74;
            this.txt_nomeproduto.Text = "Digite Nome do Produto...";
            this.txt_nomeproduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_adicionar
            // 
            this.txt_adicionar.Location = new System.Drawing.Point(775, 12);
            this.txt_adicionar.Name = "txt_adicionar";
            this.txt_adicionar.Size = new System.Drawing.Size(174, 50);
            this.txt_adicionar.TabIndex = 73;
            this.txt_adicionar.Text = "Adicionar";
            this.txt_adicionar.UseVisualStyleBackColor = true;
            this.txt_adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView3);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 418);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(471, 19);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(233, 393);
            this.listView3.TabIndex = 33;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(718, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(199, 393);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 393);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormNovProdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 634);
            this.Controls.Add(this.txt_valorproduto);
            this.Controls.Add(this.txt_codigoproduto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_nomeproduto);
            this.Controls.Add(this.txt_adicionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNovProdu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.FormNovProdu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valorproduto;
        private System.Windows.Forms.TextBox txt_codigoproduto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_nomeproduto;
        private System.Windows.Forms.Button txt_adicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
    }
}