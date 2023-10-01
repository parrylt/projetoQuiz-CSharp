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
    public partial class Que8 : Form
    {
        public Que8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qrb3.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }
            Que9 que9 = new Que9();
            que9.Show();
            this.Hide();
        }
    }
}
