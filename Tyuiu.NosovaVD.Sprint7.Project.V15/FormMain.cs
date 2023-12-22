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
            openFileDialog_NVD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static string[,] arrayValues;
        string openFilePath;
        static int rows, colums;
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_NVD.ColumnCount = 7;
            dataGridViewOut_NVD.RowCount = 10;

            for (int i = 0; i < 7; i++)
            {
                dataGridViewOut_NVD.Columns[i].Width = 85;
                if(i >= 3)
                {
                    dataGridViewOut_NVD.Columns[i].Width = 105;
                }
            }
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
                colums = arrayValues.Length / rows;

                dataGridViewOut_NVD.ColumnCount = colums;
                dataGridViewOut_NVD.RowCount = rows;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < colums; c++)
                    {
                        dataGridViewOut_NVD.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                dataGridViewOut_NVD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                buttonSaveFile_NVD.Enabled = true;
                buttonChange_NVD.Enabled = true;
                buttonReport_NVD.Enabled = true;
                buttonAdd_NVD.Enabled = true;
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
                saveFileDialogExcel_NVD.FileName = "FileTask7.csv";
                saveFileDialogExcel_NVD.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogExcel_NVD.ShowDialog();

                string path = saveFileDialogExcel_NVD.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewOut_NVD.RowCount;
                int columns = dataGridViewOut_NVD.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_NVD.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_NVD.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                    str = "";
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
        }

        private void buttonHelp_NVD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAdd_NVD_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOut_NVD.RowCount += 1;
                string[] a = {dataGridViewOut_NVD.Rows[rows].Cells[0].Value.ToString(),
                              dataGridViewOut_NVD.Rows[rows].Cells[1].Value.ToString(),
                              dataGridViewOut_NVD.Rows[rows].Cells[2].Value.ToString(),
                              dataGridViewOut_NVD.Rows[rows].Cells[3].Value.ToString(),
                              dataGridViewOut_NVD.Rows[rows].Cells[4].Value.ToString(),
                              dataGridViewOut_NVD.Rows[rows].Cells[5].Value.ToString(),
                              dataGridViewOut_NVD.Rows[rows].Cells[6].Value.ToString() };
                dataGridViewOut_NVD.Rows[rows].Cells[0].Value = rows + 1;
                dataGridViewOut_NVD.Rows[rows].Cells[1].Value = textBoxAddName_NVD.Text;
                dataGridViewOut_NVD.Rows[rows].Cells[2].Value = textBoxAddAdress_NVD.Text;
                dataGridViewOut_NVD.Rows[rows].Cells[3].Value = textBoxAddPhon_NVD.Text;
                dataGridViewOut_NVD.Rows[rows].Cells[4].Value = textBoxAddStatus_NVD.Text;
                dataGridViewOut_NVD.Rows[rows].Cells[5].Value = textBoxAddSalary_NVD.Text;
                dataGridViewOut_NVD.Rows[rows].Cells[6].Value = textBoxAddSrok_NVD.Text;
                for (int i = 0; i < colums; i++)
                {
                    dataGridViewOut_NVD.Rows[rows - 1].Cells[i].Value = a[i];
                }
                rows++;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReport_NVD_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

       
    }
}
