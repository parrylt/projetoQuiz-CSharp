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
    public partial class Que7 : Form
    {
        public Que7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qrb1.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }
            Que8 que8 = new Que8();
            que8.Show();
            this.Hide();
        }
    }
}
