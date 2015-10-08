using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();

            //接続
            string stConnectionString = string.Empty;
            stConnectionString += @"Data Source=(local)\sqlexpress;Initial Catalog=tairaDB;Integrated Security=True";

            connection.ConnectionString = stConnectionString;
            connection.Open();

            // クエリの設定　名前抽出
            command.CommandText = "insert into dbo.image_data (title) values ('test')";
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
