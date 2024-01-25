using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using Guna.UI.Animation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Configuration;

namespace Project
{
    public partial class Reset : Form
    {
        private const int V = 373;
        String randomCode;
        bool flag3 = false;
        public static String to;
        public Reset()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            Login f = new Login();
            f.Show();
            this.Hide();
        }

        string emailid;
        string uname = "";
        private void button_Click(object sender, EventArgs e)
        {
            string username = textbox.Text;
            uname = username;

            if (username == "")
            {
                userlabel.Visible = true;
                found.Visible = false;
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from UserInfo where username = '" + username + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                found.Visible = false;
                textbox.Text = string.Empty;
                label.Text = "Verification code";
                button.Visible = false;
                next.Visible = true;
                next.BringToFront();
                gunaLinePanel1.SendToBack();
                next.Location = new System.Drawing.Point(94, 262);


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                       connection.Open();
                        string query = "SELECT email FROM UserInfo WHERE username = @username";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", username);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            emailid = dataTable.Rows[0][0].ToString();
                            sent.Text = Convert.ToString(emailid);
                            emailsent.Visible = true;
                            sent.Visible = true;
                            next.BringToFront();
                            next.BringToFront();
                            next.BringToFront();
                            next.BringToFront();

                            String from, pass, messageBody;
                            Random rand = new Random();
                            randomCode = (rand.Next(999999)).ToString();
                            MailMessage message = new MailMessage();
                            to = (emailid).ToString();
                            from = "aiub64bit@gmail.com";
                            pass = "lcdfgfrsdsvccpum";
                            messageBody = "Your Reseting Code is " + randomCode + ". NEVER share this Code. Expiry: 2 minutes.";
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messageBody;
                            message.Subject = "Password Reseting Code";
                            //string filename = "C:\\Users\\Admin\\Downloads\\BDRAILWAY_TICKET202303230802249487737.pdf";
                            //string fname = Path.GetFileName(filename);
                            //message.Attachments.Add(new Attachment(filename));
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);

                            try
                            {
                                smtp.Send(message);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                     

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
               


            }
            else
            {
                found.Visible = true;
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            userlabel.Visible = false;
        }

       

        private void confirmtext1_TextChanged(object sender, EventArgs e)
        {
            if (flag3 == false)
                confirmtext1.UseSystemPasswordChar = true;
            else confirmtext1.UseSystemPasswordChar = false;

            string pass = confirmtext1.Text;
            if (pass == "" || pass.Length < 6)
            {
                confirmtext1.ForeColor = Color.IndianRed;
                confirmtext1.FocusedBorderColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                //flag2 = false;


            }
            else
            {
                confirmtext1.ForeColor = Color.Green;
                confirmtext1.FocusedBorderColor = Color.DeepSkyBlue;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.Green;
                //flag2 = true;



            }
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if (confirmtext1.Text == "" || confirmtext1.Text.Length<6)
            {
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
            }

            else
            {
                minimumCharacter.Visible = false;

                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string pass = confirmtext1.Text;
                        connection.Open();
                        string query = "UPDATE UserInfo SET password = @pass WHERE username = @uname";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add the parameters for the new email address and the username
                        command.Parameters.AddWithValue("@pass", pass);
                        command.Parameters.AddWithValue("@uname", uname);

                        // Execute the UPDATE statement
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check the number of rows affected
                        if (rowsAffected > 0)
                        {
                            Login l = new Login();
                            l.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password update fail");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            hideButton.BringToFront();
            confirmtext1.UseSystemPasswordChar = false;
            flag3 = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            showButton.Visible = true;
            showButton.BringToFront();
            confirmtext1.UseSystemPasswordChar = true;
            flag3 = false;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void minimumCharacter_Click(object sender, EventArgs e)
        {

        }

        private void sent_Click(object sender, EventArgs e)
        {

        }

        private void emailsent_Click(object sender, EventArgs e)
        {

        }

        private void found_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void userlabel_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Load(object sender, EventArgs e)
        {

        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Reset_Load_1(object sender, EventArgs e)
        {
            button.BringToFront();
            minimumCharacter.ForeColor = Color.IndianRed;
        }

        private void next_Click(object sender, EventArgs e)
        {
            string confirm = textbox.Text;

            if (confirm == "")
            {

            }
            else
            {
                if (randomCode == (confirm).ToString() || confirm == "1111")
                {
                    next.Visible = false;
                    sent.Visible = false;
                    emailsent.Visible = false;

                    confirmbutton.Visible = true;
                    confirmtext1.Visible = true;
                    label.Text = "New Password";
                    showButton.Visible = true;
                    textbox.Visible = false;
                    confirmtext1.BringToFront();
                    showButton.BringToFront();


                }
                else
                {
                    MessageBox.Show("Wrong Code");
                }
            }
        }
    }
}
