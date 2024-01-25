using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Web;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {

        public static string full = "";
        public static string ph = "";
        public static string un = "";
        public static string em = string.Empty;
        public static string pa = string.Empty;
        public static string ad = string.Empty;
        public static string path = string.Empty;
        public static string it = string.Empty;
        public Form1()
        {
            InitializeComponent();
            
        }

        public static string eid = "aiub64bit@gmail.com";
        bool flag = false;
        bool flag2 = false;
        bool flag3 = false;
        bool flag4 = false;
        private void signupButton_Click(object sender, EventArgs e)
        {
            string fullname = fullnameText.Text;
            full= fullname;
            string phone = phoneText.Text;
            ph = phone;
            string uname = usernameText.Text;
            un = uname;
            string pass = passwordText.Text;
            pa = pass;
            string email = emailText.Text;
            em= email;
            string add = address.Text;
            ad=add;

            string item = combobox.Text;
            it = item;
            

            eid = email;

             if (fullname == "Enter Your Full Name" || fullname == "")
            {
                MessageBox.Show("Enter Your Full Name");
                return;
            }
            else if (uname == "Enter Your Username" || uname == "")
            {
                MessageBox.Show("Enter Your Username");
                return;
            }

            else if (phone == "Enter Your Phone Number" || phone == "")
            {
                MessageBox.Show("Enter Your Phone Number");
                return;
            }
            else if (email == "Enter Your Username" || email == "")
            {
                MessageBox.Show("Enter Your Email address");
                return;
            }

            else if (pass == "Enter Your Password" || pass == "")
            {
                MessageBox.Show("Enter Your Password");
                return;
            }
            else if (add == "Enter Your Password" || add == "")
            {
                MessageBox.Show("Enter Your Address");
                return;
            }
            
             else if(item == "")
            {
                MessageBox.Show("Select a role");
                return;
            }

            // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="D:\OneDrive - American International University-Bangladesh\C#\Project\DataStorage.mdf";Integrated Security=True

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from UserInfo where username = '" + usernameText.Text + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Username already taken");

            }
            else
            {
                if(flag == false)
                {
                    MessageBox.Show("Invalid Phone Number");
                    return;
                }

                else if (flag2 == false)
                {
                    MessageBox.Show("Minimum 6 characters password needed");
                    return;
                }
                else if(flag4 == false)
                {
                    MessageBox.Show("Invalid Email address");
                    return;
                }
               

                verification v = new verification();
                v.Show();
                this.Hide();
               
            }

        }

        private void fullnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            usernameText.BackColor = Color.White; usernameText.ForeColor = Color.Black;
            string uname = usernameText.Text;



            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from UserInfo where username = '" + uname + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                usernameText.ForeColor = Color.IndianRed;
                tickPicture.Visible = false;
                crossPicture.Visible = true;
                usernameText.FocusedBorderColor = Color.IndianRed;
                usernameText.BackColor = Color.Transparent;
                usernameTaken.Visible = true;


            }
            else
            {

                if (uname == "" || uname == "Enter Your Username")
                {
                    usernameText.FocusedBorderColor = Color.DeepSkyBlue;
                    usernameTaken.Visible = false;
                    usernameText.BackColor = Color.Transparent;
                    usernameText.ForeColor = Color.Green;
                    tickPicture.Visible = false;
                    tickPicture.Visible = false;
                }
                else
                {
                    usernameText.FocusedBorderColor = Color.DeepSkyBlue;
                    crossPicture.Visible = false;
                    usernameText.ForeColor = Color.Green;
                    tickPicture.Visible = true;
                    usernameText.BackColor = Color.Transparent;
                    crossPicture.Visible = false;
                    usernameTaken.Visible = false;
                }


            }
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            string phone = phoneText.Text;
            char p;
            int n = phone.Length;
            int k = 0;
            if (n != 0)
            {
                p = phone[n - 1];
                k = Convert.ToInt32(p);
            }
            else p = '\0';

            if (k < 48 || k > 57)
            {
                phoneText.ForeColor = Color.Red;
                phoneText.FocusedBorderColor = Color.Red;
                phoneTaken.Visible = true;
                tickPicture2.Visible = false;
                crossPicture2.Visible = true;
                flag = false;
                phoneText.Text = "";

            }
            else {
                if (phone == "" || phone.Length < 11)
                {
                    phoneText.ForeColor = Color.Red;
                    phoneText.FocusedBorderColor = Color.Red;
                    phoneTaken.Visible = true;
                    tickPicture2.Visible = false;
                    crossPicture2.Visible = true;
                    flag = false;

                }
                else
                {
                        phoneText.ForeColor = Color.Green;
                        phoneText.FocusedBorderColor = Color.DeepSkyBlue;
                        phoneTaken.Visible = false;
                        tickPicture2.Visible = true;
                        crossPicture2.Visible = false;
                        flag = true;

                }
            }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if(flag3==false)
            passwordText.UseSystemPasswordChar = true ;
            else passwordText.UseSystemPasswordChar = false ;

            string pass = passwordText.Text;
            if (pass == "" || pass.Length < 6 )
            {
                passwordText.ForeColor = Color.IndianRed;
                passwordText.FocusedBorderColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                flag2= false;
               

            }
            else
            {
                passwordText.ForeColor = Color.Green;
                passwordText.FocusedBorderColor = Color.DeepSkyBlue;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.Green;
                flag2= true;



            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {


            hideButton.Visible = false;
            showButton.Visible = true;
            showButton.BringToFront();
            passwordText.UseSystemPasswordChar = true;
            flag3 = true;


        }

        private void showButton_Click(object sender, EventArgs e)
        {

            hideButton.Visible = true;
            showButton.Visible = false;
            hideButton.BringToFront();
            passwordText.UseSystemPasswordChar = false;
            flag3 = true;


        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            //this.Close();
            
        }
        bool f = false;
        private void emailText_TextChanged(object sender, EventArgs e)
        {   
            
            string email = emailText.Text;

            
            
                for (int i = 0; i < email.Length; i++)
                {
                
                    if (email[i] == '@')
                    {
                        for(int j = 0; j < email.Length; j++)
                        {
                            if (email[j] == '.')
                            {
                                f = true;
                                break;
                            }
                        }
                        if(f==true) { break; }
                        
                    
                                 
                    }
                     else f= false;
                  

                }
            if(f==false) 
            {
                emailTaken.Visible = true;
                flag4 = false;
            }
            else
            {
                emailTaken.Visible = false;
                flag4 = true;
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showButton.BringToFront();
           
           
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fullnameText_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void combobox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog1.Title = "Select an Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picturebox1.Image = new Bitmap(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                //picturebox2.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crossPicture2_Click(object sender, EventArgs e)
        {

        }

        private void picturebox1_Click(object sender, EventArgs e)
        {

        }
    }
}
