using iText.Kernel.Pdf.Canvas;
using iText.Layout.Element;
using iText.StyledXmlParser.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Project
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        string fullname =string.Empty;
        string password = string.Empty;
        string phone = string.Empty;
        string email = string.Empty;
        string address = string.Empty;
        string link = string.Empty;
        string username = "naimur2"; //Login.loginusername;
        string path = string.Empty;

        private void profilebutton_Click(object sender, EventArgs e)
        {
            Color sky = Color.FromArgb(255, 85, 255);

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1= Color.SlateBlue;
            homeButton.OnHoverBaseColor2=sky;

            cartbutton.BaseColor1 = Color.Transparent;
            cartbutton.BaseColor2 = Color.Transparent;
            cartbutton.OnHoverBaseColor1 = Color.SlateBlue;
            cartbutton.OnHoverBaseColor2 = sky;

            historybutton.BaseColor1= Color.Transparent;
            historybutton.BaseColor2= Color.Transparent;
            historybutton.OnHoverBaseColor1 = Color.SlateBlue;
            historybutton.OnHoverBaseColor2 = sky;

            settingsbutton.BaseColor1 = Color.Transparent;
            settingsbutton.BaseColor2= Color.Transparent;
            settingsbutton.OnHoverBaseColor1 = Color.SlateBlue;
            settingsbutton.OnHoverBaseColor2 = sky;

            profilebutton.BaseColor1 = Color.SlateBlue;
            profilebutton.BaseColor2 = sky;
            profilebutton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            profilebutton.OnHoverBaseColor2= Color.Purple;

            usernamelable.Text = Convert.ToString(username);
            fullnamelabel.Text = fullname;
            phonelable.Text = phone;
            emaillable.Text = email;
            addresslabel.Text = address;

           


        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            ps.UseSystemPasswordChar = false;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserInfo WHERE username = @username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    fullname = dataTable.Rows[0][1].ToString();
                    password = dataTable.Rows[0][2].ToString();
                    phone = dataTable.Rows[0][3].ToString();
                    email = dataTable.Rows[0][4].ToString();
                    address = dataTable.Rows[0][5].ToString();
                    link = dataTable.Rows[0][6].ToString();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            Color sky = Color.FromArgb(255, 85, 255);

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1 = Color.SlateBlue;
            homeButton.OnHoverBaseColor2 = sky;

            cartbutton.BaseColor1 = Color.Transparent;
            cartbutton.BaseColor2 = Color.Transparent;
            cartbutton.OnHoverBaseColor1 = Color.SlateBlue;
            cartbutton.OnHoverBaseColor2 = sky;

            historybutton.BaseColor1 = Color.Transparent;
            historybutton.BaseColor2 = Color.Transparent;
            historybutton.OnHoverBaseColor1 = Color.SlateBlue;
            historybutton.OnHoverBaseColor2 = sky;

            profilebutton.BaseColor1 = Color.Transparent;
            profilebutton.BaseColor2 = Color.Transparent;
            profilebutton.OnHoverBaseColor1 = Color.SlateBlue;
            profilebutton.OnHoverBaseColor2 = sky;

            settingsbutton.BaseColor1 = Color.SlateBlue;
            settingsbutton.BaseColor2 = sky;
            settingsbutton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            settingsbutton.OnHoverBaseColor2 = Color.Purple;

            showButton.BringToFront();
            ft.Text = fullname;
            ps.Text = password;
            pt.Text = phone;
            at.Text = address;

            

            



        }

        int totalitem = 0; 
        private void Template_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_ProjectDatabase_C_DataSet1.MyCart' table. You can move, or remove it, as needed.
            this.myCartTableAdapter1.Fill(this._ProjectDatabase_C_DataSet1.MyCart);
            // TODO: This line of code loads data into the '_ProjectDatabase_C_DataSet.MyCart' table. You can move, or remove it, as needed.
            // this.myCartTableAdapter.Fill(this._ProjectDatabase_C_DataSet.MyCart);
            string connectionString1 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con1 = new System.Data.SqlClient.SqlConnection(connectionString1);
            con1.Open();


            string query2 = "select * from product";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con1);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

             totalitem = Convert.ToInt32(dtbl.Rows.Count);
            productitems();


            // TODO: This line of code loads data into the '_ProjectDatabase_C_DataSet.OrderHistory' table. You can move, or remove it, as needed.
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UserInfo WHERE username = @username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                     fullname = dataTable.Rows[0][1].ToString();
                     password = dataTable.Rows[0][2].ToString();
                     phone = dataTable.Rows[0][3].ToString();
                     email = dataTable.Rows[0][4].ToString();
                     address = dataTable.Rows[0][5].ToString();
                     link = dataTable.Rows[0][6].ToString();

                   



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pt_TextChanged(object sender, EventArgs e)
        {
            string phone = pt.Text;
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
                pt.ForeColor = Color.Red;
                pt.FocusedBorderColor = Color.Red;
                phoneTaken.Visible = true;
                tickPicture2.Visible = false;
                crossPicture2.Visible = true;
                flag = false;
                pt.Text = "";

            }
            else
            {
                if (phone == "" || phone.Length < 11)
                {
                    pt.ForeColor = Color.Red;
                    pt.FocusedBorderColor = Color.Red;
                    phoneTaken.Visible = true;
                    tickPicture2.Visible = false;
                    crossPicture2.Visible = true;
                    flag = false;

                }
                else
                {
                    pt.ForeColor = Color.Green;
                    pt.FocusedBorderColor = Color.DeepSkyBlue;
                    phoneTaken.Visible = false;
                    tickPicture2.Visible = true;
                    crossPicture2.Visible = false;
                    flag = true;

                }
            }
        }

        bool flag = false;
        bool flag2 = false;
        bool flag3 = false;
        bool flag4 = false;
        private void ps_TextChanged(object sender, EventArgs e)
        {
            if (flag3 == false)
                ps.UseSystemPasswordChar = true;
            else ps.UseSystemPasswordChar = false;

            string pass = ps.Text;
            if (pass == "" || pass.Length < 6)
            {
                ps.ForeColor = Color.IndianRed;
                ps.FocusedBorderColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                flag2 = false;


            }
            else
            {
                ps.ForeColor = Color.Green;
                ps.FocusedBorderColor = Color.DeepSkyBlue;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.Green;
                flag2 = true;



            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            showButton.Visible = true;
            showButton.BringToFront();
            ps.UseSystemPasswordChar = true;
            flag3 = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            hideButton.BringToFront();
            ps.UseSystemPasswordChar = false;
            flag3 = true;
        }

        private void tickPicture2_Click(object sender, EventArgs e)
        {

        }

        private void crossPicture2_Click(object sender, EventArgs e)
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string f = ft.Text;
                string p =pt.Text;
                string s = ps.Text;
                string a = at.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();

                string query = "Update UserInfo Set fullname = '" + f + "',password = '" + s + "',phone = '" + p + "',address = '" + a + "',link = '" + link + "' where username = '"+username+"'";
                //string query = "Update UserInfo Set fullname = '" + fullname + "' where username = '"+123456+"'";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");

            }catch(Exception ex) { 
                MessageBox.Show(ex.Message);    
            }
        }

        private void historybutton_Click(object sender, EventArgs e)
        {
            Color sky = Color.FromArgb(255, 85, 255);

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1 = Color.SlateBlue;
            homeButton.OnHoverBaseColor2 = sky;

            cartbutton.BaseColor1 = Color.Transparent;
            cartbutton.BaseColor2 = Color.Transparent;
            cartbutton.OnHoverBaseColor1 = Color.SlateBlue;
            cartbutton.OnHoverBaseColor2 = sky;

            profilebutton.BaseColor1 = Color.Transparent;
            profilebutton.BaseColor2 = Color.Transparent;
            profilebutton.OnHoverBaseColor1 = Color.SlateBlue;
            profilebutton.OnHoverBaseColor2 = sky;

            settingsbutton.BaseColor1 = Color.Transparent;
            settingsbutton.BaseColor2 = Color.Transparent;
            settingsbutton.OnHoverBaseColor1 = Color.SlateBlue;
            settingsbutton.OnHoverBaseColor2 = sky;

            historybutton.BaseColor1 = Color.SlateBlue;
            historybutton.BaseColor2 = sky;
            historybutton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            historybutton.OnHoverBaseColor2 = Color.Purple;

            topusername3.Text = username;
            if (username.Length > 9)
            {
                topusername3.Location = new System.Drawing.Point(610, 7);
                toppicturebox3.Location = new System.Drawing.Point(580, 7);

            }
            toppicturebox3.Image = System.Drawing.Image.FromFile
            (link);

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from OrderHistory";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            string s = Convert.ToString(dtbl.Rows.Count);
            totalcount.Text = s +" Items";

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Color sky = Color.FromArgb(255, 85, 255);

            historybutton.BaseColor1 = Color.Transparent;
            historybutton.BaseColor2 = Color.Transparent;
            historybutton.OnHoverBaseColor1 = Color.SlateBlue;
            historybutton.OnHoverBaseColor2 = sky;

            cartbutton.BaseColor1 = Color.Transparent;
            cartbutton.BaseColor2 = Color.Transparent;
            cartbutton.OnHoverBaseColor1 = Color.SlateBlue;
            cartbutton.OnHoverBaseColor2 = sky;

            profilebutton.BaseColor1 = Color.Transparent;
            profilebutton.BaseColor2 = Color.Transparent;
            profilebutton.OnHoverBaseColor1 = Color.SlateBlue;
            profilebutton.OnHoverBaseColor2 = sky;

            settingsbutton.BaseColor1 = Color.Transparent;
            settingsbutton.BaseColor2 = Color.Transparent;
            settingsbutton.OnHoverBaseColor1 = Color.SlateBlue;
            settingsbutton.OnHoverBaseColor2 = sky;

            homeButton.BaseColor1 = Color.SlateBlue;
            homeButton.BaseColor2 = sky;
            homeButton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            homeButton.OnHoverBaseColor2 = Color.Purple;


            if (link != "")
            {
                string filename = link;
                topprofilepicture4.Image = System.Drawing.Image.FromFile
                (filename);
            }
            else
            {
                topprofilepicture4.Image = System.Drawing.Image.FromFile
                ("D:/OneDrive - American International University-Bangladesh/Project/Images/3650583.jpg");
            }


            topusername4.Text = username;
            if (username.Length > 9)
            {
                topusername4.Location = new System.Drawing.Point(610, 7);
                topprofilepicture4.Location = new System.Drawing.Point(580, 7);

            }
            if (link != "")
                topprofilepicture4.Image = System.Drawing.Image.FromFile
                (link);

        }

        private void product1_Load(object sender, EventArgs e)
        {

        }
        public static int pri = 0;
        private void productitems()
        {

            string[] productname = new string[totalitem];
            string[] productid = new string[totalitem];
            string[] quantity = new string[totalitem];
            string[] price = new string[totalitem];
            string[] path1 = new string[totalitem];


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM product";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    for (int i = 0; i < totalitem; i++)
                    {
                        
                            productname[i] = dataTable.Rows[i][1].ToString();
                            price[i] = dataTable.Rows[i][2].ToString();
                            quantity[i] = dataTable.Rows[i][3].ToString();
                            path1[i] = dataTable.Rows[i][4].ToString();



                        
                    }





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            Product[] listItems = new Product[totalitem];

            for(int i=0; i< totalitem; i++) 
            {
                listItems[i] = new Product();
                listItems[i].Title = productname[i];
                pri = Convert.ToInt32(price[i]);
                listItems[i].Price = "Price : " + price[i] + " TK";
                listItems[i].Available = "Available " + quantity[i];
                listItems[i].Width = flowLayoutPanel1.Width - 20;
                listItems[i].Productpicture = System.Drawing.Image.FromFile
                (path1[i]);
                flowLayoutPanel1.Controls.Add(listItems[i]);
                listItems[i].Target = Convert.ToString(i);
                

            }
        }

        private void cartbutton_Click(object sender, EventArgs e)
        {
            Color sky = Color.FromArgb(255, 85, 255);

            historybutton.BaseColor1 = Color.Transparent;
            historybutton.BaseColor2 = Color.Transparent;
            historybutton.OnHoverBaseColor1 = Color.SlateBlue;
            historybutton.OnHoverBaseColor2 = sky;

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1 = Color.SlateBlue;
            homeButton.OnHoverBaseColor2 = sky;

            profilebutton.BaseColor1 = Color.Transparent;
            profilebutton.BaseColor2 = Color.Transparent;
            profilebutton.OnHoverBaseColor1 = Color.SlateBlue;
            profilebutton.OnHoverBaseColor2 = sky;

            settingsbutton.BaseColor1 = Color.Transparent;
            settingsbutton.BaseColor2 = Color.Transparent;
            settingsbutton.OnHoverBaseColor1 = Color.SlateBlue;
            settingsbutton.OnHoverBaseColor2 = sky;

            cartbutton.BaseColor1 = Color.SlateBlue;
            cartbutton.BaseColor2 = sky;
            cartbutton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            cartbutton.OnHoverBaseColor2 = Color.Purple;


            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
               // sda.Fill(dtbl);

                string query = "select ProductName,price,Quantity from mycart where username ='" + Login.loginusername + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cartdatatable.DataSource = dt;

                //string s = Convert.ToString(dtbl.Rows.Count);
                //totalcount.Text = s + " Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (link != "")
            {
                string filename = link;
                toppicture5.Image = System.Drawing.Image.FromFile
                (filename);
            }
            else
            {
                toppicture5.Image = System.Drawing.Image.FromFile
                ("D:/OneDrive - American International University-Bangladesh/Project/Images/3650583.jpg");
            }


            topusername5.Text = username;
            if (username.Length > 9)
            {
                topusername5.Location = new System.Drawing.Point(610, 7);
                toppicture5.Location = new System.Drawing.Point(580, 7);

            }
            if (link != "")
                toppicture5.Image = System.Drawing.Image.FromFile
                (link);



        }

        private void orderhistorytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cartdatatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void historypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
