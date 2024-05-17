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

namespace WinForms_ToDoList.Forms
{
    public partial class Autefic : Form
    {
        db Db = new db();
        public Autefic()
        {
            InitializeComponent();
        }
        private readonly string _connectionString;

        public Autefic(string connectionString)
        {
            _connectionString = connectionString;

            
        }


        public bool AuthenticateUser(string username, string password)
        {
            // Проверка существования пользователя в базе данных
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                var count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool IsAdmin(string username)
        {
            // Проверка роли пользователя в базе данных
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT Role FROM Users WHERE Username = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var role = reader.GetString(0);
                    return role == "Admin";
                }

                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Role = "Гость";
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var PasUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, user, password from users where user = '{loginUser}' and password = '{PasUser}'";
            SqlCommand command = new SqlCommand(querystring, Db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm frm1 = new MainForm();
                this.Hide();
                frm1.ShowDialog();
            }
            else
                MessageBox.Show("Аккаунт не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
    }  
}
