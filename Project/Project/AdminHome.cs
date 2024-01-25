using Org.BouncyCastle.Crypto.Engines;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            orderPanel.Visible = true;
            orderPanel.BringToFront();
            productpanel.Visible = false;
            sellerPanel.Visible = false;
            customerPanel.Visible = false;

            //customerPanelAdd.Visible = false; // product add details page


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
                // sda.Fill(dtbl);

                string query = "select OrderID,CustomerID,Price,Status from OrderHistory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderDataTable.DataSource = dt;

                //string s = Convert.ToString(dtbl.Rows.Count);
                //totalcount.Text = s + " Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           

            Color sky = Color.FromArgb(255, 85, 255);

            gunaGradientButton2.BaseColor1 = Color.Transparent;
            gunaGradientButton2.BaseColor2 = Color.Transparent;
            gunaGradientButton2.OnHoverBaseColor1 = Color.SlateBlue;
            gunaGradientButton2.OnHoverBaseColor2 = sky;

            productPanelBT.BaseColor1 = Color.Transparent;
            productPanelBT.BaseColor2 = Color.Transparent;
            productPanelBT.OnHoverBaseColor1 = Color.SlateBlue;
            productPanelBT.OnHoverBaseColor2 = sky;

           gunaGradientButton3.BaseColor1 = Color.Transparent;
           gunaGradientButton3.BaseColor2 = Color.Transparent;
           gunaGradientButton3.OnHoverBaseColor1 = Color.SlateBlue;
           gunaGradientButton3.OnHoverBaseColor2 = sky;

            homeButton.BaseColor1 = Color.SlateBlue;
            homeButton.BaseColor2 = sky;
            homeButton.OnHoverBaseColor1 = Color.MediumSlateBlue;
            homeButton.OnHoverBaseColor2 = Color.Purple;




        }

        private void cartbutton_Click(object sender, EventArgs e)

            
        {

            productpanel.Visible = true ;
            productpanel.BringToFront();
            cartpanel.Visible = false ; 
            customerPanel.Visible = false;
            orderPanel.Visible = false ;

            Color sky = Color.FromArgb(255, 85, 255);

            gunaGradientButton2.BaseColor1 = Color.Transparent;
            gunaGradientButton2.BaseColor2 = Color.Transparent;
            gunaGradientButton2.OnHoverBaseColor1 = Color.SlateBlue;
            gunaGradientButton2.OnHoverBaseColor2 = sky;

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1 = Color.SlateBlue;
            homeButton.OnHoverBaseColor2 = sky;

            gunaGradientButton3.BaseColor1 = Color.Transparent;
            gunaGradientButton3.BaseColor2 = Color.Transparent;
            gunaGradientButton3.OnHoverBaseColor1 = Color.SlateBlue;
            gunaGradientButton3.OnHoverBaseColor2 = sky;

            productPanelBT.BaseColor1 = Color.SlateBlue;
            productPanelBT.BaseColor2 = sky;
            productPanelBT.OnHoverBaseColor1 = Color.MediumSlateBlue;
            productPanelBT.OnHoverBaseColor2 = Color.Purple;


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
                // sda.Fill(dtbl);

                string query = "select ProductID,ProductName,Quantity,Price from Product";
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




        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            productpanel.Visible = false; 
            customerPanel.Visible = false;
            sellerPanel.Visible = false;
            orderPanel.Visible = true;
            // sellerPanelAdd.Visible = false; 


            orderPanel.Visible = true;
            orderPanel.BringToFront();
            productpanel.Visible = false;
            sellerPanel.Visible = false;
            customerPanel.Visible = false;

            //customerPanelAdd.Visible = false; // product add details page


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
                // sda.Fill(dtbl);

                string query = "select OrderID,CustomerID,Price,Status from OrderHistory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                orderDataTable.DataSource = dt;

                //string s = Convert.ToString(dtbl.Rows.Count);
                //totalcount.Text = s + " Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void cartdatatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {
            cartpanel.Visible = true;
            cartpanel.BringToFront();

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

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        string path = String.Empty;
        private void BrowseImage_Click(object sender, EventArgs e)
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

        private void sabbir_TextChanged(object sender, EventArgs e)
        {
            string sku = sabbir.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from Product where productid = '" + sku + "'";
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

        private void delete_Click(object sender, EventArgs e)
        {

            try
            {

                if (cartdatatable.SelectedRows.Count > 0)
                {

                    string productid = cartdatatable.SelectedRows[0].Cells[0].Value.ToString();
                    string productname = cartdatatable.SelectedRows[0].Cells[1].Value.ToString();
                    string price3 = cartdatatable.SelectedRows[0].Cells[3].Value.ToString();
                    string quantity = cartdatatable.SelectedRows[0].Cells[2].Value.ToString();

                    string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString3);
                    con.Open();

                    string deleteQuery = "DELETE FROM Product WHERE productid = @productid AND productname = @productname AND price = @price AND quantity = @quantity";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@productid", productid);
                    cmd.Parameters.AddWithValue("@productname", productname);
                    cmd.Parameters.AddWithValue("@price", price3);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();

                    cartdatatable.Rows.RemoveAt(cartdatatable.SelectedRows[0].Index);
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            productpanel.Visible =true;
            cartpanel.Visible = false;
            productpanel.BringToFront();

            
        }

        private void addProBT_Click(object sender, EventArgs e)
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

        private void addProBack_Click(object sender, EventArgs e)
        {
            productpanel.Visible = true;
            cartpanel.Visible = false;
            productpanel.BringToFront();
        }

        private void uname_Click(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {
            string userName = uname.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from Userinfo where Username = '" + userName + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                ctaken.Visible = true;
            }
            else
            {
                ctaken.Visible = false;
            }
        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            string user = uname.Text;
            string name = nam.Text;
            string email = mail.Text;
            string contact = cont.Text;
            string address = add.Text;


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

           // string fullname = "Default";
            string pass = "1234";
            string phone = "Default";


            string query = "INSERT INTO Userinfo (username,fullname,password,phone,email,address) Values('"+user+"','" + name + "','"+pass+"','" + phone + "','" + email + "','" + address + "')";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        
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

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = true;

            customerPanelAdd.SendToBack();//customerPanelAdd.Visible = false; 
           customerPanelAdd.Visible = false; // product add details page
            orderPanel.Visible = false;
            productpanel.Visible = false;   

           // cartpanel.Visible = false;
            sellerPanel.Visible = false;
            

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            customerPanel.Visible = true;
            customerPanelAdd.Visible = false; // product add details page
            productpanel.Visible= false;    
            sellerPanel.Visible= false; 
            orderPanel.Visible= false;


            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
                // sda.Fill(dtbl);

                string query = "select username,fullname,phone,email,address from UserInfo";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                customerDataTable.DataSource = dt;

                //string s = Convert.ToString(dtbl.Rows.Count);
                //totalcount.Text = s + " Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Color sky = Color.FromArgb(255, 85, 255);

            productPanelBT.BaseColor1 = Color.Transparent;
            productPanelBT.BaseColor2 = Color.Transparent;
            productPanelBT.OnHoverBaseColor1 = Color.SlateBlue;
            productPanelBT.OnHoverBaseColor2 = sky;

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1 = Color.SlateBlue;
            homeButton.OnHoverBaseColor2 = sky;

            gunaGradientButton3.BaseColor1 = Color.Transparent;
            gunaGradientButton3.BaseColor2 = Color.Transparent;
            gunaGradientButton3.OnHoverBaseColor1 = Color.SlateBlue;
            gunaGradientButton3.OnHoverBaseColor2 = sky;

            gunaGradientButton2.BaseColor1 = Color.SlateBlue;
            gunaGradientButton2.BaseColor2 = sky;
            gunaGradientButton2.OnHoverBaseColor1 = Color.MediumSlateBlue;
            gunaGradientButton2.OnHoverBaseColor2 = Color.Purple;

        }

        private void customerDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            customerPanelAdd.Visible = true;
            customerPanelAdd.BringToFront();
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            try
            {

                if (customerDataTable.SelectedRows.Count > 0)
                {

                    string userName = customerDataTable.SelectedRows[0].Cells[0].Value.ToString();
                    string fullname = customerDataTable.SelectedRows[0].Cells[1].Value.ToString();
                    string email = customerDataTable.SelectedRows[0].Cells[3].Value.ToString();
                    string phone = customerDataTable.SelectedRows[0].Cells[2].Value.ToString();
                    string address = customerDataTable.SelectedRows[0].Cells[4].Value.ToString();

                    string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString3);
                    con.Open();

                    string deleteQuery = "DELETE FROM UserInfo WHERE username = @username AND fullname = @fullname AND email = @email AND phone = @phone AND address = @address";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();

                    customerDataTable.Rows.RemoveAt(customerDataTable.SelectedRows[0].Index);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaGradientButton11_Click(object sender, EventArgs e)
        {
            string shopname = shname.Text;
            string name = snam.Text;
            string email = smail.Text;
            string contact = scont.Text;
            string address = sadd.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

            string query = "INSERT INTO Seller (UserName,Name,Email,Contact,Address) Values('" + shopname + "','" + name + "','" + email + "','" + contact + "','" + address + "')";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        private void gunaGradientButton10_Click(object sender, EventArgs e)
        {
            sellerPanel.Visible = true;
            sellerPanelAdd.Visible = false;
            sellerPanel.BringToFront();
           // sellerlabel.Visible = true;
        }

        private void gunaGradientButton9_Click(object sender, EventArgs e)
        {
            sellerPanelAdd.Visible = true;
            sellerPanelAdd.BringToFront();
            sellerlabel.Visible = true;
        }

        private void sellerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            sellerPanel.Visible = true;
            sellerPanel.BringToFront();
            productpanel.Visible = false; // product add details page
            orderPanel.Visible = false;
            customerPanel.Visible = false;
            sellerlabel.Visible = false;





            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            try
            {

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                con.Open();


                //string query2 = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                //System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
                //DataTable dtbl = new DataTable();
                // sda.Fill(dtbl);

                string query = "select UserName,Name,Email,Contact,Address from Seller";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sellerDataTable.DataSource = dt;

                //string s = Convert.ToString(dtbl.Rows.Count);
                //totalcount.Text = s + " Items";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Color sky = Color.FromArgb(255, 85, 255);

            productPanelBT.BaseColor1 = Color.Transparent;
            productPanelBT.BaseColor2 = Color.Transparent;
            productPanelBT.OnHoverBaseColor1 = Color.SlateBlue;
            productPanelBT.OnHoverBaseColor2 = sky;

            homeButton.BaseColor1 = Color.Transparent;
            homeButton.BaseColor2 = Color.Transparent;
            homeButton.OnHoverBaseColor1 = Color.SlateBlue;
            homeButton.OnHoverBaseColor2 = sky;

            gunaGradientButton2.BaseColor1 = Color.Transparent;
            gunaGradientButton2.BaseColor2 = Color.Transparent;
            gunaGradientButton2.OnHoverBaseColor1 = Color.SlateBlue;
            gunaGradientButton2.OnHoverBaseColor2 = sky;

            gunaGradientButton3.BaseColor1 = Color.SlateBlue;
            gunaGradientButton3.BaseColor2 = sky;
            gunaGradientButton3.OnHoverBaseColor1 = Color.MediumSlateBlue;
            gunaGradientButton3.OnHoverBaseColor2 = Color.Purple;
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            try
            {

                if (sellerDataTable.SelectedRows.Count > 0)
                {

                    string userName = sellerDataTable.SelectedRows[0].Cells[0].Value.ToString();
                    string name = sellerDataTable.SelectedRows[0].Cells[1].Value.ToString();
                    string email = sellerDataTable.SelectedRows[0].Cells[2].Value.ToString();
                    string contact = sellerDataTable.SelectedRows[0].Cells[3].Value.ToString();
                    string address = sellerDataTable.SelectedRows[0].Cells[4].Value.ToString();

                    string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString3);
                    con.Open();

                    string deleteQuery = "DELETE FROM Seller WHERE username = @username AND name = @name AND email = @email AND contact = @contact AND address = @address";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();

                    sellerDataTable.Rows.RemoveAt(sellerDataTable.SelectedRows[0].Index);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       


        private void settingsbutton_Click(object sender, EventArgs e)
        {
          
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void gunaLabel16_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel17_Click(object sender, EventArgs e)
        {

        }

        private void ctaken_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel20_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton12_Click(object sender, EventArgs e)
        {

            try
            {

                if (orderDataTable.SelectedRows.Count > 0)
                {

                    string OrderID = orderDataTable.SelectedRows[0].Cells[0].Value.ToString();
                    string CustomerID = orderDataTable.SelectedRows[0].Cells[1].Value.ToString();
                    // string Price = orderDataTable.SelectedRows[0].Cells[2].Value.ToString();
                    // string Status = orderDataTable.SelectedRows[0].Cells[3].Value.ToString();
                    string Status = "Cancled";


                    string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString3);
                    con.Open();

                    string deleteQuery = "Update OrderHistory Set Status = '" + Status + "' where CustomerID = '" + CustomerID + "' and OrderID = '" + OrderID + "'";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    // cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.ExecuteNonQuery();

                    // orderDataTable.Rows.RemoveAt(orderDataTable.SelectedRows[0].Index);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void shname_TextChanged(object sender, EventArgs e)
        {
            string username = shname.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();


            string query2 = "select * from Seller where username = '" + shname + "'";
            System.Data.SqlClient.SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query2, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                staken.Visible = true;
            }
            else
            {
                staken.Visible = false;
            }
        }

        private void sellerPanelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerPanelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton12_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (orderDataTable.SelectedRows.Count > 0)
                {

                    string OrderID = orderDataTable.SelectedRows[0].Cells[0].Value.ToString();
                    string CustomerID = orderDataTable.SelectedRows[0].Cells[1].Value.ToString();
                    // string Price = orderDataTable.SelectedRows[0].Cells[2].Value.ToString();
                    // string Status = orderDataTable.SelectedRows[0].Cells[3].Value.ToString();
                    string Status = "Approved";


                    string connectionString3 = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString3);
                    con.Open();

                    string deleteQuery = "Update OrderHistory Set Status = '" + Status + "' where CustomerID = '" + CustomerID + "' and OrderID = '" + OrderID + "'";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                   // cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.ExecuteNonQuery();

                   // orderDataTable.Rows.RemoveAt(orderDataTable.SelectedRows[0].Index);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
