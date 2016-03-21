using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedLogin
{
    public partial class Informations : MetroForm
    {
        string databaseLocation = "C:\\Users\\Shuvro\\Documents\\Visual Studio 2015\\Projects\\AdvancedLogin\\AdvancedLogin\\AdminLogin.mdf";

        public Informations()
        {
            InitializeComponent();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + databaseLocation + ";Integrated Security=True";
                SqlConnection con = new SqlConnection(@constr);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE adminLogin SET Username = '" + textBox_un_update.Text + "', Password= '" + textBox_pw_update.Text+"'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewRegistration_Click(object sender, EventArgs e)
        {

        }

    }
}
