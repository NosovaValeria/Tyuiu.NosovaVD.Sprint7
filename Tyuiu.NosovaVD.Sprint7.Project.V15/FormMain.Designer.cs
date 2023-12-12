
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
            this.panelRight_NVD = new System.Windows.Forms.Panel();
            this.panelTop_NVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_NVD
            // 
            this.panelTop_NVD.Controls.Add(this.labelSubjectArea_NVD);
            this.panelTop_NVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NVD.Name = "panelTop_NVD";
            this.panelTop_NVD.Size = new System.Drawing.Size(882, 54);
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
            this.panelLeft_NVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NVD.Location = new System.Drawing.Point(0, 54);
            this.panelLeft_NVD.Name = "panelLeft_NVD";
            this.panelLeft_NVD.Size = new System.Drawing.Size(327, 399);
            this.panelLeft_NVD.TabIndex = 1;
            // 
            // panelRight_NVD
            // 
            this.panelRight_NVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NVD.Location = new System.Drawing.Point(327, 54);
            this.panelRight_NVD.Name = "panelRight_NVD";
            this.panelRight_NVD.Size = new System.Drawing.Size(555, 399);
            this.panelRight_NVD.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panelRight_NVD);
            this.Controls.Add(this.panelLeft_NVD);
            this.Controls.Add(this.panelTop_NVD);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.panelTop_NVD.ResumeLayout(false);
            this.panelTop_NVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NVD;
        private System.Windows.Forms.Label labelSubjectArea_NVD;
        private System.Windows.Forms.Panel panelLeft_NVD;
        private System.Windows.Forms.Panel panelRight_NVD;
    }
}

