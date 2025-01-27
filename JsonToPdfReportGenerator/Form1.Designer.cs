namespace JsonToPdfReportGenerator
{
    partial class Form1
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
            this.textBoxJsonPath = new System.Windows.Forms.TextBox();
            this.buttonLoadJson = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxJsonPath
            // 
            this.textBoxJsonPath.Location = new System.Drawing.Point(345, 26);
            this.textBoxJsonPath.Name = "textBoxJsonPath";
            this.textBoxJsonPath.Size = new System.Drawing.Size(170, 22);
            this.textBoxJsonPath.TabIndex = 0;
            // 
            // buttonLoadJson
            // 
            this.buttonLoadJson.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadJson.Location = new System.Drawing.Point(548, 11);
            this.buttonLoadJson.Name = "buttonLoadJson";
            this.buttonLoadJson.Size = new System.Drawing.Size(196, 23);
            this.buttonLoadJson.TabIndex = 1;
            this.buttonLoadJson.Text = "Загрузить JSON";
            this.buttonLoadJson.UseVisualStyleBackColor = true;
            this.buttonLoadJson.Click += new System.EventHandler(this.buttonLoadJson_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Font = new System.Drawing.Font("Poor Richard", 7.8F);
            this.buttonGenerateReport.Location = new System.Drawing.Point(548, 41);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(196, 23);
            this.buttonGenerateReport.TabIndex = 2;
            this.buttonGenerateReport.Text = "Сгенерировать отчет";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(408, 61);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 509);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.buttonLoadJson);
            this.Controls.Add(this.textBoxJsonPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJsonPath;
        private System.Windows.Forms.Button buttonLoadJson;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelStatus;
    }
}

