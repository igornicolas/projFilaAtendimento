using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFilaAtendimento
{
    public partial class Form1 : Form
    {
        Guiches NovosGuiches = new Guiches();
        Senhas NovasSenhas = new Senhas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            NovasSenhas.gerar();   
            listBox1.Items.Add(NovasSenhas.FilaSenhas.Last().dadosParciais());
            NovasSenhas.ProximoAtendimento++;
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            NovosGuiches.adicionar(new Guiche());
            ;
            lblNumeroGuiches.Text =NovosGuiches.ListaGuiches.Count().ToString();
            
        }

        private void btnChamarSenha_Click(object sender, EventArgs e)
        {
            int idDoGuiche = 0;
            bool numGuiche = true;
            try {
                idDoGuiche = int.Parse(txtBoxGuiche.Text);
                idDoGuiche--;
            } catch (Exception ex) { MessageBox.Show("Digitar um numero de guichê"); numGuiche = false; }
            if (numGuiche)
            {
                NovosGuiches.ListaGuiches[idDoGuiche].chamar(NovasSenhas.FilaSenhas);
            }
            
            try { listBox1.Items.RemoveAt(0); } 
            catch(Exception ex) { MessageBox.Show("Não existem mais senhas para serem chamadas");  }
            
            
        }

        private void txtBoxGuiche_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int idDoGuiche = 0;
            bool guicheValido = true;
            try
            {
                idDoGuiche = int.Parse(txtBoxGuiche.Text);
                idDoGuiche--;
                guicheValido = true;
            }
            catch (Exception ex){
                MessageBox.Show("Digite um numero de Guiche válido!");
                guicheValido = false;
            }
            if (guicheValido)
            {
                try { 
                foreach (Senha s in NovosGuiches.ListaGuiches[idDoGuiche].Atendimentos)
                {
                    listBox2.Items.Add(s.dadosCompletos());
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Digite um numero de Guiche Existente!");
                }
            }
            
        }
    }
}
