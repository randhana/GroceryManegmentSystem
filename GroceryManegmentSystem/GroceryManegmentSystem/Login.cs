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
            
           


            if ((txtusername.Text.Trim() == string.Empty) || (txtpassword.Text.Trim() == string.Empty))
            {

                MessageBox.Show(" Please enter usernamme & password");
            }

            else if (IsUsername(txtusername.Text))
            {
              //  MessageBox.Show(" Valid usernamme");
                RefreshUserTable();
            }
            else
            {
                MessageBox.Show(" Invalid usernamme");
               // MessageBox.Show(Decrypt("MA=="));


            }

            


        }
        public void RefreshUserTable() {

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pulat\Downloads\C# Stock project6\System 1\DB.accdb");
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT  * from  Users", connection);
            reader = command.ExecuteReader();

           
            while (reader.Read())

            {
                //string d = reader[2].ToString();
                //MessageBox.Show(Decrypt(d));
                //MessageBox.Show(Decrypt(d));
                //String userdata = "User: " + reader[1].ToString() + "\npass: " + reader[2].ToString();

                if ( (txtusername.Text == reader[1].ToString()) && (txtpassword.Text == Decrypt(reader[2].ToString())) )

                {
                    
                    if (txtusername.Text == ("admin") & txtpassword.Text == Decrypt(reader[2].ToString()))
                    {

                        this.Visible = false;
                        Admin admin = new Admin();
                        admin.Show();
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
            //RefreshUserTable();


             connection.Close();
            
           // RefreshUserTable();
            
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
     