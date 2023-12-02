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
    public partial class FormCroupier : Form
    {
        public FormCroupier()
        {
            InitializeComponent();
        }

        private void крупьеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.крупьеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diamondCasinoDataSet);

        }
        private static FormCroupier f;
        public static FormCroupier fс
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormCroupier();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        private string role = FormAuth.Role.SharedRole.Trim();
        private void FormCroupier_Load(object sender, EventArgs e)
        {
            if (role == "Adm" | role=="Crp")
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                крупьеBindingNavigatorSaveItem.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diamondCasinoDataSet.Крупье". При необходимости она может быть перемещена или удалена.
            this.крупьеTableAdapter.Fill(this.diamondCasinoDataSet.Крупье);

        }
   

        private void Stop(object sender, MouseEventArgs e)
        {
            if (role == "Adm" | role=="Crp")
                MessageBox.Show("Отказано");
        }
    }
}
