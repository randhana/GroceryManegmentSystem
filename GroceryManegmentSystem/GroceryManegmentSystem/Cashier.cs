﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Collections;
using MySql.Data.MySqlClient;

namespace GroceryManegmentSystem
{
    
    public partial class Cashier : Form
    {
        String findQuantity = "0";
        String findId = "0";
        decimal total = 0;
        public string cliname;

        
        ArrayList PrintList = new ArrayList();

        
        public Cashier()

        {

        InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                

                findId = row.Cells["Id"].Value.ToString();
                findQuantity = row.Cells["Quantity"].Value.ToString();

                txtItemNameCas.Text = row.Cells["Item"].Value.ToString();
                txtQuantityCas.Text = row.Cells["Quantity"].Value.ToString();
                txtPriceCas.Text = row.Cells["Price"].Value.ToString();

                if (findQuantity == "0")
                {
                    MessageBox.Show("Out of the stock");
                    ClearTextBoxs();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }
        }
        public void LoadStockTableData()
        {
            try
            {
               String query = "select * from stock";
              // MySql.Data.MySqlClient.MySqlConnection conn;
               string myConnectionString;

                myConnectionString = "server=localhost ;uid=root;" + "pwd='';database=stockdb";

                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }

               

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }

        }

        public void ClearTextBoxs()
        {

            txtItemNameCas.Text = " ";
            txtQuantityCas.Text = " ";
            txtPriceCas.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string indexId = sendFindId(findId);
            string Quantity = sendQuantity(findQuantity);
            
            if (txtClientCas.Text == " ")
            {
                MessageBox.Show("Enter Client Name");
            }
            else
            {
                try
                {

                    String client = txtClientCas.Text.ToString();
                    String billing = txtBilingCas.Text.ToString();
                    String item = txtItemNameCas.Text.ToString();
                    String quantity = txtQuantityCas.Text.ToString();
                    String price = txtPriceCas.Text.ToString();
                    string bdate= DateTime.Now.ToString("yyyy/M/d");

                   

                   int newQuantity = 0;
                    newQuantity = Int32.Parse(Quantity) - Int32.Parse(quantity);

                   

                    

                    arrayPDF(item,quantity,price);

                    string myConnectionString;
                    myConnectionString = "server=localhost ;uid=root;" +
                                                                         "pwd='';database=stockdb";

                    String my_querry = "INSERT INTO Cashier(ClientName,BillDate,BillingDateTime,Item,Quantity,Price)VALUES('" + client + "','" + bdate + "','" + billing + "','" + item + "','" + quantity + "','" + price + "')";
                    
                    String my_querry1 = "UPDATE Stock set Quantity='" + newQuantity + "' where Id=" + indexId + " ";

                    MySqlConnection MyConn2 = new MySqlConnection(myConnectionString);
                    MySqlConnection MyConn1 = new MySqlConnection(myConnectionString);

                    //This is command class which will handle the query and connection object.
                    MySqlCommand MyCommand2 = new MySqlCommand(my_querry1, MyConn2);
                    MySqlCommand MyCommand3 = new MySqlCommand(my_querry, MyConn1);
                    MySqlDataReader MyReader2;
                    

                    MyConn2.Open();
                    MyConn1.Open();
                    MySqlDataReader MyReader1;
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MyReader1 = MyCommand3.ExecuteReader();



                    MessageBox.Show("Data saved successfuly...!");
                    
                    MyConn2.Close();
                    MyConn1.Close();
                    LoadStockTableData();

                    ClearTextBoxs();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed due to" + ex.Message);
                }
                finally
                {
                    
                }

                LoadCashierTableData();
                indexId = "0";
                Quantity = "0";
            }

            txtClientCas.Enabled = false;

        }
        public void  arrayPDF(String item, String quntity, String price )
        {

            
            

            PrintList.Add(item);
            PrintList.Add(quntity);
            PrintList.Add(price);

            

            
            //MessageBox.Show("Array before");
            //PrintList.Clear();
            //MessageBox.Show("Array after"+PrintList.ToString());
            //MessageBox.Show("I"+item+"\nQ "+quntity+"\nP "+price);

            //MessageBox.Show("Array count " + PrintList.Count);

            //for (int i =0; i < PrintList.Count; i++)
            //{
            //    MessageBox.Show("Array" + PrintList[i]);
            //}
            


        }
        
        
        public void CreatePDF(String name, String billdate, String tot)

