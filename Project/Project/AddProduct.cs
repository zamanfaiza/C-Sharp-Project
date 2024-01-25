using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        string path = String.Empty;
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProductPicture.Image = new Bitmap(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                //picturebox2.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string name = text.Text;
            string sku = sabbir.Text;
            string quantity = qty.Text;
            string amount = price.Text;


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

            string query = "INSERT INTO Product (ProductID,ProductName,Price,Quantity,Path) Values('" + sku + "','" + name + "','" + amount + "','" + quantity + "','" + path + "')";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        private void gunaTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            string sku = sabbir.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from Product where SKU = '" + sku + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                taken.Visible = true;
            }
            else
            {
                taken.Visible = false;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cartpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartdatatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void taken_Click(object sender, EventArgs e)
        {

        }

        private void idtext_Click(object sender, EventArgs e)
        {

        }

        private void sabbir_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalamount_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {

        }

        private void topusername5_Click(object sender, EventArgs e)
        {

        }

        private void toppicture5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel15_Click(object sender, EventArgs e)
        {

        }
    }
}
