using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using Org.BouncyCastle.Math;

namespace Project
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void ft_TextChanged(object sender, EventArgs e)
        {
           
        }

        



        public static int invoicecount=0;
        bool flag = true;
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == false)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                flag = true;
            }
        }
        string check = "";
        private void Payment_Load(object sender, EventArgs e)
        {
            flag = false;

            setamount.Text = Product.sendamount.ToString();
            check = setamount.Text;
            setamount.Text = setamount.Text + " TAKA";
            gunaLabel5.Text = "Invoice no : "+Product.sendinvoice.ToString();
            proceed2.Hide();
            proceed1.BringToFront();

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            
            Login.customerD.Enabled= true;
            Login.customerD.Opacity= 100;
        }

        
        private void proceed_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "e.g 01XXXXXXXXX" || textBox1.Text == "")
            {
                MessageBox.Show("Your bKash phone number");
                return;
            }
            else
            {
                proceed2.Show();
                proceed2.BringToFront();
               
                textBox1.Text = "";
                bkash.Text = "Your bKash pin number";
            }

        }


       public static string e = "";
        string em = "";
        private string randomCode;
        private object to;

        public void invoice()
        {

            string orderid = Product.sendinvoice;
            string invoice = orderid;
            orderid = "Order # " + orderid;
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("dd-MM-yyyy"); ;
            string status = "Pending";
            string price = "TK " + check;
            string customerid =Login.loginusername;
            string itemname = CDashboard.productname[Product.t];

            try
            {
                string connectionString2 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                System.Data.SqlClient.SqlConnection con2 = new System.Data.SqlClient.SqlConnection(connectionString2);
                con2.Open();

                string query = "INSERT INTO OrderHistory (orderid,date,status,price,customerid) Values('" + orderid + "','" + date + "','" + status + "','" + price + "','" + customerid + "')";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con2);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

            string fullname = "";
            string phone = "";
            string address = "";
            string email = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserInfo WHERE username = @username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", Login.loginusername);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    fullname = dataTable.Rows[0][1].ToString();
                    phone = dataTable.Rows[0][3].ToString();
                    email = dataTable.Rows[0][4].ToString();
                    e = email;
                    address = dataTable.Rows[0][5].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            string Uname = Login.loginusername;
            string path = "D://OneDrive - American International University-Bangladesh//Lecture PDF//4th Semester//OOP 2//Project//Project//Invoice" + Uname + Product.sendinvoice+".pdf";
            //string imagepath = @"D://OneDrive - American International University-Bangladesh//C#//Project//Images//signup-icon.png";
            //iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create(imagepath));
            //logo.SetHeight(40);
            // logo.SetWidth(30);
            // logo.SetFixedPosition(130, 780);

            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            float column = 300f;
            float[] colwidth = { column, column };
            Table table = new Table(colwidth);

            Cell cell11 = new Cell(1, 1)
                .SetFontSize(14)
                .SetBold()
                ///.Add(logo)
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("Cart Crush"));

            Cell cell21 = new Cell(1, 1)
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("All in one store"));

            Cell cell12 = new Cell(2, 1)
                .SetFontSize(26)
                .SetItalic()
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT)
                .Add(new Paragraph("Invoice"));

            Table companyinfo = new Table(colwidth);
            companyinfo.SetMarginTop(20f);



            string name = "CART CRUSH";
            Cell cell31 = new Cell(1, 1)
                 .Add(new Paragraph(name + "\n" + "Shantinagar, Chamelibagh\nDhaka 1217, " +
                 "H.N 58/2\nnaimurrahman471@gmail.com\nPhone:XXXXXXXXXXX"))

                 .SetBorder(Border.NO_BORDER)
                 .SetFontSize(8)
                 .SetItalic()
                 .SetTextAlignment(TextAlignment.LEFT)
                 .SetMarginTop(20f);

            Cell cell32 = new Cell(1, 1)
                .Add(new Paragraph("Invoice ID : "+invoice+"\n "+date))
                 .SetBorder(Border.NO_BORDER)
                 .SetTextAlignment(TextAlignment.RIGHT);


            Cell cell41 = new Cell(1, 1)
                 .Add(new Paragraph("\nTo\n" + fullname + "\n"  + address + "\n" +
                 email + "\n" + phone+"\n"))
                 .SetBorder(Border.NO_BORDER)
                 .SetFontSize(8)
                 .SetItalic()
                 .SetTextAlignment(TextAlignment.LEFT);
            //.SetPadding(20f);


            Table item = new Table(colwidth).SetMarginTop(20f);

            Cell cellpp = new Cell(1, 2)
             .SetBorder(Border.NO_BORDER)
             .SetFontSize(10)
            //.SetBold()
            .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));


            Cell cell51 = new Cell(1, 1)
                .SetBorder(Border.NO_BORDER)
                .SetFontSize(10)
                .SetBold()
                .Add(new Paragraph("Description"));

            Cell cell52 = new Cell(1, 1)
                 .SetBorder(Border.NO_BORDER)
                 .SetFontSize(10)
                 .SetBold()
                .Add(new Paragraph("Amount"))
                .SetTextAlignment(TextAlignment.RIGHT);

            Cell cellppp = new Cell(1, 2)
             .SetBorder(Border.NO_BORDER)
             .SetFontSize(10)
            //.SetBold()
            .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));


            Cell cell61 = new Cell(1, 1)
                .SetBorder(Border.NO_BORDER)
                 .SetFontSize(10)
                .Add(new Paragraph(itemname));

            Cell cell62 = new Cell(1, 1)
               .SetBorder(Border.NO_BORDER)
                .SetFontSize(10)
               .Add(new Paragraph(check+" Taka"))
               .SetTextAlignment(TextAlignment.RIGHT);

            Cell cell71 = new Cell(1, 2)
              .SetBorder(Border.NO_BORDER)
              .SetFontSize(10)
             //.SetBold()
             .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));


            Cell cell81 = new Cell(1, 1)
             .SetBorder(Border.NO_BORDER)
             .SetFontSize(10)
             .SetBold()
             .Add(new Paragraph("Total"));

            Cell cell82 = new Cell(1, 1)
             .SetBorder(Border.NO_BORDER)
             .SetFontSize(10)
             .SetBold()
             .Add(new Paragraph(check +" Taka"))
             .SetTextAlignment(TextAlignment.RIGHT);

            Cell cell91 = new Cell(1, 2)
             .SetBorder(Border.NO_BORDER)
             .SetFontSize(10)
            //.SetBold()
            .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));

            Cell cell101 = new Cell(1, 2)
            .SetBorder(Border.NO_BORDER)
            .SetFontSize(26)
            .SetBold()
            .Add(new Paragraph("Thank You"))
            .SetTextAlignment(TextAlignment.CENTER);


            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell21);

            companyinfo.AddCell(cell31);
            companyinfo.AddCell(cell32);
            companyinfo.AddCell(cell41);


            item.AddCell(cellpp);
            item.AddCell(cell51);
            item.AddCell(cell52);
            item.AddCell(cellppp);
            item.AddCell(cell61);
            item.AddCell(cell62);
            item.AddCell(cell71);
            item.AddCell(cell81);
            item.AddCell(cell82);
            item.AddCell(cell91);
            item.AddCell(cell101);






            document.Add(table);
            document.Add(companyinfo);
            document.Add(item);
            document.Close();

           // Process.Start(path);



        }


       public void sendemail() 
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (e).ToString();
            from = "aiub64bit@gmail.com";
            pass = "lcdfgfrsdsvccpum";
            messageBody = "Thank you for placing your order with us! " +
                "Your order has been received and is being processed. " +
                "We will notify you once your order has been shipped. " +
                "If you have any questions or concerns, please feel free to contact us.";
            message.To.Add((string)to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Order Confirmation ";
            string filename = "D://OneDrive - American International University-Bangladesh//Lecture PDF//4th Semester//OOP 2//Project//Project//Invoice" + Login.loginusername + Product.sendinvoice+".pdf";

            //string filename = "C:\\Users\\Admin\\Downloads\\BDRAILWAY_TICKET202303230802249487737.pdf";
            string fname = Path.GetFileName(filename);
            message.Attachments.Add(new Attachment(filename));
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
        public void sendemail2()
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (em).ToString();
            from = "aiub64bit@gmail.com";
            pass = "lcdfgfrsdsvccpum";
            messageBody = "Thank you for placing your order with us! " +
                "Your order has been received and is being processed. " +
                "We will notify you once your order has been shipped. " +
                "If you have any questions or concerns, please feel free to contact us.";
            message.To.Add((string)to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Order Confirmation ";
            string filename = "D:\\OneDrive - American International University-Bangladesh\\Lecture PDF\\4th Semester\\OOP 2\\Project\\Project\\Invoice" + Login.loginusername + ".pdf";

            //string filename = "C:\\Users\\Admin\\Downloads\\BDRAILWAY_TICKET202303230802249487737.pdf";
            string fname = Path.GetFileName(filename);
            message.Attachments.Add(new Attachment(filename));
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


        public static bool refresh=false;
        private void proceed2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "e.g 01XXXXXXXXX" || textBox1.Text == "")
            {
                MessageBox.Show("Your bKash pin number");
                return;
            }
            else
            {
                this.Hide();
                Login.customerD.Enabled = true;
                Login.customerD.Opacity = 100;

                if (CDashboard.buy2 != false)
                {

                    int n = Convert.ToInt32(CDashboard.quantity[Product.t]);
                    n -= Convert.ToInt32(Product.total);

                    CDashboard.listItems[Product.t].Available = "Available " + n.ToString();

                    try
                    {


                        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                        con.Open();


                        string query = "Update product Set quantity = '" + n.ToString() + "' where productid = '" + CDashboard.productid[Product.t] + "'";
                        //string query = "Update UserInfo Set fullname = '" + fullname + "' where username = '"+123456+"'";
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Updated");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    // MessageBox.Show(n.ToString());
                    invoice();
                    sendemail();


                }
                else
                {
                    CDashboard.buy2 = true;


                    string orderid = Product.sendinvoice;
                    string invoice = orderid;
                    orderid = "Order # " + orderid;
                    DateTime currentDate = DateTime.Now;
                    string date = currentDate.ToString("dd-MM-yyyy"); ;
                    string status = "Pending";
                    string price = "TK " + check;
                    string customerid = Login.loginusername;
                    string itemname = CDashboard.productname[Product.t];

                    try
                    {
                        string connectionString2 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                        System.Data.SqlClient.SqlConnection con2 = new System.Data.SqlClient.SqlConnection(connectionString2);
                        con2.Open();

                        string query = "INSERT INTO OrderHistory (orderid,date,status,price,customerid) Values('" + orderid + "','" + date + "','" + status + "','" + price + "','" + customerid + "')";
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con2);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                    con.Open();

                    string fullname = "";
                    string phone = "";
                    string address = "";
                    string email = "";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "SELECT * FROM UserInfo WHERE username = @username";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@username", Login.loginusername);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            fullname = dataTable.Rows[0][1].ToString();
                            phone = dataTable.Rows[0][3].ToString();
                            email = dataTable.Rows[0][4].ToString();
                            em = email;
                            address = dataTable.Rows[0][5].ToString();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    try
                    {
                        string Uname = Login.loginusername;
                        string path = "D:\\OneDrive - American International University-Bangladesh\\Lecture PDF\\4th Semester\\OOP 2\\Project\\Project\\Invoice" + Uname + ".pdf";
                        //string imagepath = @"D://OneDrive - American International University-Bangladesh//C#//Project//Images//signup-icon.png";
                        //iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create(imagepath));
                        //logo.SetHeight(40);
                        // logo.SetWidth(30);
                        // logo.SetFixedPosition(130, 780);

                        PdfWriter writer = new PdfWriter(path);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        float column = 300f;
                        float[] colwidth = { column, column };
                        Table table = new Table(colwidth);

                        Cell cell11 = new Cell(1, 1)
                            .SetFontSize(14)
                            .SetBold()
                            ///.Add(logo)
                            .SetBorder(Border.NO_BORDER)
                            .Add(new Paragraph("Cart Crush"));

                        Cell cell21 = new Cell(1, 1)
                            .SetBorder(Border.NO_BORDER)
                            .Add(new Paragraph("All in one store"));

                        Cell cell12 = new Cell(2, 1)
                            .SetFontSize(26)
                            .SetItalic()
                            .SetBorder(Border.NO_BORDER)
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .Add(new Paragraph("Invoice"));

                        Table companyinfo = new Table(colwidth);
                        companyinfo.SetMarginTop(20f);



                        string name = "CART CRUSH";
                        Cell cell31 = new Cell(1, 1)
                             .Add(new Paragraph(name + "\n" + "Shantinagar, Chamelibagh\nDhaka 1217, " +
                             "H.N 58/2\nnaimurrahman471@gmail.com\nPhone:XXXXXXXXXXX"))

                             .SetBorder(Border.NO_BORDER)
                             .SetFontSize(8)
                             .SetItalic()
                             .SetTextAlignment(TextAlignment.LEFT)
                             .SetMarginTop(20f);

                        Cell cell32 = new Cell(1, 1)
                            .Add(new Paragraph("Invoice ID : " + invoice + "\n " + date))
                             .SetBorder(Border.NO_BORDER)
                             .SetTextAlignment(TextAlignment.RIGHT);


                        Cell cell41 = new Cell(1, 1)
                             .Add(new Paragraph("\nTo\n" + fullname + "\n" + address + "\n" +
                             email + "\n" + phone + "\n"))
                             .SetBorder(Border.NO_BORDER)
                             .SetFontSize(8)
                             .SetItalic()
                             .SetTextAlignment(TextAlignment.LEFT);
                        //.SetPadding(20f);


                        Table item = new Table(colwidth).SetMarginTop(20f);

                        Cell cellpp = new Cell(1, 2)
                         .SetBorder(Border.NO_BORDER)
                         .SetFontSize(10)
                        //.SetBold()
                        .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));


                        Cell cell51 = new Cell(1, 1)
                            .SetBorder(Border.NO_BORDER)
                            .SetFontSize(10)
                            .SetBold()
                            .Add(new Paragraph("Description"));

                        Cell cell52 = new Cell(1, 1)
                             .SetBorder(Border.NO_BORDER)
                             .SetFontSize(10)
                             .SetBold()
                            .Add(new Paragraph("Amount"))
                            .SetTextAlignment(TextAlignment.RIGHT);

                        Cell cellppp = new Cell(1, 2)
                         .SetBorder(Border.NO_BORDER)
                         .SetFontSize(10)
                        //.SetBold()
                        .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));

                        table.AddCell(cell11);
                        table.AddCell(cell12);
                        table.AddCell(cell21);

                        companyinfo.AddCell(cell31);
                        companyinfo.AddCell(cell32);
                        companyinfo.AddCell(cell41);


                        item.AddCell(cellpp);
                        item.AddCell(cell51);
                        item.AddCell(cell52);
                        item.AddCell(cellppp);

                        Cell cell61 = new Cell(1, 1);
                        // .SetBorder(Border.NO_BORDER)
                        // .SetFontSize(10)
                        //.Add(new Paragraph(itemname));

                        Cell cell62 = new Cell(1, 1);
                        //.SetBorder(Border.NO_BORDER)
                        // .SetFontSize(10)
                        //.Add(new Paragraph(check + " Taka"))
                        // .SetTextAlignment(TextAlignment.RIGHT);

                        for (int i = 0; i < CDashboard.selectedname.Length; i++)
                        {
                            cell61
                               .SetBorder(Border.NO_BORDER)
                               .SetFontSize(10)
                               .Add(new Paragraph(CDashboard.selectedname[i]));

                            cell62
                               .SetBorder(Border.NO_BORDER)
                               .SetFontSize(10)
                               .Add(new Paragraph(CDashboard.selectedprice[i] + " Taka"))
                               .SetTextAlignment(TextAlignment.RIGHT);

                            item.AddCell(cell61);
                            item.AddCell(cell62);
                        }

                        Cell cell71 = new Cell(1, 2)
                          .SetBorder(Border.NO_BORDER)
                          .SetFontSize(10)
                         //.SetBold()
                         .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));


                        Cell cell81 = new Cell(1, 1)
                         .SetBorder(Border.NO_BORDER)
                         .SetFontSize(10)
                         .SetBold()
                         .Add(new Paragraph("Total"));

                        Cell cell82 = new Cell(1, 1)
                         .SetBorder(Border.NO_BORDER)
                         .SetFontSize(10)
                         .SetBold()
                         .Add(new Paragraph(check + " Taka"))
                         .SetTextAlignment(TextAlignment.RIGHT);

                        Cell cell91 = new Cell(1, 2)
                         .SetBorder(Border.NO_BORDER)
                         .SetFontSize(10)
                        //.SetBold()
                        .Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------------------"));

                        Cell cell101 = new Cell(1, 2)
                        .SetBorder(Border.NO_BORDER)
                        .SetFontSize(26)
                        .SetBold()
                        .Add(new Paragraph("Thank You"))
                        .SetTextAlignment(TextAlignment.CENTER);




                        item.AddCell(cell71);
                        item.AddCell(cell81);
                        item.AddCell(cell82);
                        item.AddCell(cell91);
                        item.AddCell(cell101);






                        document.Add(table);
                        document.Add(companyinfo);
                        document.Add(item);
                        document.Close();

                        string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                        System.Data.SqlClient.SqlConnection con2 = new System.Data.SqlClient.SqlConnection(connectionString3);
                        con2.Open();

                        string deleteQuery = "DELETE FROM MyCart WHERE username = @username";
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@username", Login.loginusername);
                        cmd.ExecuteNonQuery();

                        

                        sendemail2();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                }

            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.customerD.Enabled = true;
            Login.customerD.Opacity = 100;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
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

                textBox1.Text = "";

            }
           
        }
    }
}
