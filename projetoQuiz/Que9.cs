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
    public partial class Que9 : Form
    {
        public Que9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qrb4.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }
            Que10 que10 = new Que10();
            que10.Show();
            this.Hide();
        }
    }
}
