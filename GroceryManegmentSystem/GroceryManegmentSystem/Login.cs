using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryManegmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            

           









            //if ((txtusername.Text.Trim() == string.Empty) || (txtpassword.Text.Trim() == string.Empty))
            //{

            //    MessageBox.Show(" Please enter usernamme & password");
            //}

            //else if (IsUsername(txtusername.Text))
            //{
            //  //  MessageBox.Show(" Valid usernamme");
                RefreshUserTable();
            //}
            //else
            //{
            //    MessageBox.Show(" Invalid usernamme");
            //   // MessageBox.Show(Decrypt("MA=="));


            //}




        }
        public void RefreshUserTable() {

            string sql_admin = " SELECT * FROM users WHERE Username = 'admin'  ";
            string sql_cashier = " SELECT * FROM users WHERE Username = 'cashier'  ";

            
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=localhost ;uid=root;" +
                "pwd=1234;database=stockdb";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                MySqlCommand cmd = new MySqlCommand(sql_admin, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // MessageBox.Show("username - " + reader.GetString("Username").ToString());
                    
                    MessageBox.Show("passwd - " + Decrypt(reader.GetString("PIN").ToString()));

                    if ((txtusername.Text == reader.GetString("Username").ToString()) && (txtpassword.Text == Decrypt(reader.GetString("PIN").ToString())))

                    {

                        if (txtusername.Text == ("admin") & txtpassword.Text == Decrypt(reader.GetString("PIN").ToString()))
                        {
                            MessageBox.Show("Worked! ");


                           //this.Visible = false;
                           // Admin admin = new Admin();
                           // admin.Show();
                            break;

                        }
                        if (txtusername.Text == ("Stock keeper") & txtpassword.Text == Decrypt(reader[2].ToString()))
                        {
                            this.Visible = false;
                            Stock_Keeper stock_Keeper = new Stock_Keeper();
                            stock_Keeper.Show();
                            stock_Keeper.LoadStockTableData();
                            break;
                        }
                        if (txtusername.Text == ("Cashier") & txtpassword.Text == Decrypt(reader[2].ToString()))
                        {
                            this.Visible = false;
                            Cashier cashier = new Cashier();
                            cashier.Show();
                            cashier.LoadStockTableData();
                            break;
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


           

                
                









            }
            
            
        

        public static bool IsUsername(string username)
        {

            string pattern;

            pattern = "[a-zA-Z0-9]{3,10}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);

        }

      

        public string Encrypt(string s)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(s);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }

        public string Decrypt(string s)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(s);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                decrypted = "";
            }
            return decrypted;
        }



            private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
     