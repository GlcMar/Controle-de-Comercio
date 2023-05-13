namespace Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTcod = new System.Windows.Forms.TextBox();
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.TXTfone = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dtGridUsuario = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cBoPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(41, 36);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(25, 13);
            this.cod.TabIndex = 0;
            this.cod.Text = "cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "usuario";
            // 
            // TXTcod
            // 
            this.TXTcod.Location = new System.Drawing.Point(72, 33);
            this.TXTcod.Name = "TXTcod";
            this.TXTcod.Size = new System.Drawing.Size(100, 20);
            this.TXTcod.TabIndex = 0;
            this.TXTcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTcod_KeyPress);
            this.TXTcod.MouseLeave += new System.EventHandler(this.TXTcod_MouseLeave);
            this.TXTcod.MouseHover += new System.EventHandler(this.TXTcod_MouseHover);
            // 
            // TXTusuario
            // 
            this.TXTusuario.Location = new System.Drawing.Point(72, 57);
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(100, 20);
            this.TXTusuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nome";
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(72, 79);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(100, 20);
            this.TXTnome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "fone";
            // 
            // TXTemail
            // 
            this.TXTemail.Location = new System.Drawing.Point(72, 107);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(100, 20);
            this.TXTemail.TabIndex = 3;
            // 
            // TXTfone
            // 
            this.TXTfone.Location = new System.Drawing.Point(69, 133);
            this.TXTfone.Name = "TXTfone";
            this.TXTfone.Size = new System.Drawing.Size(100, 20);
            this.TXTfone.TabIndex = 4;
            // 
            // Cadastrar
            // 
            this.Cadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cadastrar.Location = new System.Drawing.Point(87, 271);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 6;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(190, 271);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dtGridUsuario
            // 
            this.dtGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsuario.Location = new System.Drawing.Point(361, 52);
            this.dtGridUsuario.Name = "dtGridUsuario";
            this.dtGridUsuario.Size = new System.Drawing.Size(377, 281);
            this.dtGridUsuario.TabIndex = 13;
            this.dtGridUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUsuario_CellClick);
            this.dtGridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUsuario_CellContentClick);
            // 
            // cBoPerfil
            // 
            this.cBoPerfil.FormattingEnabled = true;
            this.cBoPerfil.Location = new System.Drawing.Point(69, 174);
            this.cBoPerfil.Name = "cBoPerfil";
            this.cBoPerfil.Size = new System.Drawing.Size(121, 21);
            this.cBoPerfil.TabIndex = 5;
            this.cBoPerfil.SelectedIndexChanged += new System.EventHandler(this.cBoPerfil_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Perfil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(83, 234);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(179, 328);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // picFoto
            // 
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(190, 33);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(150, 103);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 21;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(190, 143);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(35, 13);
            this.lblFoto.TabIndex = 22;
            this.lblFoto.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoPerfil);
            this.Controls.Add(this.dtGridUsuario);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.TXTfone);
            this.Controls.Add(this.TXTemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTusuario);
            this.Controls.Add(this.TXTcod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cod);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.Label label2;
    //    private System.Windows.Forms.Button BTNCadastrar;
        private System.Windows.Forms.TextBox TXTcod;
        private System.Windows.Forms.TextBox TXTusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.TextBox TXTfone;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dtGridUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cBoPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFoto;
    }
}

