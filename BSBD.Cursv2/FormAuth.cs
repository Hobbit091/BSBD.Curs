using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD.Cursv2
{
    public partial class FormAuth : Form  
    {
        public FormAuth()
        {
            InitializeComponent();
        }
        public static class Role
        {
            public static string SharedRole { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int userCount = 0;
            Hash hs= new Hash();
            string sqlUpdate = @"SELECT * from Role WHERE (Username=@Nick) AND (Password=@Pass)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.DiamondCasinoConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@Nick", textBoxLog.Text);
            string pass = hs.HashSecret(textBoxPass.Text);
            command.Parameters.AddWithValue("@Pass", pass);
            command.CommandText = sqlUpdate;
            command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
               
                while (reader.Read())
                {
                    string userRole = reader["Role"].ToString();
                    Role.SharedRole = userRole;
                    userCount++;
                }
            }
            if (userCount > 0)
            {
                
                this.Hide();
                var mainForm = new FormMain();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Некоррентно введенные данные");
            }
            connection.Close();
            
        }
    }
}
