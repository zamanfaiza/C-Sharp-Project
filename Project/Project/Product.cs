using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        #region Properties

        private string _title;
        private string _price;
        private string _available;
        private string _quantity;
        private System.Drawing.Image _productpicture;
        public string Title
        {
            get { return _title; }
            set { _title = value; title.Text = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; price.Text = value; }
        }

        public string Available
        {
            get { return _available; }
            set { _available = value; available.Text = value; }
        }

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value;}
        }

        private string _target;
        public string Target
        {
            get { return _target; }
            set { _target = value;target.Text = value; }
        }

        public System.Drawing.Image Productpicture
        {
            get { return _productpicture; }
            set { _productpicture = value; productpicture.Image = value; }
        }

        #endregion

        string[] array = new string[500];
        int n = 0;
        public string generateinvoice()
        {
            
                Random rand = new Random();
                return  (rand.Next(999999)).ToString();
            
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
            n= number;

           

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

        public static int total = 0 ;
        public static string sendamount ="";
        public static int t = 0;
        public static string sendinvoice = "";
        public static string quantitysend="";
        private void buy_Click(object sender, EventArgs e)
        {
            
            createorderid();

            total = Convert.ToInt32(quantity.Value);
            quantitysend = total.ToString();

            t = Convert.ToInt32(_target);
            if (total > Convert.ToInt32(CDashboard.quantity[t]))
            {
                MessageBox.Show("Not Available");
            }
            else
            {
                int p = Convert.ToInt32(CDashboard.price[t]);
                int q = total * p;
                string s = Convert.ToString(q);
                sendamount = s;

                bool flag = true;
                string test="Order";
                while (true)
                {
                    test = generateinvoice();
                     string test1 = Convert.ToString("Order # " + test);

                    for (int i=0; i<n; i++)
                    {
                        if (array[i] == test1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true) break;
                }
               
                sendinvoice = test;


                //MessageBox.Show(s);
                Payment pa = new Payment();
                pa.Show();
                Login.customerD.Opacity = 20;
                Login.customerD.Enabled = false;
                

               
            }
    


        }
        public static int totalclick = 0;
        
        private void Cart_Click(object sender, EventArgs e)
        {
            total = Convert.ToInt32(quantity.Value);

            t = Convert.ToInt32(_target);
            if (total > Convert.ToInt32(CDashboard.quantity[t]))
            {
                MessageBox.Show("Not Available");
            }
            else
            {
                t = Convert.ToInt32(_target);

                int p = Convert.ToInt32(CDashboard.price[t]);
                int q = total * p;
                string s = Convert.ToString(q);
                //MessageBox.Show(s);

                string productname = CDashboard.productname[t];
                string productprice = q.ToString();
                string productquantity = total.ToString();
                string username = Login.loginusername;

                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
                    con.Open();

                    string query = "INSERT INTO mycart (username,productname,price,quantity) Values('" + username + "','" + productname + "','" + productprice + "','" + productquantity + "')";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Added to cart");
                
            }

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(CDashboard.price[t]);
            int q = total * p;
            string s = Convert.ToString(q);
            sendamount = s;

        }
    }
}