        {
            string Billname = name;

            try
            {
                MessageBox.Show(dgvCashierbill.Columns.Count.ToString());
                PdfPTable pdfTable = new PdfPTable(dgvCashierbill.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in dgvCashierbill.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgvCashierbill.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //MessageBox.Show("Cell value:"+cell.Value.ToString());


                        //MessageBox.Show("Cell value:" + cell.Value.ToString());
                        if (cell.Value != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                            // MessageBox.Show("Not null");
                        }



                    }
                }

                

                using (FileStream stream = new FileStream(Billname+".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A6, 20, 10, 10, 10);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    Paragraph pdfTitle = new Paragraph("                         Neel’s Grocery (Pvt) Ltd        \n INVOICE\n------------------------------------------------------------------\n");
                    Paragraph pdfclentdetails = new Paragraph("\nClient Name:   " + name + "\nDate & Time:       " + billdate + "\n\n");

                    Paragraph para1 = new Paragraph("     \nTotal Amount:   Rs." + tot + "\n\n------------------------ Thank You -------------------------");

                    //Paragraph para2 = new Paragraph("Good Day");


                    
                    pdfDoc.Add(pdfTitle);
                    pdfDoc.Add(pdfclentdetails);

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Add(para1);
                   // pdfDoc.Add(para2);

                    pdfDoc.Close();
                    stream.Close();


                }
                


                MessageBox.Show("Data Exported Successfully !!!", "Info");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }


            


            

        }
        public string sendFindId(string s)
        {

            return s;
        }

        public string sendQuantity(string s)
        {

            return s;
        }



        public void LoadCashierTableData()
        {
            try
            {
                String client = txtClientCas.Text.ToString();
                String billing = txtBilingCas.Text.ToString();
                OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\pulat\Downloads\C#\GroceryManegmentSystem\GroceryManegmentSystem\DB.accdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;


                //String query = "select Item,Quantity,Price from Cashier where ClientName='" Saman  "'";
                String query = "select Item,Quantity,Price from Cashier where ClientName=@client and BillingDate=@billing";

                //Cal
                //String query2 = " select sum(Price) from Cashier where ClientName = @client and BillingDate = @billing";

                //command.Parameters.Add("@client", client);
                //command.Parameters.Add("@billing", billing);

                command.Parameters.AddWithValue("@client", SqlDbType.VarChar).Value = client;
                command.Parameters.AddWithValue("@billing", SqlDbType.VarChar).Value = billing;


                command.CommandText = query;
                

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCashierbill.DataSource = dt;


                total = Convert.ToDecimal(dt.Compute("SUM(Price)", string.Empty));
                cliname = client;
               // String date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");


                lblamount.Text = "Rs." + total.ToString();

                CreatePDF(client, billing,total.ToString());
                
                
               // MessageBox.Show(total.ToString());



                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }
        }
        //public void Sendclientname(string s)
        //{
        //    Form1 myobg1 = new Form1();
        //    MessageBox.Show("cli name: "+ s);
        //    myobg1.OpenPDF(s);       
        //}
        public String sendSUM(String d)
        {
            
            return d;

        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtBilingCas.Text= DateTime.Now.ToString("yyyy/MM/dd hh:mm tt");
            txtBilingCas.Enabled = false;
            txtClientCas.Text = " ";
            groupBox1.Enabled = true;
            dataGridView2.Enabled = true;
            txtClientCas.Enabled = true;
           

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cashier.

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            dataGridView2.Enabled = false;
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
           
            groupBox1.Enabled = false;
            dgvCashierbill.DataSource = " ";
            lblamount.Text = "-------------- ";
            dataGridView2.Enabled = false;
            PrintList.Clear();
            

            Form1 myobg = new Form1();
            myobg.Show();
            myobg.OpenPDF(cliname);
            cliname = " ";
;            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}  

