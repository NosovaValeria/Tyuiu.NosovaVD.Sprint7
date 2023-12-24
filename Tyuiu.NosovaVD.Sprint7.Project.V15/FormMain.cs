using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NosovaVD.Sprint7.Project.V15.Lib;

namespace Tyuiu.NosovaVD.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();          
            output();
            sortirovka();

        }
        public BindingList<Dogovors> dogovorList;
        private BindingSource bindingSource;
        private SortOrder currentSortOrder = SortOrder.Ascending;
        DataService ds = new DataService();
        static string[,] arrayValues;      
        string openFilePath;
        static int rows;

        public void output()
        { 
            openFileDialog_NVD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            dataGridViewOut_NVD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dogovorList = new BindingList<Dogovors>();
            bindingSource = new BindingSource(dogovorList, null);
            dataGridViewOut_NVD.DataSource = bindingSource;
            this.chartFunction_NVD.ChartAreas[0].AxisX.Title = "Шифр договора";
            this.chartFunction_NVD.ChartAreas[0].AxisY.Title = "Сумма работ по договору";
            for (int i = 0; i < dataGridViewOut_NVD.ColumnCount; i++)
            {
                dataGridViewOut_NVD.Columns[i].ReadOnly = true;
            }
        }
        public void sortirovka()
        {
            comboBoxSort_NVD.Items.AddRange(new string[] { "По умолчанию", "Шифр договора", "Наименование организации", "Адрес", "Телефон", "Сумма договора", "Срок работы по договору" });
            comboBoxSort_NVD.SelectedIndex = 0;
        }
        public void saveFile()
        {
            saveFileDialogExcel_NVD.FileName = "FileTask7.csv";
            saveFileDialogExcel_NVD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogExcel_NVD.ShowDialog();

            openFilePath = saveFileDialogExcel_NVD.FileName;

            FileInfo fileInfo = new FileInfo(openFilePath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(openFilePath);
            }

            int rows = dataGridViewOut_NVD.RowCount;
            int columns = dataGridViewOut_NVD.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((j != columns - 1) && dataGridViewOut_NVD.Rows[i].Cells[j].Value != null)
                    {
                        str = str + dataGridViewOut_NVD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_NVD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(openFilePath, str + Environment.NewLine, Encoding.Default);
                str = "";
            }
            for (int i = 0; i <= dataGridViewOut_NVD.ColumnCount - 1; i++)
            {
                dataGridViewOut_NVD.Columns[i].ReadOnly = true;
            }
        }

        public void statistiks()
        {
            chartFunction_NVD.Series[0].Points.Clear();
            int rows = dataGridViewOut_NVD.RowCount;

            for (int i = 0; i < rows -1; i++)
            {
                chartFunction_NVD.Series[0].Points.AddXY(dataGridViewOut_NVD.Rows[i].Cells[0].Value, dataGridViewOut_NVD.Rows[i].Cells[4].Value);
            }
            textBoxCount_NVD.Text = ds.Count(openFilePath).ToString();
            textBoxSumm_NVD.Text = ds.Sum(openFilePath).ToString();
            textBoxSr_NVD.Text = ds.Srednee(openFilePath).ToString();
            textBoxMinValue_NVD.Text = ds.Min(openFilePath).ToString();
            textBoxMaxValue_NVD.Text = ds.Max(openFilePath).ToString();

        }
        private void buttonOpenFile_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_NVD.ShowDialog();
                openFilePath = openFileDialog_NVD.FileName;
                arrayValues = ds.LoadFromFileData(openFilePath);

                dataGridViewOut_NVD.Rows.Clear();
                

                rows = arrayValues.GetUpperBound(0) + 1;
                for (int i = 0; i < rows; i++)
                {
                    dogovorList.Add(new Dogovors
                    {
                        Shifr_Dogovora = Convert.ToInt32(arrayValues[i, 0]),
                        Name_Organizacii = arrayValues[i, 1],
                        Adress = arrayValues[i, 2],
                        Phone = arrayValues[i, 3],
                        Summa_Dogovora = Convert.ToInt32(arrayValues[i, 4]),
                        Srok_rabot_po_dogovoru = arrayValues[i, 5]
                    });                                          
                }
                statistiks();

                buttonSaveFile_NVD.Enabled = true;
                buttonChange_NVD.Enabled = true;
                buttonAdd_NVD.Enabled = true;
                comboBoxSort_NVD.Enabled = true;
                textBoxPoisk_NVD.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Сохранить данные в файл?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                    statistiks();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChange_NVD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridViewOut_NVD.ColumnCount - 1; i++)
            {
                dataGridViewOut_NVD.Columns[i].ReadOnly = false;
            }
            MessageBox.Show("После редактирования необходимо пересохранить данные в файле", "Сообщение");
        }

        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAddName_NVD.Text != "" && textBoxAddAdress_NVD.Text != "" && textBoxAddPhon_NVD.Text != "" && textBoxAddSum_NVD.Text != "" && textBoxAddSrok_NVD.Text != "")
                {
                    dogovorList.Add(new Dogovors
                    {
                        Shifr_Dogovora = Convert.ToInt32(textBoxAddShifr_NVD.Text),
                        Name_Organizacii = textBoxAddName_NVD.Text,
                        Adress = textBoxAddAdress_NVD.Text,
                        Phone = textBoxAddPhon_NVD.Text,
                        Summa_Dogovora = Convert.ToInt32(textBoxAddSum_NVD.Text),
                        Srok_rabot_po_dogovoru = textBoxAddSrok_NVD.Text
                    });
                    DialogResult result = MessageBox.Show("Рекомендуем пересохранить данные в файле!\nСохранить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        saveFile();
                        statistiks();
                    }
                    textBoxAddShifr_NVD.Text = "";
                    textBoxAddName_NVD.Text = "";
                    textBoxAddAdress_NVD.Text = "";
                    textBoxAddPhon_NVD.Text = "";
                    textBoxAddSum_NVD.Text = "";
                    textBoxAddSrok_NVD.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSort_NVD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (currentSortOrder == SortOrder.Ascending)
            {
                switch (comboBoxSort_NVD.SelectedIndex)
                {
                    case 0:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Shifr_Dogovora).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                    case 1:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Shifr_Dogovora).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                    case 2:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Name_Organizacii).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                    case 3:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Adress).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                    case 4:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Phone).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                    case 5:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Summa_Dogovora).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                    case 6:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderBy(x => x.Srok_rabot_po_dogovoru).ToList());
                        currentSortOrder = SortOrder.Descending;
                        break;
                }
            }
            else
            {
                switch (comboBoxSort_NVD.SelectedIndex)
                {
                    case 0:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Shifr_Dogovora).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                    case 1:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Shifr_Dogovora).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                    case 2:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Name_Organizacii).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                    case 3:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Adress).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                    case 4:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Phone).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                    case 5:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Summa_Dogovora).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                    case 6:
                        dogovorList = new BindingList<Dogovors>(dogovorList.OrderByDescending(x => x.Srok_rabot_po_dogovoru).ToList());
                        currentSortOrder = SortOrder.Ascending;
                        break;
                }
            }

            dataGridViewOut_NVD.DataSource = dogovorList;
        }

        private void textBoxPoisk_NVD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPoisk_NVD.Text.Trim() == "")
            {
                dataGridViewOut_NVD.DataSource = dogovorList;
            }
            else
            {
                var Results = dogovorList.Where(staff =>
                    staff.Shifr_Dogovora.ToString().Contains(textBoxPoisk_NVD.Text) ||
                    staff.Name_Organizacii.ToString().Contains(textBoxPoisk_NVD.Text) ||
                    staff.Adress.ToString().Contains(textBoxPoisk_NVD.Text) ||
                    staff.Phone.ToString().Contains(textBoxPoisk_NVD.Text) ||
                    staff.Summa_Dogovora.ToString().Contains(textBoxPoisk_NVD.Text) ||
                    staff.Srok_rabot_po_dogovoru.ToString().Contains(textBoxPoisk_NVD.Text)
                ).ToList();
                dataGridViewOut_NVD.DataSource = new BindingList<Dogovors>(Results);
            }
        }

        private void buttonInfo_NVD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_NVD_Click_1(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
    }
}
