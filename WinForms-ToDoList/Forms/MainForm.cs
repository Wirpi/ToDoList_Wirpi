﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;
using MaterialSkin.Controls;
using WinForms_ToDoList.Forms;
using WinForms_ToDoList.Database;
using WinForms_ToDoList.Services;

namespace WinForms_ToDoList
{
    public partial class MainForm : MaterialForm
    {
        #region Глобальные переменные
        int openForm = 0;

        private bool Backing;


        SQLiteConnection connection = new SQLiteConnection(DbConnection.dbConnection);
        #endregion

        public MainForm()
        {
            InitializeComponent();

            //Дефолтная тема
            FormSettings.InstallingDefaultTheme(this, DarkThemeCheckBox);

            DeadLineToDoLabel.Text = DateTime.Now.ToShortDateString();
            DoneText.Text = "Нет";
        }       

        #region Выбор темы офрмления при установки галочки
        private void DarkThemeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings.ChoosingAppTheme(DarkThemeCheckBox);
        }
        #endregion

        

        #region Подтверждение закрытия приложения
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Backing == false)
            {
                MessageExitForm exitForm = new MessageExitForm();
                exitForm.ShowDialog();

                if (exitForm.DialogResult == DialogResult.OK)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            } 
        }
        #endregion

        #region Выбор даты выполнения
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DeadLineToDoLabel.Text = "";
            DeadLineToDoLabel.Text = e.Start.ToShortDateString();
        }
        #endregion

        #region Загрузка данных
        private void MainForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            DbController.LoadData(ToDoDataGridView);
            connection.Close();
        }
        #endregion

        #region Обработчики событий

        #region Добавление новых данных в базу
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Role == "Гость")
            {
                MessageBox.Show("Так не выйдет, идите лучше авторизуйтесь, тогда все и заработает.", "Warning",MessageBoxButtons.OK ) ;
                Backing = true;
                Autefic autefic = new Autefic();
                autefic.Show();
                Hide();
            } else
            {
                DbController.AddNewData(DeadLineToDoLabel, ToDoText, DoneText, ToDoDataGridView);
            }

            
        }
        #endregion

        #region Редактирование данных
        private void EditDataButton_Click(object sender, EventArgs e)
        {
            DbController.EditData(ToDoDataGridView, DeadLineToDoLabel, ToDoText, DoneText);
        }
        #endregion

        #region Удаление данных
        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            DbController.DeleteData(ToDoDataGridView, DeadLineToDoLabel, ToDoText, DoneText);
        }
        #endregion

      

        #endregion

        #region Вывод сохранённых данных в поля
        private void ToDoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ToDoDataGridView.SelectedRows)
            {
                DeadLineToDoLabel.Text = ToDoDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                ToDoText.Text = ToDoDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                DoneText.Text = ToDoDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        #endregion       
    }
}
