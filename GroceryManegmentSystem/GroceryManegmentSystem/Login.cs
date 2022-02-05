using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
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
            else
            {
                

                RefreshUserTable();
                
                
               // txtusername.Text = " ";
              //  txtpassword.Text = " ";
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
                //String userdata = "User: " + reader[1].ToString() + "\npass: " + reader[2].ToString();
              
                if ((txtusername.Text == reader[1].ToString()) && (txtpassword.Text == reader[2].ToString()))

                {
                    







                    if (txtusername.Text == ("admin") & txtpassword.Text == reader[2].ToString())
                    {

                        this.Visible = false;
                        Admin admin = new Admin();
                        admin.Show();
                        break;

                    }
                    if (txtusername.Text == ("Stock keeper") & txtpassword.Text == reader[2].ToString())
                    {
                        this.Visible = false;
                        Stock_Keeper stock_Keeper = new Stock_Keeper();
                        stock_Keeper.Show();
                        stock_Keeper.LoadStockTableData();
                        break;
                    }
                    if (txtusername.Text == ("Cashier") & txtpassword.Text == reader[2].ToString())
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
     