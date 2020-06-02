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
    public partial class acc_Form : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=final ");

        public acc_Form()
        {
            InitializeComponent();
        }

        private void open_connection()
        {
            con.Open();
        }

        private void acc_Form_Load(object sender , EventArgs e)
        {
            open_connection();
            load_set_comboBox(); 
        }

        private void load_set_comboBox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //  case computer     p_id = 29    price = 499 

            var keep = comboBox1.SelectedIndex;
            var quan = keep.ToString();
            int id = 29;
            insert_init(quan, id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  cpu amd     p_id = 2   price = 1000
            var keep = comboBox2.SelectedIndex;
            var quan = keep.ToString();
            int id = 2;
            insert_init(quan, id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  cpu intel     p_id = 1   price = 1200
            var keep = comboBox3.SelectedIndex;
            var quan = keep.ToString();
            int id = 1;
            insert_init(quan, id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  flash Drive     p_id = 24   price = 199
            var keep = comboBox4.SelectedIndex;
            var quan = keep.ToString();
            int id = 24;
            insert_init(quan, id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //  HDD 500     p_id = 13   price = 1200
            var keep = comboBox5.SelectedIndex;
            var quan = keep.ToString();
            int id = 13;
            insert_init(quan, id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //  HDD 1 tb    p_id = 14   price = 2000
            var keep = comboBox6.SelectedIndex;
            var quan = keep.ToString();
            int id = 14;
            insert_init(quan, id);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //  headphone     p_id = 19   price = 199
            var keep = comboBox7.SelectedIndex;
            var quan = keep.ToString();
            int id = 19;
            insert_init(quan, id);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //  keyboard     p_id = 6   price = 300
            var keep = comboBox8.SelectedIndex;
            var quan = keep.ToString();
            int id = 6;
            insert_init(quan, id);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //  Mainboard     p_id = 17   price = 699
            var keep = comboBox9.SelectedIndex;
            var quan = keep.ToString();
            int id = 17;
            insert_init(quan, id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //  Mouse     p_id = 5   price = 200
            var keep = comboBox10.SelectedIndex;
            var quan = keep.ToString();
            int id = 5;
            insert_init(quan, id);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //  ram 4     p_id = 12   price = 299
            var keep = comboBox11.SelectedIndex;
            var quan = keep.ToString();
            int id = 12;
            insert_init(quan, id);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //  ram 8    p_id = 11   price = 499

            var keep = comboBox12.SelectedIndex;
            var quan = keep.ToString();
            int id = 11;
            insert_init(quan, id);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //  ssd 250     p_id = 15   price = 1399
            var keep = comboBox13.SelectedIndex;
            var quan = keep.ToString();
            int id = 15;
            insert_init(quan, id);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //  SSD 500     p_id = 16   price = 2599
            var keep = comboBox14.SelectedIndex;
            var quan = keep.ToString();
            int id = 16;
            insert_init(quan, id);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //  vga amd     p_id = 4  price = 2010
            var keep = comboBox15.SelectedIndex;
            var quan = keep.ToString();
            int id = 4;
            insert_init(quan, id);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //  vga nvidia     p_id = 3   price = 2100
            var keep = comboBox16.SelectedIndex;
            var quan = keep.ToString();
            int id = 3;
            insert_init(quan, id);
        }

        private void insert_init(string quan,int id)
        {

            MySqlCommand comm = new MySqlCommand();

            comm.Connection = con;
            comm.CommandText = "INSERT INTO `final`.`tran` (`number`,`p_id`,`p_name`, `order_id`,`quantity`,`price`) " +
                  "VALUES " + "(@No,@p_id,@p_name, @order_id,@quantity,@price);";
            comm.Parameters.AddWithValue("@No", null);
            comm.Parameters.AddWithValue("@p_id", id);
            comm.Parameters.AddWithValue("@p_name", null);
            comm.Parameters.AddWithValue("@order_id", null);
            comm.Parameters.AddWithValue("@quantity", quan);
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
