using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace projetoQuiz
{
    public partial class Que1 : Form
    {
        public Que1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (q1rb2.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }
            SoundPlayer musica = new SoundPlayer(Properties.Resources.facetoface);
            musica.Stop();
            Que2 que2 = new Que2();
            que2.Show();
            this.Hide();
        }

        private void Que1_Load(object sender, EventArgs e)
        {
            SoundPlayer musica = new SoundPlayer(Properties.Resources.facetoface);
            musica.Play();
        }
    }
}
