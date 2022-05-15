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
namespace InventoryManagementSystem
{
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dilsh\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void customerButton1_Click(object sender, EventArgs e)
        {
            CustomerModuleForm moduleForm = new CustomerModuleForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }

        private void customerButton1_Click_1(object sender, EventArgs e)
        {
            CustomerModuleForm moduleForm = new CustomerModuleForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colname == "edit")
            {
                CustomerModuleForm CustomerModule = new CustomerModuleForm();
                CustomerModule.IbCld.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                CustomerModule.cname.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                CustomerModule.cphone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();

                CustomerModule.btnSave.Enabled = false;
                CustomerModule.btnUpdate.Enabled = true;
                CustomerModule.ShowDialog();
            }

            else if (colname == "delete")
            {
                if (MessageBox.Show("Do you want to delete this", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCustomer Where cid LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadCustomer();
        }
    }
}
