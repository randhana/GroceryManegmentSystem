using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryManegmentSystem
{
    public partial class Form1 : Form
    {
        public string billname;
        public Form1()
        {
            InitializeComponent();
        }


        public void Clientname(string s)
        {
             billname = s;
            
        }
        public string OpenPDF(string s )

        {


            MessageBox.Show("Client name:" +s );
            axAcroPDF1.src = "C:\\Users\\pulat\\Downloads\\C# Stock project6\\System 1\\GroceryManegmentSystem\\GroceryManegmentSystem\\bin\\Debug\\"+s+".pdf";
            axAcroPDF1.Show();
            billname = " ";
            return null;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }
    }
}
