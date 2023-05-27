namespace COW
{
    partial class FormProduto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnDevedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(241, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 575);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(842, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 59;
            this.textBox1.Text = "Valor";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 44);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(992, 526);
            this.dataGridView2.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(549, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 57;
            this.textBox2.Text = "Código";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox5.Location = new System.Drawing.Point(25, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(518, 20);
            this.textBox5.TabIndex = 58;
            this.textBox5.Text = "Nome do Produto";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 64;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1043, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 51);
            this.button3.TabIndex = 63;
            this.button3.Text = "Excluir Produto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 51);
            this.button2.TabIndex = 62;
            this.button2.Text = "Editar Produto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 51);
            this.button1.TabIndex = 61;
            this.button1.Text = "Novo Produto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(22, 84);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(153, 87);
            this.btnVenda.TabIndex = 58;
            this.btnVenda.Text = "Vendas";
            this.btnVenda.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(67, 279);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(153, 87);
            this.btnProduto.TabIndex = 59;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnDevedor
            // 
            this.btnDevedor.Location = new System.Drawing.Point(22, 485);
            this.btnDevedor.Name = "btnDevedor";
            this.btnDevedor.Size = new System.Drawing.Size(153, 87);
            this.btnDevedor.TabIndex = 60;
            this.btnDevedor.Text = "Devedores";
            this.btnDevedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 57;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnDevedor);
            this.Controls.Add(this.label1);
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnDevedor;
        private System.Windows.Forms.Label label1;
    }
}