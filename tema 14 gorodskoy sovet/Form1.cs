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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "data source = stud-mssql.sttec.yar.ru,38325; initial catalog = user255_db; user id = user255_db; password = user255; MultipleActiveResultSets = True; App = EntityFramework";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Zagolovok, Tekst,data_publikacii,avtor FROM [Novosti]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка введенных данных
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Введите имя пользователя и пароль");
                return;
            }

            // Проверка наличия пользователя в базе данных
            if (!CheckUserExists(username))
            {
                MessageBox.Show("Пользователь с таким именем не найден");
                return;
            }

            // Проверка пароля
            if (!CheckPassword(username, password))
            {
                MessageBox.Show("Неверный пароль");
                return;
            }

            // Успешная авторизация
            MessageBox.Show("Вы успешно авторизовались");
            Form3 form3 = new Form3();
            if (form3 == null)
            {
                form3 = new Form3();
            }
            form3.Show();
            this.Hide();
        }
    

        private bool CheckUserExists(string username)
        {
            // Проверка наличия пользователя в базе данных
            // ...
            return true;
        }

        private bool CheckPassword(string username, string password)
        {
            // Проверка пароля
            // ...
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2 == null)
            {
                form2 = new Form2();
            }
            form2.Show();
            this.Hide();
        }
    }
}

