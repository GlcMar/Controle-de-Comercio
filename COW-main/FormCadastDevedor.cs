﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COW
{
    public partial class FormCadastDevedor : Form
    {
      
        public FormCadastDevedor()
        {
            InitializeComponent();
        }

        private void FormCadastDevedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDevedores devedores = new FormDevedores();
            devedores.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
          

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexoes conexoes = new Conexoes();
            conexoes.CadastroDeDevedores(textBox1.Text, textBox2.Text, textBox3.Text, textBox11.Text);

            textBox1.Text = "Digite o nome do Cliente.";
            textBox2.Text = "CPF do novo cliente.";
            textBox3.Text = "Nome do produto";
            textBox11.Text = "Valor desse produto";

        }
    }
}
