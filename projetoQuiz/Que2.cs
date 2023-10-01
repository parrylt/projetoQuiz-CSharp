using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoQuiz
{
    public partial class Que2 : Form
    {
        public Que2()
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
            SoundPlayer musica = new SoundPlayer(Properties.Resources.my_strange_addiction);
            musica.Stop();
            Que3 que3 = new Que3();
            que3.Show();
            this.Hide();
        }

        private void Que2_Load(object sender, EventArgs e)
        {
            SoundPlayer musica = new SoundPlayer(Properties.Resources.my_strange_addiction);
            musica.Play();
        }
    }
}
