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
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Xml;
namespace Lab6
{
    public partial class Form1 : Form
    {
        System.Data.SqlClient.SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=RENDER-MACHINE\SQLEXPRESS; " +
                "integrated security=true;" +
                "initial catalog=AutomotiveIndustry;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Connection is open");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection is not open ");
            }
        }
    }
}
