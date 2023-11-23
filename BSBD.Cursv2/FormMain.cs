using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD.Cursv2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Точно? Точно преточно?", "Опа", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }
        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, я бедный Молдавский хакер, давай ты сам отправишь мне деньги и удалишь какие нибудь важные файлы", "(C) ТУСУР, БИС, 7411, 2023, Абдуллин Р.Н", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonИгрок_Click(object sender, EventArgs e)
        {
            FormPlayer.fp.ShowForm();
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            FormBet.fb.ShowForm();
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            FormGame.fg.ShowForm();
        }

        private void buttonCroupier_Click(object sender, EventArgs e)
        {
            FormCroupier.fс.ShowForm();
        }

        private void buttonGameList_Click(object sender, EventArgs e)
        {
            FormGameList.fgs.ShowForm();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show(FormAuth.Role.SharedRole);
        }
    }
}
