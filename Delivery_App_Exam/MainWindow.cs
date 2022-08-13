using Delivery_App_Exam.DeliveryDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_App_Exam
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deliveryDBDataSet.OrderStatusSet' table. You can move, or remove it, as needed.
            this.orderStatusSetTableAdapter.Fill(this.deliveryDBDataSet.OrderStatusSet);

            // TODO: This line of code loads data into the 'deliveryDBDataSet.OrderSet' table. You can move, or remove it, as needed.
            this.orderSetTableAdapter.Fill(this.deliveryDBDataSet.OrderSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderAdd form = new OrderAdd();
            form.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView2.Visible = true;
            this.carrierSetTableAdapter.Fill(this.deliveryDBDataSet.CarrierSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddWindow add = new AddWindow();
            add.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderSetTableAdapter.Update(deliveryDBDataSet);
            MessageBox.Show("Успешное изменение","Успех", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                UpdateTable();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["delivery"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand Sort = new SqlCommand("stp_OrderByStatusId", conn);
                    Sort.CommandType = CommandType.StoredProcedure;
                    Sort.Parameters.AddWithValue("@StatusID", comboBox1.SelectedIndex + 1);
                    Sort.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(Sort);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["delivery"].ConnectionString))
            {
                conn.Open();
                SqlCommand ALL = new SqlCommand("SELECT * FROM OrderSet", conn);
                SqlDataAdapter da = new SqlDataAdapter(ALL);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0] ;
                conn.Close();

            }
        }
    }
}
