using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Project
{

    public partial class CDashboard : Form
    {
        public CDashboard()
        {
            InitializeComponent();
        }


        string fullname = string.Empty;
        string password = string.Empty;
        string phone = string.Empty;
        string email = string.Empty;
        string address = string.Empty;
        string link = string.Empty;
        string username = Login.loginusername;
        string path = string.Empty;

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int totalitem;
        private void CDashboard_Load(object sender, EventArgs e)
        {
            homepanel.Show();
            homepanel.BringToFront();
            flowLayoutPanel1.Show();
            flowLayoutPanel1.BringToFront();
            topusername4.Text = username;


            string connectionString1 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con1 = new System.Data.SqlClient.SqlConnection(connectionString1);
            con1.Open();


            string query2 = "select * from product";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con1);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            totalitem = Convert.ToInt32(dtbl.Rows.Count);
            productitems();




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

                topusername.Text = username;
                if (username.Length > 9)
                {
                    topusername.Location = new System.Drawing.Point(610, 7);
                    toppicturebox.Location = new System.Drawing.Point(580, 7);

                }
                if (link != "")
                {
                    toppicturebox.Image = Image.FromFile
                    (link);

                    topprofilepicture4.Image = Image.FromFile
                    (link);
                }

            }
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            cartpanel.Hide();
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

            settingpanel.Hide();
            profilePanel.Show();
            historypanel.Hide();
            homepanel.Hide();

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

            settingsbutton.BaseColor1 = Color.Transparent;
            settingsbutton.BaseColor2 = Color.Transparent;
            settingsbutton.OnHoverBaseColor1 = Color.SlateBlue;
            settingsbutton.OnHoverBaseColor2 = sky;

            profilebutton.BaseColor1 = Color.SlateBlue;
            profilebutton.BaseColor2 = sky;
            profilebutton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            profilebutton.OnHoverBaseColor2 = Color.Purple;


            usernamelable.Text = Convert.ToString(username);
            fullnamelabel.Text = fullname;
            phonelable.Text = phone;
            emaillable.Text = email;
            addresslabel.Text = address;


            if (link != "")
            {
                string filename = link;
                profilePicture.Image = Image.FromFile
                (filename);
            }
            else
            {
                profilePicture.Image = Image.FromFile
                ("D:/OneDrive - American International University-Bangladesh/Lecture PDF/4th Semester/OOP 2/Project/Project/Images/3650583.jpg");
            
            }


            topusername1.Text = username;
            if (username.Length > 9)
            {
                topusername1.Location = new System.Drawing.Point(610, 7);
                toppicturebox1.Location = new System.Drawing.Point(580, 7);

            }
            if (link != "")
                toppicturebox1.Image = Image.FromFile
                (link);
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            ps.UseSystemPasswordChar = true;
            profilePanel.Hide();
            settingpanel.Show();
            historypanel.Hide();
            homepanel.Hide();
            cartpanel.Hide();

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

                topusername.Text = username;
                if (username.Length > 9)
                {
                    topusername.Location = new System.Drawing.Point(610, 7);
                    toppicturebox.Location = new System.Drawing.Point(580, 7);

                }
                if (link != "")
                    toppicturebox.Image = Image.FromFile
                    (link);
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
            if (link != "")
            {
                string filename = link;
                picturebox1.Image = Image.FromFile
                (filename);
            }


        }

        private void Choose_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bool flag = false;
        //bool flag2 = false;
        bool flag3 = false;
       // bool flag4 = false;

        private void showButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            hideButton.BringToFront();
            ps.UseSystemPasswordChar = false;
            flag3 = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            showButton.Visible = true;
            showButton.BringToFront();
            ps.UseSystemPasswordChar = true;
            flag3 = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string f = ft.Text;
                string p = pt.Text;
                string s = ps.Text;
                string a = at.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();

                if (path == "")
                {
                    path = link;
                }
                else
                {
                    link = path;
                }
                string query = "Update UserInfo Set fullname = '" + f + "',password = '" + s + "',phone = '" + p + "',address = '" + a + "',link = '" + path + "' where username = '" + Login.loginusername + "'";
                //string query = "Update UserInfo Set fullname = '" + fullname + "' where username = '"+123456+"'";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historybutton_Click(object sender, EventArgs e)
        {
            profilePanel.Hide();
            settingpanel.Hide();
            historypanel.Show();
            homepanel.Hide();
            cartpanel.Hide();

            homepanel.Hide();

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
            if (link != "")
                toppicturebox3.Image = Image.FromFile
                (link);

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                string query2 = "select * from OrderHistory where CustomerID ='" + username + "'";
                System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                string query = "Select orderid, date, status, price from orderhistory where customerid ='" + username + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderhistorytable.DataSource = dt;

                string s = Convert.ToString(dtbl.Rows.Count);
                totalcount.Text = s + " Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            profilePanel.Hide();
            settingpanel.Hide();
            historypanel.Hide();
            homepanel.Show();
            flowLayoutPanel1.Show();
            cartpanel.Hide();


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
                 ("D:/OneDrive - American International University-Bangladesh/Lecture PDF/4th Semester/OOP 2/Project/Project/Images/3650583.jpg");

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

        public static int pri = 0;


        public static string[] productname = new string[500];
        public static string[] productid = new string[500];
        public static string[] quantity = new string[500];
        public static string[] price = new string[500];
        public static string[] path1 = new string[500];
        public static string av = "";
        public static Product[] listItems = new Product[500];
        private void productitems()
        {



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
                        productid[i] = dataTable.Rows[i][0].ToString();
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


            //Product[] listItems = new Product[totalitem];


            for (int i = 0; i < totalitem; i++)
            {
                listItems[i] = new Product();
                listItems[i].Title = productname[i];
                pri = Convert.ToInt32(price[i]);
                listItems[i].Price = "Price : " + price[i] + " TK";
                listItems[i].Available = "Available " + quantity[i];
                listItems[i].Width = flowLayoutPanel1.Width - 20;
                listItems[i].Productpicture = System.Drawing.Image.FromFile
                (path1[i]);

                if (productid[i] != "0")
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
                listItems[i].Target = Convert.ToString(i);


            }
        }
        int aaaa = 0;
        private void cartbutton_Click(object sender, EventArgs e)
        {
            string connectionString1 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con1 = new System.Data.SqlClient.SqlConnection(connectionString1);
            con1.Open();

            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM mycart";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        buy.Enabled = false;
                        delete.Enabled = false;

                        // do something with the retrieved orderid value
                    }
                    else
                    {
                        buy.Enabled = true;
                        delete.Enabled = true;
                    }





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            profilePanel.Hide();
            settingpanel.Hide();
            historypanel.Hide();
            homepanel.Hide();
            flowLayoutPanel1.Hide();
            cartpanel.Show();

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

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
                // sda.Fill(dtbl);

                string query = "select ProductName,price,Quantity from mycart where username ='" + username + "'";
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
                 ("D:/OneDrive - American International University-Bangladesh/Lecture PDF/4th Semester/OOP 2/Project/Project/Images/3650583.jpg");

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



            int totalprice = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT price FROM mycart where username = '" + Login.loginusername + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        string price2 = Convert.ToString(dataTable.Rows[i][0]);
                        totalprice += Convert.ToInt32(price2);

                        // do something with the retrieved orderid value
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            aaaa = totalprice;
            totalamount.Text = "Total Amount : " + totalprice.ToString();


        }

        public void changetotal()
        {
            int totalprice = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT price FROM mycart where username = '" + Login.loginusername + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        string price2 = Convert.ToString(dataTable.Rows[i][0]);
                        totalprice += Convert.ToInt32(price2);

                        // do something with the retrieved orderid value
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                totalamount.Text = "Total Amount : " + totalprice.ToString();
                aaaa = totalprice;
            }
        }
        public void deletetable()
        {
            try
            {

                if (cartdatatable.SelectedRows.Count > 0)
                {


                    string productname = cartdatatable.SelectedRows[0].Cells[0].Value.ToString();
                    string price3 = cartdatatable.SelectedRows[0].Cells[1].Value.ToString();
                    string quantity = cartdatatable.SelectedRows[0].Cells[2].Value.ToString();

                    string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString3);
                    con.Open();

                    string deleteQuery = "DELETE FROM MyCart WHERE username = @username AND productname = @productname AND price = @price AND quantity = @quantity";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@username", Login.loginusername);
                    cmd.Parameters.AddWithValue("@productname", productname);
                    cmd.Parameters.AddWithValue("@price", price3);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();

                    cartdatatable.Rows.RemoveAt(cartdatatable.SelectedRows[0].Index);
                    changetotal();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void delete_Click(object sender, EventArgs e)
        {

            deletetable();

        }

        string[] array = new string[500];
        int n = 0;
        public string generateinvoice()
        {

            Random rand = new Random();
            return (rand.Next(999999)).ToString();

        }
        public void createorderid()
        {

            string connectionString1 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con1 = new System.Data.SqlClient.SqlConnection(connectionString1);
            con1.Open();


            string query2 = "select * from OrderHistory";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con1);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            int number = dtbl.Rows.Count;
            n = number;



            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT orderid FROM orderhistory";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        string orderid = Convert.ToString(dataTable.Rows[i][0]);
                        orderid = array[i];

                        // do something with the retrieved orderid value
                    }





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public static bool buy2 = true;
        public static string[] selectedname;
        public static string[] selectedprice;

        public void createarray()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM mycart where username = '" + Login.loginusername + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", Login.loginusername);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    int k = dataTable.Rows.Count;

                    selectedname = new string[k];
                    selectedprice = new string[k];

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {

                        selectedname[i] = dataTable.Rows[i][1].ToString();
                        selectedprice[i] = dataTable.Rows[i][2].ToString();
                    }





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buy_Click(object sender, EventArgs e)
        {
            try
            {
                Product.sendamount = aaaa.ToString();
                createorderid();

                bool flag = true;
                string test = "Order";
                while (true)
                {
                    test = generateinvoice();
                    string test1 = Convert.ToString("Order # " + test);

                    for (int i = 0; i < n; i++)
                    {
                        if (array[i] == test1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true) break;
                }

                Product.sendinvoice = test;
                buy2 = false;
                createarray();
                Payment pa = new Payment();
                pa.Show();
                Login.customerD.Opacity = 20;
                Login.customerD.Enabled = false;


                homepanel.Show();
                settingpanel.Hide();
                profilePanel.Hide();
                cartpanel.Hide();
                historypanel.Hide();
                homepanel.BringToFront();
                homepanel.BringToFront();
                homepanel.BringToFront();
                homepanel.BringToFront();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void cartpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
