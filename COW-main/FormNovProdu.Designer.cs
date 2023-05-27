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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_valorproduto = new System.Windows.Forms.TextBox();
            this.txt_codigoproduto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_nomeproduto = new System.Windows.Forms.TextBox();
            this.txt_adicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 478);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(762, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 89;
            this.textBox2.Text = "Valor";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Location = new System.Drawing.Point(513, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 90;
            this.textBox3.Text = "Código";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.Location = new System.Drawing.Point(18, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(489, 20);
            this.textBox4.TabIndex = 88;
            this.textBox4.Text = "Nome do Produto";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 44);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(926, 429);
            this.dataGridView2.TabIndex = 83;
            // 
            // txt_valorproduto
            // 
            this.txt_valorproduto.Location = new System.Drawing.Point(594, 28);
            this.txt_valorproduto.Name = "txt_valorproduto";
            this.txt_valorproduto.Size = new System.Drawing.Size(175, 20);
            this.txt_valorproduto.TabIndex = 94;
            this.txt_valorproduto.Text = "Digite Valor do Produto...";
            // 
            // txt_codigoproduto
            // 
            this.txt_codigoproduto.Location = new System.Drawing.Point(341, 28);
            this.txt_codigoproduto.Name = "txt_codigoproduto";
            this.txt_codigoproduto.Size = new System.Drawing.Size(247, 20);
            this.txt_codigoproduto.TabIndex = 93;
            this.txt_codigoproduto.Text = "Digite Código do Produto...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 92;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 91;
            this.button2.Text = "Adicionar Produto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_nomeproduto
            // 
            this.txt_nomeproduto.Location = new System.Drawing.Point(13, 28);
            this.txt_nomeproduto.Name = "txt_nomeproduto";
            this.txt_nomeproduto.Size = new System.Drawing.Size(322, 20);
            this.txt_nomeproduto.TabIndex = 90;
            this.txt_nomeproduto.Text = "Digite Nome do Produto...";
            // 
            // txt_adicionar
            // 
            this.txt_adicionar.Location = new System.Drawing.Point(775, 12);
            this.txt_adicionar.Name = "txt_adicionar";
            this.txt_adicionar.Size = new System.Drawing.Size(174, 50);
            this.txt_adicionar.TabIndex = 89;
            this.txt_adicionar.Text = "Adicionar";
            this.txt_adicionar.UseVisualStyleBackColor = true;
            // 
            // FormNovProdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_valorproduto);
            this.Controls.Add(this.txt_codigoproduto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_nomeproduto);
            this.Controls.Add(this.txt_adicionar);
            this.Name = "FormNovProdu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.FormNovProdu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_valorproduto;
        private System.Windows.Forms.TextBox txt_codigoproduto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_nomeproduto;
        private System.Windows.Forms.Button txt_adicionar;
    }
}