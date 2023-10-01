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

  



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar o quiz foda??", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonComecar_Click(object sender, EventArgs e)
        {
            Que1 que1 = new Que1();
            que1.Show();
            this.Hide();
        }
    }

    public class Dados
    {
        public static int Acertos = 0;
        public static int Erros = 0;

        public static void Acertou()
        {
            Acertos++;
        }

        public static void Errou()
        {
            Erros++;
        }

        public static int MostrarAcertos()
        {
            return Acertos;
        }

        public static int MostrarErros()
        {
            return Erros;
        }
    }
}
