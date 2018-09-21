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


namespace GroupProject
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString: "Data Source=ACER-PC\\SQLEXPRESS;Initial Catalog=acadamy_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = InsertData(con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Data saved!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            Clear();
        }
         void Clear()
        {
            txtTitle.Clear();
            txtPrice.Clear();
            txtPositions.Clear();
            txtDiscription.Clear();
            txtdateEnd.Clear();
            txtdateStart.Clear();
        }
      

        private SqlCommand InsertData(SqlConnection con)
        {
            return new SqlCommand("insert into courses values('" + txtTitle.Text + "','" + txtPrice.Text + "','" + txtdateStart.Text + "','" + txtdateEnd.Text + "','" + txtPositions.Text + "','" + txtDiscription.Text + "')", con);
        }

        private void btnDiscardCourse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateStart_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value!");
            }
        }

        private void txtPositions_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value!");
            }
        }

        private void txtdateEnd_Validating(object sender, CancelEventArgs e)
        {
           


        }

        private void txtdateStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
