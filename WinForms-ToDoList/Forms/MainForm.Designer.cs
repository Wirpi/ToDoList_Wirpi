
namespace WinForms_ToDoList
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DoneText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EditDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DarkThemeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.DeadLineToDoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ToDoText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DeleteDataButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompletionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoDataGridView = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Accout = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DoneText
            // 
            this.DoneText.Depth = 0;
            this.DoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneText.Hint = "";
            this.DoneText.Location = new System.Drawing.Point(504, 209);
            this.DoneText.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneText.Name = "DoneText";
            this.DoneText.PasswordChar = '\0';
            this.DoneText.SelectedText = "";
            this.DoneText.SelectionLength = 0;
            this.DoneText.SelectionStart = 0;
            this.DoneText.Size = new System.Drawing.Size(151, 23);
            this.DoneText.TabIndex = 13;
            this.DoneText.UseSystemPasswordChar = false;
            // 
            // EditDataButton
            // 
            this.EditDataButton.Depth = 0;
            this.EditDataButton.Location = new System.Drawing.Point(337, 444);
            this.EditDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditDataButton.Name = "EditDataButton";
            this.EditDataButton.Primary = true;
            this.EditDataButton.Size = new System.Drawing.Size(133, 35);
            this.EditDataButton.TabIndex = 12;
            this.EditDataButton.Text = "Редактировать";
            this.EditDataButton.UseVisualStyleBackColor = true;
            this.EditDataButton.Click += new System.EventHandler(this.EditDataButton_Click);
            // 
            // DarkThemeCheckBox
            // 
            this.DarkThemeCheckBox.Depth = 0;
            this.DarkThemeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.DarkThemeCheckBox.Location = new System.Drawing.Point(5, 70);
            this.DarkThemeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.DarkThemeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkThemeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeCheckBox.Name = "DarkThemeCheckBox";
            this.DarkThemeCheckBox.Ripple = true;
            this.DarkThemeCheckBox.Size = new System.Drawing.Size(140, 30);
            this.DarkThemeCheckBox.TabIndex = 10;
            this.DarkThemeCheckBox.Text = "Тёмная тема";
            this.DarkThemeCheckBox.UseVisualStyleBackColor = true;
            this.DarkThemeCheckBox.CheckedChanged += new System.EventHandler(this.DarkThemeCheckBox_CheckedChanged);
            // 
            // DeadLineToDoLabel
            // 
            this.DeadLineToDoLabel.AutoSize = true;
            this.DeadLineToDoLabel.Depth = 0;
            this.DeadLineToDoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DeadLineToDoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadLineToDoLabel.Location = new System.Drawing.Point(8, 128);
            this.DeadLineToDoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeadLineToDoLabel.Name = "DeadLineToDoLabel";
            this.DeadLineToDoLabel.Size = new System.Drawing.Size(0, 19);
            this.DeadLineToDoLabel.TabIndex = 9;
            // 
            // AddDataButton
            // 
            this.AddDataButton.Depth = 0;
            this.AddDataButton.Location = new System.Drawing.Point(238, 444);
            this.AddDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Primary = true;
            this.AddDataButton.Size = new System.Drawing.Size(93, 35);
            this.AddDataButton.TabIndex = 7;
            this.AddDataButton.Text = "Добавить";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(270, 70);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 6;
            this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Дата выполнения:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 174);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Необходимо сделать:";
            // 
            // ToDoText
            // 
            this.ToDoText.Depth = 0;
            this.ToDoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDoText.Hint = "";
            this.ToDoText.Location = new System.Drawing.Point(30, 209);
            this.ToDoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToDoText.Name = "ToDoText";
            this.ToDoText.PasswordChar = '\0';
            this.ToDoText.SelectedText = "";
            this.ToDoText.SelectionLength = 0;
            this.ToDoText.SelectionStart = 0;
            this.ToDoText.Size = new System.Drawing.Size(160, 23);
            this.ToDoText.TabIndex = 3;
            this.ToDoText.UseSystemPasswordChar = false;
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Depth = 0;
            this.DeleteDataButton.Location = new System.Drawing.Point(476, 444);
            this.DeleteDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Primary = true;
            this.DeleteDataButton.Size = new System.Drawing.Size(93, 35);
            this.DeleteDataButton.TabIndex = 2;
            this.DeleteDataButton.Text = "Удалить";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // DoneColumn
            // 
            this.DoneColumn.DataPropertyName = "Done";
            this.DoneColumn.HeaderText = "Выполнено";
            this.DoneColumn.Name = "DoneColumn";
            this.DoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DoneColumn.Width = 95;
            // 
            // ToDoColumn
            // 
            this.ToDoColumn.DataPropertyName = "ToDo";
            this.ToDoColumn.HeaderText = "Сделать";
            this.ToDoColumn.Name = "ToDoColumn";
            this.ToDoColumn.ReadOnly = true;
            this.ToDoColumn.Width = 246;
            // 
            // DateCompletionColumn
            // 
            this.DateCompletionColumn.DataPropertyName = "DateCompletion";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DateCompletionColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateCompletionColumn.HeaderText = "Дата выполнения";
            this.DateCompletionColumn.Name = "DateCompletionColumn";
            this.DateCompletionColumn.ReadOnly = true;
            this.DateCompletionColumn.Width = 126;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // ToDoDataGridView
            // 
            this.ToDoDataGridView.AllowUserToAddRows = false;
            this.ToDoDataGridView.AllowUserToDeleteRows = false;
            this.ToDoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToDoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.DateCompletionColumn,
            this.ToDoColumn,
            this.DoneColumn});
            this.ToDoDataGridView.Location = new System.Drawing.Point(5, 298);
            this.ToDoDataGridView.Name = "ToDoDataGridView";
            this.ToDoDataGridView.Size = new System.Drawing.Size(692, 122);
            this.ToDoDataGridView.TabIndex = 8;
            this.ToDoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToDoDataGridView_CellClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(500, 174);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(155, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Выполнено (статус):";
            // 
            // Accout
            // 
            this.Accout.Depth = 0;
            this.Accout.Location = new System.Drawing.Point(139, 444);
            this.Accout.MouseState = MaterialSkin.MouseState.HOVER;
            this.Accout.Name = "Accout";
            this.Accout.Primary = true;
            this.Accout.Size = new System.Drawing.Size(93, 35);
            this.Accout.TabIndex = 16;
            this.Accout.Text = "Аккаунт";
            this.Accout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(701, 491);
            this.Controls.Add(this.Accout);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.DoneText);
            this.Controls.Add(this.EditDataButton);
            this.Controls.Add(this.DarkThemeCheckBox);
            this.Controls.Add(this.DeadLineToDoLabel);
            this.Controls.Add(this.ToDoDataGridView);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ToDoText);
            this.Controls.Add(this.DeleteDataButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                               Планирование дня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField DoneText;
        private MaterialSkin.Controls.MaterialRaisedButton EditDataButton;
        private MaterialSkin.Controls.MaterialCheckBox DarkThemeCheckBox;
        private MaterialSkin.Controls.MaterialLabel DeadLineToDoLabel;
        private MaterialSkin.Controls.MaterialRaisedButton AddDataButton;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ToDoText;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompletionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridView ToDoDataGridView;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton Accout;
    }
}

