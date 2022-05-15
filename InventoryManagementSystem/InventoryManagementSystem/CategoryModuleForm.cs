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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dilsh\OneDrive\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to save this Category", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCategory(catname)VALUES(@catname)", con);
                    cm.Parameters.AddWithValue("@catname", CatName.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been succesfully saved");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        public void Clear()
        {
            CatName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update this Category", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbCategory SET catname=@catname WHERE catid LIKE '" + IbCatld.Text + "'", con);
                    cm.Parameters.AddWithValue("@catname", CatName.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been succesfully updated");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
