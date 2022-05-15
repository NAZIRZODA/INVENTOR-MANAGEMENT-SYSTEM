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

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dilsh\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit app", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", textBox1.Text);
                cm.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm min = new MainForm();
                    this.Hide();
                    min.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID username or password!", "ACCESS DENITED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
