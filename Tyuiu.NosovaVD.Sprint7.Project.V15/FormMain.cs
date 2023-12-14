using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int[,] arrayValues;

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_NVD.ColumnCount = 7;
            dataGridViewOut_NVD.RowCount = 10;

            for (int i = 0; i < 7; i++)
            {
                dataGridViewOut_NVD.Columns[i].Width = 55;
                if(i >= 3)
                {
                    dataGridViewOut_NVD.Columns[i].Width = 75;
                }
            }
        }

        private void buttonDone_NVD_Click(object sender, EventArgs e)
        {

            try
            {
                int m = 7;
                int n = 10;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewOut_NVD.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonDone_NVD.Enabled = true;
                
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно");
            }
        }
    }
}
