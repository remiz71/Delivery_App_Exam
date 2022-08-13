using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Delivery_App_Exam
{
    public partial class AddWindow : Form
    {
        
        public AddWindow()
        {
            InitializeComponent();
}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["delivery"].ConnectionString))
            {
                conn.Open();
                SqlCommand addCarier = new SqlCommand("stp_Add_Carrier",conn);
                addCarier.CommandType = CommandType.StoredProcedure;
                addCarier.Parameters.AddWithValue("FirstName", textBox1.Text);
                addCarier.Parameters.AddWithValue("LastName", textBox2.Text);
                addCarier.Parameters.AddWithValue("BirthDate",dateTimePicker1.Value);
                addCarier.Parameters.AddWithValue("HaveLicense", radioButton1.Checked);
                if(radioButton1.Checked == false)
                {
                addCarier.Parameters.AddWithValue("LicenseCategory", DBNull.Value);

                }
                else addCarier.Parameters.AddWithValue("LicenseCategory", comboBox1.SelectedItem.ToString());
                addCarier.Parameters.AddWithValue("Id", 1);

                addCarier.ExecuteNonQuery();
                conn.Close();
                Close();
                MessageBox.Show("Добавлен водитель", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении Водителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
