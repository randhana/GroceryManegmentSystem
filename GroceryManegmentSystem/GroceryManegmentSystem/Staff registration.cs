using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GroceryManegmentSystem
{
    public partial class Staff_registration : Form
    {
        int findId = 0;

        public Staff_registration()
        {
            InitializeComponent();
        }

        private void lblitemName_Click(object sender, EventArgs e)
        {

        }


        public void ClearTextBoxs()
        {
            txt_name.Text = " ";
            txt_username.Text = " ";
            txt_dob.Text = " ";
            txt_nic.Text = " ";
            txt_password.Text = " ";
            txtReenter.Text = " ";
            txt_mobile.Text = " ";
            txt_email.Text = " ";





        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (sendFindId(findId) == 0)
            {
                

                OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\pulat\Downloads\C#\GroceryManegmentSystem\GroceryManegmentSystem\DB.accdb");
                connection.Open();
                OleDbConnection connection1 = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\pulat\Downloads\C#\GroceryManegmentSystem\GroceryManegmentSystem\DB.accdb");
                connection1.Open();

                try
                {

                    String name = txt_name.Text.ToString();
                    String username = txt_username.Text.ToString();
                    String dob = txt_dob.Text.ToString();
                    String nic = txt_nic.Text.ToString();
                    String Mobinumber = txt_mobile.Text.ToString();
                    String email = txt_email.Text.ToString();
                    String pw = txt_password.Text.ToString();
                    


                    String my_querry = "INSERT INTO StaffRegistration(Name,Username,DateOfBirth,Nic,MobileNumber,Email,Pin)VALUES('" + name + "','" + username + "','" + dob + "','" + nic + "','" + Mobinumber + "','" + email + "','" + pw + "')";
                    String my_querry1 = "INSERT INTO Users(Username,Pin)VALUES('" + username + "','" + pw + "')";
                    
                    
                    OleDbCommand cmd = new OleDbCommand(my_querry, connection);
                    cmd.ExecuteNonQuery();
                    OleDbCommand cmd1 = new OleDbCommand(my_querry1, connection1);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Data saved successfuly...!");
                    //this.stockTableAdapter.Fill(this.dBDataSet.Stock); 
                    //Load all data from table 
                    LoadStaffRegistrationTableData();
                    

                    ClearTextBoxs();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed due to" + ex.Message);
                }
                finally
                {
                    connection.Close();
                    connection1.Close();
                }
            }
            else
            {
                int indexId = sendFindId(findId);
                MessageBox.Show("Check select" + indexId);

                OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\pulat\Downloads\C#\GroceryManegmentSystem\GroceryManegmentSystem\DB.accdb");
                connection.Open();

                try
                {

                    String name = txt_name.Text.ToString();
                    String username = txt_username.Text.ToString();
                    String dob = txt_dob.Text.ToString();
                    String nic = txt_nic.Text.ToString();
                    String Mobinumber = txt_mobile.Text.ToString();
                    String email = txt_email.Text.ToString();
                    String pin = txt_password.Text.ToString();



                    OleDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // String my_querry = "update ab set Name='"+name+"'";
                    String my_querry = "update StaffRegistration set Name='" + name + "', Username='" + username + "', DateOfBirth='" + dob + "', Nic='" + nic + "', MobileNumber='" + Mobinumber + "', Email='" + email + "', Pin='" + pin + "' where Id=" + indexId + "";

                    cmd.CommandText = my_querry;



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Updated successfuly...!");




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed due to" + ex.Message);
                }


                finally
                {

                    connection.Close();
                    findId = 0;
                    ClearTextBoxs();
                    LoadStaffRegistrationTableData();
                    

                    

                }
            }
        }
        public int sendFindId(int s)
        {

            return s;
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvStaff.Rows[e.RowIndex];
                //MessageBox.Show("Error "); 
                //MessageBox.Show(row.Cells["Id"].Value.ToString()); 



                findId = (int)row.Cells["Id"].Value;




                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_username.Text = row.Cells["Username"].Value.ToString();
                txt_dob.Text = row.Cells["DateOfBirth"].Value.ToString();
                txt_nic.Text = row.Cells["Nic"].Value.ToString();
                txt_mobile.Text = row.Cells["MobileNumber"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_password.Text = row.Cells["Pin"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }
        public void LoadStaffRegistrationTableData()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\pulat\Downloads\C#\GroceryManegmentSystem\GroceryManegmentSystem\DB.accdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from StaffRegistration";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStaff.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }

        private void Staff_registration_Load(object sender, EventArgs e)
        {
            LoadStaffRegistrationTableData();
        }
    }
}


