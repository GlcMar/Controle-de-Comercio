namespace COW
{
    partial class FormDevedores
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.listView13 = new System.Windows.Forms.ListView();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView11 = new System.Windows.Forms.ListView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnDevedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(1036, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 26);
            this.textBox1.TabIndex = 55;
            this.textBox1.Text = "Itens Em divida";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.Location = new System.Drawing.Point(765, 160);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(410, 26);
            this.textBox5.TabIndex = 54;
            this.textBox5.Text = "Digite  CPF do devedor...";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.listView13);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listView11);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(378, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1479, 769);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(795, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(637, 350);
            this.dataGridView1.TabIndex = 84;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(438, 112);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(126, 26);
            this.textBox7.TabIndex = 83;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 26);
            this.textBox2.TabIndex = 82;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1260, 580);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 77);
            this.button4.TabIndex = 69;
            this.button4.Text = "Divida Paga";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 77);
            this.button2.TabIndex = 59;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox14.Location = new System.Drawing.Point(438, 69);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(126, 26);
            this.textBox14.TabIndex = 66;
            this.textBox14.Text = "Quantidade";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox15.Location = new System.Drawing.Point(78, 69);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(331, 26);
            this.textBox15.TabIndex = 65;
            this.textBox15.Text = "Itens";
            // 
            // listView13
            // 
            this.listView13.HideSelection = false;
            this.listView13.Location = new System.Drawing.Point(1528, 366);
            this.listView13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView13.Name = "listView13";
            this.listView13.Size = new System.Drawing.Size(0, 0);
            this.listView13.TabIndex = 64;
            this.listView13.UseCompatibleStateImageBehavior = false;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox13.Location = new System.Drawing.Point(237, 29);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(199, 26);
            this.textBox13.TabIndex = 63;
            this.textBox13.Text = "Adicionar Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1124, 691);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 62;
            this.label3.Text = "Valor Total";
            // 
            // listView11
            // 
            this.listView11.HideSelection = false;
            this.listView11.Location = new System.Drawing.Point(1260, 666);
            this.listView11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView11.Name = "listView11";
            this.listView11.Size = new System.Drawing.Size(170, 92);
            this.listView11.TabIndex = 61;
            this.listView11.UseCompatibleStateImageBehavior = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox6.Location = new System.Drawing.Point(1134, 69);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(296, 26);
            this.textBox6.TabIndex = 58;
            this.textBox6.Text = "Valor";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Location = new System.Drawing.Point(795, 69);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 26);
            this.textBox3.TabIndex = 56;
            this.textBox3.Text = "Itens";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1204, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 77);
            this.button3.TabIndex = 69;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 77);
            this.button1.TabIndex = 50;
            this.button1.Text = "Novo Devedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(18, 160);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(230, 134);
            this.btnVenda.TabIndex = 47;
            this.btnVenda.Text = "Vendas";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(18, 497);
            this.btnProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(230, 134);
            this.btnProduto.TabIndex = 48;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnDevedor
            // 
            this.btnDevedor.Location = new System.Drawing.Point(102, 857);
            this.btnDevedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDevedor.Name = "btnDevedor";
            this.btnDevedor.Size = new System.Drawing.Size(230, 134);
            this.btnDevedor.TabIndex = 49;
            this.btnDevedor.Text = "Devedores";
            this.btnDevedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1678, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 55;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(274, 285);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 85;
            this.textBox4.Text = "CPFAtribuido";
            // 
            // FormDevedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1025);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnDevedor);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDevedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDevedores";
            this.Load += new System.EventHandler(this.FormDevedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnDevedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.ListView listView13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView11;
        private System.Windows.Forms.TextBox textBox4;
    }
}