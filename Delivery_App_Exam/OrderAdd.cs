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
    public partial class OrderAdd : Form
    {
        
        public OrderAdd()
        {
            InitializeComponent();
            CarrierLoader();
            StatusLoader();
        }
        


        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CarrierLoader()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["delivery"].ConnectionString))
            {
                conn.Open();
                SqlCommand fill = new SqlCommand("Select * from CarrierSet", conn);
                SqlDataReader dr = fill.ExecuteReader();
                while (dr.Read())
                {
                    (CB_carrier.Items.Add(dr[0]+ "." + dr[1] + " " + dr[2])).ToString();
                }
                dr.Close();
                conn.Close();
                
            }
        }

        private void StatusLoader()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["delivery"].ConnectionString))
            {
                conn.Open();
                SqlCommand fill = new SqlCommand("Select * from OrderStatusSet", conn);
                SqlDataReader dr = fill.ExecuteReader();
                while (dr.Read())
                {
                    (CB_status.Items.Add(dr[0] + "." + dr[1])).ToString();
                }
                dr.Close();
                conn.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["delivery"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand add = new SqlCommand("stp_OrderInsert", conn);
                    add.CommandType = CommandType.StoredProcedure;
                    add.Parameters.AddWithValue("DeliveryAdress", tb_address.Text);
                    add.Parameters.AddWithValue("OrderDescription", tb_descr.Text);
                    add.Parameters.AddWithValue("OrderDate", dtp_bd.Value);
                    add.Parameters.AddWithValue("DeliveryCost", tb_cost.Text);
                    add.Parameters.AddWithValue("CarrierId", CB_carrier.SelectedIndex + 1);
                    add.Parameters.AddWithValue("OrderStatus_Id", CB_status.SelectedIndex + 1);
                    add.Parameters.AddWithValue("Id", 1);

                    add.ExecuteNonQuery();
                    conn.Close();
                    Close();


                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Не все поля заполнены", "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
