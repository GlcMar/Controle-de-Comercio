namespace Teste
{
    partial class FrmListarUsuario
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
            this.ListarUsuarioPerfil = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ListarUsuarioPerfil
            // 
            this.ListarUsuarioPerfil.Location = new System.Drawing.Point(186, 99);
            this.ListarUsuarioPerfil.Name = "ListarUsuarioPerfil";
            this.ListarUsuarioPerfil.Size = new System.Drawing.Size(201, 226);
            this.ListarUsuarioPerfil.TabIndex = 0;
            // 
            // FrmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListarUsuarioPerfil);
            this.Name = "FrmListarUsuario";
            this.Text = "FrmListarUsuario";
            this.Load += new System.EventHandler(this.FrmListarUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ListarUsuarioPerfil;
    }
}