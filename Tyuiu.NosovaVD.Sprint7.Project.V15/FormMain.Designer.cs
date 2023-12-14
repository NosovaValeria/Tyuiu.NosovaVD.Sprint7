
namespace Tyuiu.NosovaVD.Sprint7.Project.V15
{
    partial class FormMain
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
            this.panelTop_NVD = new System.Windows.Forms.Panel();
            this.labelSubjectArea_NVD = new System.Windows.Forms.Label();
            this.panelLeft_NVD = new System.Windows.Forms.Panel();
            this.groupBoxInput_NVD = new System.Windows.Forms.GroupBox();
            this.textBoxNumber_NVD = new System.Windows.Forms.TextBox();
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.dataGridViewOut_NVD = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_NVD = new System.Windows.Forms.Button();
            this.panelTop_NVD.SuspendLayout();
            this.panelLeft_NVD.SuspendLayout();
            this.groupBoxInput_NVD.SuspendLayout();
            this.panelRight_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.labelSubjectArea_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(982, 54);
            this.panelTop_NVD.TabIndex = 0;
            // 
            // labelSubjectArea_NVD
            // 
            this.labelSubjectArea_NVD.AutoSize = true;
            this.labelSubjectArea_NVD.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubjectArea_NVD.Location = new System.Drawing.Point(12, 9);
            this.labelSubjectArea_NVD.Name = "labelSubjectArea_NVD";
            this.labelSubjectArea_NVD.Size = new System.Drawing.Size(324, 20);
            this.labelSubjectArea_NVD.TabIndex = 1;
            this.labelSubjectArea_NVD.Text = "Договорная деятельность организации";
            // 
            // panelLeft_NVD
            // 
            this.panelLeft_NVD.Controls.Add(this.groupBoxInput_NVD);
            this.panelLeft_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NVD.Location = new System.Drawing.Point(0, 54);
            this.panelLeft_NVD.Name = "panelLeft_NVD";
            this.panelLeft_NVD.Size = new System.Drawing.Size(327, 399);
            this.panelLeft_NVD.TabIndex = 1;
            // 
            // groupBoxInput_NVD
            // 
            this.groupBoxInput_NVD.Controls.Add(this.buttonDone_NVD);
            this.groupBoxInput_NVD.Controls.Add(this.textBoxNumber_NVD);
            this.groupBoxInput_NVD.Location = new System.Drawing.Point(16, 15);
            this.groupBoxInput_NVD.Name = "groupBoxInput_NVD";
            this.groupBoxInput_NVD.Size = new System.Drawing.Size(289, 357);
            this.groupBoxInput_NVD.TabIndex = 1;
            this.groupBoxInput_NVD.TabStop = false;
            this.groupBoxInput_NVD.Text = "Ввод данных";
            // 
            // textBoxNumber_NVD
            // 
            this.textBoxNumber_NVD.Location = new System.Drawing.Point(6, 40);
            this.textBoxNumber_NVD.Multiline = true;
            this.textBoxNumber_NVD.Name = "textBoxNumber_NVD";
            this.textBoxNumber_NVD.Size = new System.Drawing.Size(188, 28);
            this.textBoxNumber_NVD.TabIndex = 0;
            // 
            // panelRight_NVD
            // 
            this.panelRight_NVD.Controls.Add(this.dataGridViewOut_NVD);
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(327, 54);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(655, 399);
            this.panelRight_NVD.TabIndex = 2;
            // 
            // dataGridViewOut_NVD
            // 
            this.dataGridViewOut_NVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_NVD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NamePerson,
            this.Adress,
            this.Phone,
            this.Post,
            this.Salary,
            this.Term});
            this.dataGridViewOut_NVD.Location = new System.Drawing.Point(25, 55);
            this.dataGridViewOut_NVD.Name = "dataGridViewOut_NVD";
            this.dataGridViewOut_NVD.RowHeadersVisible = false;
            this.dataGridViewOut_NVD.RowHeadersWidth = 51;
            this.dataGridViewOut_NVD.RowTemplate.Height = 24;
            this.dataGridViewOut_NVD.Size = new System.Drawing.Size(618, 317);
            this.dataGridViewOut_NVD.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // NamePerson
            // 
            this.NamePerson.HeaderText = "ФИО";
            this.NamePerson.MinimumWidth = 6;
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.ReadOnly = true;
            this.NamePerson.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Адрес";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.MinimumWidth = 6;
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 125;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Оклад сотрудников";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 125;
            // 
            // Term
            // 
            this.Term.HeaderText = "Сроки работы по договору";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            this.Term.Width = 125;
            // 
            // buttonDone_NVD
            // 
            this.buttonDone_NVD.Location = new System.Drawing.Point(163, 315);
            this.buttonDone_NVD.Name = "buttonDone_NVD";
            this.buttonDone_NVD.Size = new System.Drawing.Size(120, 36);
            this.buttonDone_NVD.TabIndex = 1;
            this.buttonDone_NVD.Text = "Выполнить";
            this.buttonDone_NVD.UseVisualStyleBackColor = true;
            this.buttonDone_NVD.Click += new System.EventHandler(this.buttonDone_NVD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_NVD.ResumeLayout(false);
            this.panelTop_NVD.PerformLayout();
            this.panelLeft_NVD.ResumeLayout(false);
            this.groupBoxInput_NVD.ResumeLayout(false);
            this.groupBoxInput_NVD.PerformLayout();
            this.panelRight_NVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NVD;
        private System.Windows.Forms.Label labelSubjectArea_NVD;
        private System.Windows.Forms.Panel panelLeft_NVD;
        private System.Windows.Forms.Panel panelRight_NVD;
        private System.Windows.Forms.DataGridView dataGridViewOut_NVD;
        private System.Windows.Forms.GroupBox groupBoxInput_NVD;
        private System.Windows.Forms.TextBox textBoxNumber_NVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.Button buttonDone_NVD;
    }
}

