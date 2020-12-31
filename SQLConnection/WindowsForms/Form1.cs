using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=SQLServerIP;Initial Catalog=DBName;User ID=username;Password=password";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "select Top(5) Name from SalesLT.Product order by Name ";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                // Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
                Output = Output + dataReader.GetValue(0) +  "\n";
            }
            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();            
            MessageBox.Show("Connection closed  !");
        }
    }
}
