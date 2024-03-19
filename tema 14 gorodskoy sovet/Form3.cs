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

namespace tema_14_gorodskoy_sovet
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = "data source = stud-mssql.sttec.yar.ru,38325; initial catalog = user255_db; user id = user255_db; password = user255; MultipleActiveResultSets = True; App = EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, Zagolovok, Tekst,data_publikacii,avtor FROM [Novosti]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (form1 == null)
            {
                form1 = new Form1();
            }
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            if (form4 == null)
            {
                form4 = new Form4();
            }
            form4.Show();
            this.Hide();
        }
    }
}
