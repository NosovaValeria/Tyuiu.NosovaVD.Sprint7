
namespace Tyuiu.NosovaVD.Sprint7.Project.V15
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_NVD = new System.Windows.Forms.Panel();
            this.labelSubjectArea_NVD = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.chartFunctions_NVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBack_NVD = new System.Windows.Forms.Button();
            this.splitterOne_NVD = new System.Windows.Forms.Splitter();
            this.panelTop_NVD.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions_NVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.buttonBack_NVD);
            this.panelTop_NVD.Controls.Add(this.labelSubjectArea_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(882, 51);
            this.panelTop_NVD.TabIndex = 1;
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
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 51);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(378, 399);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.splitterOne_NVD);
            this.panelRight.Controls.Add(this.chartFunctions_NVD);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(378, 51);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(504, 399);
            this.panelRight.TabIndex = 3;
            // 
            // chartFunctions_NVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunctions_NVD.ChartAreas.Add(chartArea1);
            this.chartFunctions_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunctions_NVD.Legends.Add(legend1);
            this.chartFunctions_NVD.Location = new System.Drawing.Point(0, 0);
            this.chartFunctions_NVD.Name = "chartFunctions_NVD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartFunctions_NVD.Series.Add(series1);
            this.chartFunctions_NVD.Size = new System.Drawing.Size(504, 399);
            this.chartFunctions_NVD.TabIndex = 0;
            this.chartFunctions_NVD.Text = "chart1";
            // 
            // buttonBack_NVD
            // 
            this.buttonBack_NVD.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBack_NVD.Location = new System.Drawing.Point(784, 0);
            this.buttonBack_NVD.Name = "buttonBack_NVD";
            this.buttonBack_NVD.Size = new System.Drawing.Size(98, 51);
            this.buttonBack_NVD.TabIndex = 0;
            this.buttonBack_NVD.Text = "Назад";
            this.buttonBack_NVD.UseVisualStyleBackColor = true;
            this.buttonBack_NVD.Click += new System.EventHandler(this.buttonBack_NVD_Click);
            // 
            // splitterOne_NVD
            // 
            this.splitterOne_NVD.Location = new System.Drawing.Point(0, 0);
            this.splitterOne_NVD.Name = "splitterOne_NVD";
            this.splitterOne_NVD.Size = new System.Drawing.Size(3, 399);
            this.splitterOne_NVD.TabIndex = 1;
            this.splitterOne_NVD.TabStop = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 497);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сводный отчет";
            this.panelTop_NVD.ResumeLayout(false);
            this.panelTop_NVD.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions_NVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NVD;
        private System.Windows.Forms.Label labelSubjectArea_NVD;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions_NVD;
        private System.Windows.Forms.Button buttonBack_NVD;
        private System.Windows.Forms.Splitter splitterOne_NVD;
    }
}