using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace IT481U2A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testconnect_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
             connetionString = @"Data Source=northwind.cqb3aupygtra.us-east-2.rds.amazonaws.com,1433; Initial Catalog=Northwind; User ID=ateam; Password=hello12345";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Successful!");
            cnn.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
             connetionString = @"Data Source=northwind.cqb3aupygtra.us-east-2.rds.amazonaws.com,1433; Initial Catalog=Northwind; User ID=ateam; Password=hello12345";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT RegionID  , RegionDescription FROM Region";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                Output = Output + dataReader.GetValue(0) + ":" + dataReader.GetValue(1) + " - " ;
            }

            // MessageBox.Show(Output);
            outputview.Text = Output;
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
           
                outputview.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
             connetionString = @"Data Source=northwind.cqb3aupygtra.us-east-2.rds.amazonaws.com,1433; Initial Catalog=Northwind; User ID=ateam; Password=hello12345";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            
           SqlCommand command = cnn.CreateCommand();
            command.CommandType = CommandType.Text;
          

           command.CommandText = "INSERT INTO Region (RegionID,RegionDescription) VALUES('" + region.Text+"', '"+ desc.Text+"' )";
            command.ExecuteNonQuery();
           // command.Dispose();
            cnn.Close();
            MessageBox.Show("successful insert");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
             connetionString = @"Data Source=northwind.cqb3aupygtra.us-east-2.rds.amazonaws.com,1433; Initial Catalog=Northwind; User ID=ateam; Password=hello12345";
            cnn = new SqlConnection(connetionString);
            cnn.Open();


            SqlCommand command = cnn.CreateCommand();
            command.CommandType = CommandType.Text;
            

            command.CommandText = "DELETE FROM Region WHERE RegionDescription='" + desc.Text+"'";
            command.ExecuteNonQuery();
           
            cnn.Close();
            MessageBox.Show("successful delete");
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
             connetionString = @"Data Source=northwind.cqb3aupygtra.us-east-2.rds.amazonaws.com,1433; Initial Catalog=Northwind; User ID=ateam; Password=hello12345";
            cnn = new SqlConnection(connetionString);
            cnn.Open();


            SqlCommand command = cnn.CreateCommand();
            command.CommandType = CommandType.Text;


            command.CommandText = "UPDATE Region SET RegionDescription='" + newdesc.Text + "' WHERE RegionDescription='" + desc.Text + "'";
            command.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("successful update");
        }
    }
    
}
