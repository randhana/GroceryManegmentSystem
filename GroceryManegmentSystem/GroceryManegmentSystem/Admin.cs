
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockHadalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Keeper stock_Keeper = new Stock_Keeper();
            stock_Keeper.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();
        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_registration staff_Registration = new Staff_registration();
            staff_Registration.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }



        private void btnFillter_Click(object sender, EventArgs e)
        {


            //try
            //{
            //    OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\pulat\Downloads\C# Stock project6\System 1\DB.accdb");
            //    connection.Open();
            //    OleDbCommand command = new OleDbCommand();
            //    command.Connection = connection;
            //    //String query = "select * from Stock";
            //    //command.CommandText = query;

            //       OleDbDataAdapter da = new OleDbDataAdapter(command);
            //        DataTable dt = new DataTable();
            //    //    da.Fill(dt);

            //    //    dataGridView1.Visible = true;

            //    //dataGridView1.DataSource = dt;





            //    connection.Close();


            //    string sql = "SELECT * FROM Cashier  where BDate Between @date1 and @date2";
            // //  string sql = "SELECT * FROM Users ";
            //    OleDbDataAdapter da = new OleDbDataAdapter(sql, connection);
            //    da.SelectCommand.Parameters.AddWithValue("@data1", dateTimePicker1.Value);
            //    da.SelectCommand.Parameters.AddWithValue("@data2", dateTimePicker2.Value);
            //    da.Fill(dt);



            //    dataGridView1.DataSource = dt;
            //    connection.Close();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error " + ex);

            //}



            try
            {

                
                OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\pulat\Downloads\C#\GroceryManegmentSystem\GroceryManegmentSystem\DB.accdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                


                
                String query = "select Sum(Price) from Cashier where BDate  Between @date1 and @date2 ";


                //command.Parameters.Add("@client", client);
                //command.Parameters.Add("@billing", billing);
                dateTimePicker1.CustomFormat = "MM/dd/yyyy";
                dateTimePicker2.CustomFormat = "MM/dd/yyyy";
                
                
                MessageBox.Show(dateTimePicker1.Text);

                command.Parameters.AddWithValue("@date1", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@date2", dateTimePicker2.Text);
                //  command.Parameters.AddWithValue("@billing", SqlDbType.VarChar).Value = billing;


                command.CommandText = query;


               

                OleDbDataReader reader = null;
                reader = command.ExecuteReader();
                while (reader.Read())

                {
                   
                    //MessageBox.Show(reader[0].ToString());
                    label1.Text = reader[0].ToString(); ;
                }
                    
                //Decimal TotalPrice = Convert.ToDecimal(dt.Compute("SUM(Price)", string.Empty));

                //lblamount.Text = "Rs." + TotalPrice.ToString();





                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }





            //OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\sandeepa\Desktop\System 1\DB.accdb");
            //DataTable dt = new DataTable();
            //connection.Open();
            //OleDbCommand command = new OleDbCommand();
            //command.Connection = connection;
            //String query = "select * from Stock";
            //command.CommandText = query;




        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblGrocery_Click(object sender, EventArgs e)
        {

        }
    }
}
