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
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=final ");
        MySqlCommand comm;
        public Form3()
        {
            InitializeComponent();
        }

        private void open_connection()
        {
            con.Open();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            open_connection();
            ////  load_status_griddata_init();
        }

        private void load_status_griddata_init(string ctext)
        {
            string sql = ctext;
            comm = new MySqlCommand(sql, con);
            comm.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            var name = name_textBox.Text;
            var surname = surname_textBox.Text;
            var email = email_textBox.Text;
            var phone = phone_textBox.Text;
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@surname", surname);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@phone", phone);
            da.Fill(ds, "historyorder");
            dataGridView1.DataSource = ds.Tables["historyorder"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = name_textBox.Text;
            var surname = surname_textBox.Text;
            var email = email_textBox.Text;
            var phone = phone_textBox.Text;
            if (name == "" || surname == "" || email == "" || phone == "")
            {
                MessageBox.Show("Please Insert All Information before check");
            }
            else
            {
                comm = con.CreateCommand();
                comm.CommandText = "call historyorder" +
                    "(@name , @surname , @email , @phone , message) ";
                string ctext = "call historyorder" +
                    "(@name , @surname , @email , @phone , message) ";
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@surname", surname);
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@phone", phone);
                try
                {
                    int rowsAffected = comm.ExecuteNonQuery();
                    MessageBox.Show("Select Data Completed!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                load_status_griddata_init(ctext);
            }
        }
    }
}
