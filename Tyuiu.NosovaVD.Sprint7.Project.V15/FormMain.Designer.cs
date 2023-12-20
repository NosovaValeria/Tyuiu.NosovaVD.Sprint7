
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
            this.components = new System.ComponentModel.Container();
            this.panelTop_NVD = new System.Windows.Forms.Panel();
            this.labelSubjectArea_NVD = new System.Windows.Forms.Label();
            this.panelLeft_NVD = new System.Windows.Forms.Panel();
            this.groupBoxInput_NVD = new System.Windows.Forms.GroupBox();
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.dataGridViewOut_NVD = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog_NVD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExcel_NVD = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_NVD = new System.Windows.Forms.ToolTip(this.components);
            this.buttonChange_NVD = new System.Windows.Forms.Button();
            this.buttonReport_NVD = new System.Windows.Forms.Button();
            this.buttonSaveFile_NVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_NVD = new System.Windows.Forms.Button();
            this.buttonHelp_NVD = new System.Windows.Forms.Button();
            this.panelTop_NVD.SuspendLayout();
            this.panelLeft_NVD.SuspendLayout();
            this.groupBoxInput_NVD.SuspendLayout();
            this.panelRight_NVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.buttonHelp_NVD);
            this.panelTop_NVD.Controls.Add(this.labelSubjectArea_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(1182, 54);
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
            this.panelLeft_NVD.Size = new System.Drawing.Size(252, 499);
            this.panelLeft_NVD.TabIndex = 1;
            // 
            // groupBoxInput_NVD
            // 
            this.groupBoxInput_NVD.Controls.Add(this.buttonSaveFile_NVD);
            this.groupBoxInput_NVD.Controls.Add(this.buttonOpenFile_NVD);
            this.groupBoxInput_NVD.Location = new System.Drawing.Point(12, 6);
            this.groupBoxInput_NVD.Name = "groupBoxInput_NVD";
            this.groupBoxInput_NVD.Size = new System.Drawing.Size(234, 481);
            this.groupBoxInput_NVD.TabIndex = 1;
            this.groupBoxInput_NVD.TabStop = false;
            this.groupBoxInput_NVD.Text = "Ввод данных";
            // 
            // panelRight_NVD
            // 
            this.panelRight_NVD.Controls.Add(this.buttonChange_NVD);
            this.panelRight_NVD.Controls.Add(this.buttonReport_NVD);
            this.panelRight_NVD.Controls.Add(this.dataGridViewOut_NVD);
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(252, 54);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(930, 499);
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
            this.dataGridViewOut_NVD.Location = new System.Drawing.Point(22, 18);
            this.dataGridViewOut_NVD.Name = "dataGridViewOut_NVD";
            this.dataGridViewOut_NVD.RowHeadersVisible = false;
            this.dataGridViewOut_NVD.RowHeadersWidth = 51;
            this.dataGridViewOut_NVD.RowTemplate.Height = 24;
            this.dataGridViewOut_NVD.Size = new System.Drawing.Size(896, 418);
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
            this.Salary.HeaderText = "Оклад";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 125;
            // 
            // Term
            // 
            this.Term.HeaderText = "Срок работы по договору";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            this.Term.Width = 125;
            // 
            // openFileDialog_NVD
            // 
            this.openFileDialog_NVD.FileName = "openFileDialog";
            // 
            // toolTip_NVD
            // 
            this.toolTip_NVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NVD.ToolTipTitle = "Подсказка";
            // 
            // buttonChange_NVD
            // 
            this.buttonChange_NVD.Enabled = false;
            this.buttonChange_NVD.Image = global::Tyuiu.NosovaVD.Sprint7.Project.V15.Properties.Resources.page_edit;
            this.buttonChange_NVD.Location = new System.Drawing.Point(727, 439);
            this.buttonChange_NVD.Name = "buttonChange_NVD";
            this.buttonChange_NVD.Size = new System.Drawing.Size(77, 57);
            this.buttonChange_NVD.TabIndex = 4;
            this.toolTip_NVD.SetToolTip(this.buttonChange_NVD, "Редактировать таблицу");
            this.buttonChange_NVD.UseVisualStyleBackColor = true;
            this.buttonChange_NVD.Click += new System.EventHandler(this.buttonChange_NVD_Click);
            // 
            // buttonReport_NVD
            // 
            this.buttonReport_NVD.Enabled = false;
            this.buttonReport_NVD.Image = global::Tyuiu.NosovaVD.Sprint7.Project.V15.Properties.Resources.chart_curve_edit;
            this.buttonReport_NVD.Location = new System.Drawing.Point(829, 439);
            this.buttonReport_NVD.Name = "buttonReport_NVD";
            this.buttonReport_NVD.Size = new System.Drawing.Size(77, 57);
            this.buttonReport_NVD.TabIndex = 1;
            this.toolTip_NVD.SetToolTip(this.buttonReport_NVD, "Построить график по данным");
            this.buttonReport_NVD.UseVisualStyleBackColor = true;
            this.buttonReport_NVD.Click += new System.EventHandler(this.buttonReport_NVD_Click);
            // 
            // buttonSaveFile_NVD
            // 
            this.buttonSaveFile_NVD.Enabled = false;
            this.buttonSaveFile_NVD.Image = global::Tyuiu.NosovaVD.Sprint7.Project.V15.Properties.Resources.page_save;
            this.buttonSaveFile_NVD.Location = new System.Drawing.Point(140, 418);
            this.buttonSaveFile_NVD.Name = "buttonSaveFile_NVD";
            this.buttonSaveFile_NVD.Size = new System.Drawing.Size(77, 57);
            this.buttonSaveFile_NVD.TabIndex = 3;
            this.toolTip_NVD.SetToolTip(this.buttonSaveFile_NVD, "Сохранить данные в файл в формате CSV");
            this.buttonSaveFile_NVD.UseVisualStyleBackColor = true;
            this.buttonSaveFile_NVD.Click += new System.EventHandler(this.buttonSaveFile_NVD_Click);
            // 
            // buttonOpenFile_NVD
            // 
            this.buttonOpenFile_NVD.Image = global::Tyuiu.NosovaVD.Sprint7.Project.V15.Properties.Resources.page_go;
            this.buttonOpenFile_NVD.Location = new System.Drawing.Point(6, 416);
            this.buttonOpenFile_NVD.Name = "buttonOpenFile_NVD";
            this.buttonOpenFile_NVD.Size = new System.Drawing.Size(77, 60);
            this.buttonOpenFile_NVD.TabIndex = 2;
            this.toolTip_NVD.SetToolTip(this.buttonOpenFile_NVD, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_NVD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_NVD.Click += new System.EventHandler(this.buttonOpenFile_NVD_Click);
            // 
            // buttonHelp_NVD
            // 
            this.buttonHelp_NVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NVD.Image = global::Tyuiu.NosovaVD.Sprint7.Project.V15.Properties.Resources.help;
            this.buttonHelp_NVD.Location = new System.Drawing.Point(1113, 0);
            this.buttonHelp_NVD.Name = "buttonHelp_NVD";
            this.buttonHelp_NVD.Size = new System.Drawing.Size(66, 51);
            this.buttonHelp_NVD.TabIndex = 3;
            this.toolTip_NVD.SetToolTip(this.buttonHelp_NVD, "Сведение о программе");
            this.buttonHelp_NVD.UseVisualStyleBackColor = true;
            this.buttonHelp_NVD.Click += new System.EventHandler(this.buttonHelp_NVD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_NVD.ResumeLayout(false);
            this.panelTop_NVD.PerformLayout();
            this.panelLeft_NVD.ResumeLayout(false);
            this.groupBoxInput_NVD.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonReport_NVD;
        private System.Windows.Forms.Button buttonOpenFile_NVD;
        private System.Windows.Forms.OpenFileDialog openFileDialog_NVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.Button buttonSaveFile_NVD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel_NVD;
        private System.Windows.Forms.ToolTip toolTip_NVD;
        private System.Windows.Forms.Button buttonChange_NVD;
        private System.Windows.Forms.Button buttonHelp_NVD;
    }
}

