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
                dataGridViewOut_NVD.Columns[i].Width = 65;
                if(i >= 3)
                {
                    dataGridViewOut_NVD.Columns[i].Width = 85;
                }
            }
        }      

        private void buttonOpenFile_NVD_Click(object sender, EventArgs e)
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
        }

        private void buttonSaveFile_NVD_Click(object sender, EventArgs e)
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

        private void buttonChange_NVD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridViewOut_NVD.ColumnCount - 1; i++)
            {
                dataGridViewOut_NVD.Columns[i].ReadOnly = false;
            }
        }

        private void buttonReport_NVD_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

       
    }
}
