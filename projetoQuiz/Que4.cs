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
    public partial class Que4 : Form
    {
        public Que4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qrb2.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }
            Que5 que5 = new Que5();
            que5.Show();
            this.Hide();
        }
    }
}
