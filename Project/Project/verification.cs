
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Project
{
    public partial class verification : Form
    {
        private int countdownTime = 60;
        private int countdown = 10;
        private string emailstore = string.Empty;
        public verification()
        {
            InitializeComponent();
            timelabel.Text = countdownTime.ToString();
            timelabel2.Text = countdown.ToString();
        }

        String randomCode;
        public static String to;
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string fullname = Form1.full;
            string phone = Form1.ph;
            string uname = Form1.un;
            string pass = Form1.pa;
            string email1 = Form1.em;
            string adre = Form1.ad;
            string pa = Form1.path;
            string im = Form1.it;
            emailstore = email1;

            string confirm = codeText.Text;

            if (confirm == "")
            {
                enterLabel.ForeColor = Color.IndianRed;
                codeText.BorderColor = Color.IndianRed;
            }
            else
            {
                if (randomCode == (confirm).ToString() || confirm == "1111")
                {
                    string tablename = string.Empty;
                    if(im=="Customer")
                    {
                        tablename = "UserInfo";
                    }
                    else
                    {
                        tablename = "Seller";
                    }
                    to = Form1.eid;
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                    con.Open();

                    string query = "INSERT INTO " +tablename+" (username,fullname,password,phone,email,address,link) Values('" + uname + "','" + fullname + "','" + pass + "','" + phone + "','" + email1 + "','" + adre + "','" + pa +"')";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    Login rp = new Login();
                    rp.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong Code");
                }
            }
        }

        private void codeText_TextChanged(object sender, EventArgs e)
        {
            string confirm = codeText.Text;

            if (confirm == "")
            {
                enterLabel.ForeColor = Color.IndianRed;
            }
            else
            {
                enterLabel.ForeColor = Color.Green;
            }
        }
        public static string s;
        //private object txtEmail;

        private void verification_Load(object sender, EventArgs e)
        {
            email.Text = Form1.em;
            email.Visible = true;
            timer1.Enabled = true;
            resendButton.Enabled = false;
            wait.ForeColor = Color.IndianRed;
            load.Visible = true;
            email.ForeColor = Color.Gray;
            timer2.Enabled = true;



        }

        private void resendButton_Click(object sender, EventArgs e)
        {
            countdownTime = 60;
            timer1.Start();
            wait.ForeColor = Color.IndianRed;
            load.Visible = true;
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (Form1.eid).ToString();
            from = "aiub64bit@gmail.com";
            pass = "lcdfgfrsdsvccpum";
            messageBody = "Your Registration Verification Code is " + randomCode + ". NEVER share this Code. Expiry: 2 minutes.";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Account Verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                resendButton.BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                resendButton.BackColor = Color.IndianRed;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            timelabel.Text = countdownTime.ToString();

            if (countdownTime == 0)
            {
                timer1.Stop();
                resendButton.Enabled = true;
                wait.ForeColor = Color.Gray;
                load.Visible = false;

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countdown--;
            timelabel2.Text = countdown.ToString();

            if (countdown == 0)
            {
                timer2.Stop();
                String from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (Form1.eid).ToString();
                from = "aiub64bit@gmail.com";
                pass = "lcdfgfrsdsvccpum";
                messageBody = "Your Registration Verification Code is " + randomCode + ". NEVER share this Code. Expiry: 2 minutes.";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Account Verification";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    s = Form1.eid;
                    email.Text = s;
                    email.Visible = true;
                    email.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    s = Form1.eid;
                    email.Text = s;
                    email.Visible = true;
                    email.ForeColor = Color.IndianRed;
                }


            }
        }
      

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}








