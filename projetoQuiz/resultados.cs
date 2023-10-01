using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoQuiz
{
    public partial class resultados : Form
    {
        public resultados()
        {
            InitializeComponent();
        }

        private void resultados_Load(object sender, EventArgs e)
        {
            if ((Dados.Acertos >= 0) && (Dados.Acertos <= 3))
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nBURRO! BURRO! BURRO!";
            }
            if ((Dados.Acertos >= 4) && (Dados.Acertos <= 7))
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nPrecisa melhorar!";
            }
            if ((Dados.Acertos >= 7) && (Dados.Acertos <= 9))
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nMuito bem! Brabo demais!";
            }
            if (Dados.Acertos == 10)
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nACERTOU TUDO MIZERÁVI!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Dados.Acertos = 0;
        Dados.Erros = 0;
        Form1 que12 = new Form1();
        que12.Show();
        this.Hide();
    }
    }
}
