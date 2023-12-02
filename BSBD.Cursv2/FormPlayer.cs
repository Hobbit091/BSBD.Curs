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
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        private void игрокBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.игрокBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diamondCasinoDataSet);

        }
        private static FormPlayer f;
        public static FormPlayer fp { 
            get
            {
                if (f == null || f.IsDisposed) f = new FormPlayer();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        private string role = FormAuth.Role.SharedRole.Trim();
        private void FormPlayer_Load(object sender, EventArgs e)
        {
            if (role == "Crp")
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                игрокBindingNavigatorSaveItem.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diamondCasinoDataSet.Игрок". При необходимости она может быть перемещена или удалена.
            this.игрокTableAdapter.Fill(this.diamondCasinoDataSet.Игрок);

        }

        private void Stop(object sender, MouseEventArgs e)
        {
            if (role == "Crp")
                MessageBox.Show("Отказано");
        }
    }
}
