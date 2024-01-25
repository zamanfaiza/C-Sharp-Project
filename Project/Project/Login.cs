using Guna.UI.Animation;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

using iText.Kernel.Pdf;
using iText.Layout;

using Syncfusion.Pdf.Graphics;
using iText.StyledXmlParser.Node;
using iText.Layout.Element;
using System;
using System.Diagnostics;
using iText.Layout.Borders;
using iText.Layout.Properties;
using iText.IO.Image;

namespace Project
{
    public partial class Login : Form
    {
        bool flag3 = false;
        
        public Login()
        {

            InitializeComponent();
            
        }

        public static CDashboard customerD;

        
        public static string loginusername = string.Empty;
        private void haveAccount_Click(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            //this.Close();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

          
            string uname = usernameText.Text;
            string pass = passwordText.Text;

            if(uname == "Admin" && pass == "admin")
            {
                AdminHome adminHome = new AdminHome();
                adminHome.ShowDialog();
                this.Hide();
                return;
            }

            if (uname == "Enter Your Username" || uname == "")
            {
                MessageBox.Show("Enter Your Username");
                return;
            }

            else if (pass == "Enter Your Password" || pass == "")
            {
                MessageBox.Show("Enter Your Password");
                return;
            }


            // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="D:\OneDrive - American International University-Bangladesh\C#\Project\DataStorage.mdf";Integrated Security=True

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from UserInfo where username = '" + usernameText.Text + "' and password = '" + passwordText.Text + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                //MessageBox.Show("Login Successful");
                loginusername = usernameText.Text;
                customerD = new CDashboard();
               // customerD = cd;
                customerD.Show();
                this.Hide();

            }
            else
            {
                 MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            passwordText.UseSystemPasswordChar = false;
            flag3 = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {

            hideButton.Visible = false;
            showButton.Visible = true;
            passwordText.UseSystemPasswordChar = true;
            flag3 = false;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (flag3 == false)
                passwordText.UseSystemPasswordChar = true;
            else
                passwordText.UseSystemPasswordChar = false;
        }

        private void forgetButton_Click(object sender, EventArgs e)
        {
            Reset r = new Reset();
            r.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_Load(object sender, EventArgs e)
        {

        }
    }
}
