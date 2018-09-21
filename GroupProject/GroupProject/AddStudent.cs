using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroupProject
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscardStudents(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent(object sender, EventArgs e)
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

        private SqlCommand InsertData(SqlConnection con)
        {
            return new SqlCommand("insert into students values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtPhone.Text +"')", con);
        }

       private void Clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();

        }
    }
}
