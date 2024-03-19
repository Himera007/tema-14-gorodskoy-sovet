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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = "data source = stud-mssql.sttec.yar.ru,38325; initial catalog = user255_db; user id = user255_db; password = user255; MultipleActiveResultSets = True; App = EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Login, password FROM [logipas]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Дополнительная логика для обработки регистрации пользователя

            MessageBox.Show("Регистрация завершена для пользователя: " + username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (form1 == null)
            {
                form1 = new Form1();
            }
            form1.Show();
            this.Hide();
        }
    }
}