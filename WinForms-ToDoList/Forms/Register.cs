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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_ToDoList.Forms
{
    public partial class Register : Form

    {
        db Db = new db();
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var Pass = textBox2.Text;


            string querystring = $"insert into Users values ('User' '{login}', '{Pass}') ";
            SqlCommand command = new SqlCommand(querystring, Db.getConnection());

            Db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успешно!");
                Autefic log1 = new Autefic();
                this.Hide();
                log1.ShowDialog();
            }
            else
                MessageBox.Show("Аккаунт не создан", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Db.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, user, password from Users where user = '{loginUser}' and password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, Db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Autefic register = new Autefic();
            this.Hide();
           register.ShowDialog();
        }
    }
}
