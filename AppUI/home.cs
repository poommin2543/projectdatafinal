using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppUI
{
    public partial class home_Form : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=final");

        public home_Form()
        {
            InitializeComponent();
        }

        private int picnum = 1;

        private void slidepicture()
        {
            if (picnum == 4)
            { picnum = 1; }
            slideimage.ImageLocation = string.Format(@"pic\{0}.jpg", picnum);
            picnum++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slidepicture();
        }

        private void add1_button_Click(object sender, EventArgs e)
        {
            //  vga nvidia    p_id = 3    price = 2100 
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                 "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id", 3);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", 1);
            comm.Parameters.AddWithValue("price", null);

            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                //MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void add2_button_Click(object sender, EventArgs e)
        {
            //  csgo    p_id = 7    price = 169
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                 "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id", 7);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", 1);
            comm.Parameters.AddWithValue("@price", null);
            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                //MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void add3_button_Click(object sender, EventArgs e)
        {
            //  headphone    p_id = 19    price = 199
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                 "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id",19);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", 1);
            comm.Parameters.AddWithValue("@price", null);
            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                //MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void add4_button_Click(object sender, EventArgs e)
        {
            //  ssd 250    p_id = 15    price = 1399
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                  "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id", 15);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", 1);
            comm.Parameters.AddWithValue("@price", null);
            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                //MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void add5_button_Click(object sender, EventArgs e)
        {
            //  mouse    p_id = 5    price = 200
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                 "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id", 5);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", 1);
            comm.Parameters.AddWithValue("@price", null);
            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                //MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void add6_button_Click(object sender, EventArgs e)
        {
            //  witcher    p_id = 8    price = 369
            con.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                  "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id", 8);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", 1);
            comm.Parameters.AddWithValue("@price", null);
            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                //MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
