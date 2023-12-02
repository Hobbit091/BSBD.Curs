using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BSBD.Cursv2.FormAuth;

namespace BSBD.Cursv2
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void играBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.играBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diamondCasinoDataSet);

        }
        private static FormGame f;
        public static FormGame fg
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormGame();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        private string role = FormAuth.Role.SharedRole.Trim();
        private void FormGame_Load(object sender, EventArgs e)
        {
            if (role == "Crp")
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                играBindingNavigatorSaveItem.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diamondCasinoDataSet.Игра". При необходимости она может быть перемещена или удалена.
            this.играTableAdapter.Fill(this.diamondCasinoDataSet.Игра);

        }

        private void Stop(object sender, DataGridViewCellEventArgs e)
        {
            if (role == "Crp")
                MessageBox.Show("Отказано");
        }
    }
}
