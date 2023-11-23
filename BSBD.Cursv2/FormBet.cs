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
    public partial class FormBet : Form
    {
        public FormBet()
        {
            InitializeComponent();
        }

        private void ставкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ставкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diamondCasinoDataSet);

        }
        private string role = FormAuth.Role.SharedRole.Trim();
        private void FormBet_Load(object sender, EventArgs e)
        {
            if (role == "Adm")
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                ставкаBindingNavigatorSaveItem.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diamondCasinoDataSet.Ставка". При необходимости она может быть перемещена или удалена.
            this.ставкаTableAdapter.Fill(this.diamondCasinoDataSet.Ставка);
        }

        private static FormBet f;
        public static FormBet fb
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormBet();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        private void Stop(object sender, DataGridViewCellEventArgs e)
        {
            if (role == "Adm")
                MessageBox.Show("Смотреть но не трогать");
        }
    }
}
