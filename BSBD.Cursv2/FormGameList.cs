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
    public partial class FormGameList : Form
    {
        public FormGameList()
        {
            InitializeComponent();
        }

        private void запись_игрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.запись_игрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diamondCasinoDataSet);

        }
        private static FormGameList f;
        public static FormGameList fgs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormGameList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        private string role = FormAuth.Role.SharedRole.Trim();
        private void FormGameList_Load(object sender, EventArgs e)
        {
            if (role == "Crp")
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diamondCasinoDataSet.Запись_игры". При необходимости она может быть перемещена или удалена.
            this.запись_игрыTableAdapter.Fill(this.diamondCasinoDataSet.Запись_игры);
        }
    }
}
