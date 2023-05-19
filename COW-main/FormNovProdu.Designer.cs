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
            this.txt_nomeproduto = new System.Windows.Forms.TextBox();
            this.txt_adicionar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_valorproduto
            // 
            this.txt_valorproduto.Location = new System.Drawing.Point(789, 43);
            this.txt_valorproduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_valorproduto.Name = "txt_valorproduto";
            this.txt_valorproduto.Size = new System.Drawing.Size(320, 26);
            this.txt_valorproduto.TabIndex = 81;
            this.txt_valorproduto.Text = "Digite Valor do Produto...";
            // 
            // txt_codigoproduto
            // 
            this.txt_codigoproduto.Location = new System.Drawing.Point(426, 43);
            this.txt_codigoproduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_codigoproduto.Name = "txt_codigoproduto";
            this.txt_codigoproduto.Size = new System.Drawing.Size(320, 26);
            this.txt_codigoproduto.TabIndex = 80;
            this.txt_codigoproduto.Text = "Digite Código do Produto...";
            this.txt_codigoproduto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 880);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 77);
            this.button3.TabIndex = 79;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1162, 880);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 77);
            this.button2.TabIndex = 78;
            this.button2.Text = "Concluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_nomeproduto
            // 
            this.txt_nomeproduto.Location = new System.Drawing.Point(20, 43);
            this.txt_nomeproduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nomeproduto.Name = "txt_nomeproduto";
            this.txt_nomeproduto.Size = new System.Drawing.Size(364, 26);
            this.txt_nomeproduto.TabIndex = 74;
            this.txt_nomeproduto.Text = "Digite Nome do Produto...";
            this.txt_nomeproduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_adicionar
            // 
            this.txt_adicionar.Location = new System.Drawing.Point(1162, 18);
            this.txt_adicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_adicionar.Name = "txt_adicionar";
            this.txt_adicionar.Size = new System.Drawing.Size(261, 77);
            this.txt_adicionar.TabIndex = 73;
            this.txt_adicionar.Text = "Adicionar";
            this.txt_adicionar.UseVisualStyleBackColor = true;
            this.txt_adicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1349, 230);
            this.dataGridView2.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(811, 652);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 26);
            this.textBox1.TabIndex = 87;
            this.textBox1.Text = "Digite Valor do Produto...";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(42, 652);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(364, 26);
            this.textBox6.TabIndex = 85;
            this.textBox6.Text = "Digite Nome do Produto...";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(448, 652);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(320, 26);
            this.textBox5.TabIndex = 86;
            this.textBox5.Text = "Digite Código do Produto...";
            // 
            // FormNovProdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 975);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_valorproduto);
            this.Controls.Add(this.txt_codigoproduto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_nomeproduto);
            this.Controls.Add(this.txt_adicionar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNovProdu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.FormNovProdu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valorproduto;
        private System.Windows.Forms.TextBox txt_codigoproduto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_nomeproduto;
        private System.Windows.Forms.Button txt_adicionar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}