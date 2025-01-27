using System;
using System.IO;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Export;
using Newtonsoft.Json;

namespace JsonToPdfReportGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "Ожидание...";
        }

        private void buttonLoadJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxJsonPath.Text = openFileDialog.FileName;
                    labelStatus.Text = "Файл загружен: " + openFileDialog.FileName;
                }
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            string jsonFilePath = textBoxJsonPath.Text;

            if (!File.Exists(jsonFilePath))
            {
                labelStatus.Text = "Ошибка: файл не найден.";
                return;
            }

            // Создаем отчет
            StiReport report = new StiReport();


            try
            {
                string reportTemplatePath = "report_template.mrt"; 
                report.Load(reportTemplatePath);

                // Подключение JSON-данных
                string jsonData = File.ReadAllText(jsonFilePath);
                var jsonObject = JsonConvert.DeserializeObject(jsonData);

                report.RegData("MyData", jsonObject);

                report.Render();

                // Сохранение отчета в PDF
                string outputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output_report.pdf");
                StiPdfExportSettings pdfExportSettings = new StiPdfExportSettings();
                report.ExportDocument(StiExportFormat.Pdf, outputFilePath, pdfExportSettings);

                labelStatus.Text = "Отчет успешно создан: " + outputFilePath;
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Ошибка: " + ex.Message;
            }
        }

        // Метод для настройки стилей
        private void CustomizeComponents()
        {
            // Настройка текстового поля
            textBoxJsonPath.BorderStyle = BorderStyle.FixedSingle; 
            textBoxJsonPath.Font = new System.Drawing.Font("Arial", 10);
            textBoxJsonPath.Location = new System.Drawing.Point(20, 20);
            textBoxJsonPath.Size = new System.Drawing.Size(350, 50); 



            // Настройка кнопки загрузки JSON
            buttonLoadJson.BackColor = System.Drawing.Color.LightSkyBlue;
            buttonLoadJson.ForeColor = System.Drawing.Color.White;
            buttonLoadJson.FlatStyle = FlatStyle.Flat;
            buttonLoadJson.Font = new System.Drawing.Font("Arial Bold", 10);
            buttonLoadJson.Location = new System.Drawing.Point(380, 20);
            buttonLoadJson.Size = new System.Drawing.Size(100, 30);
            buttonLoadJson.Text = "Загрузить JSON";

            // Настройка кнопки генерации отчета
            buttonGenerateReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            buttonGenerateReport.ForeColor = System.Drawing.Color.White;
            buttonGenerateReport.FlatStyle = FlatStyle.Flat;
            buttonGenerateReport.Font = new System.Drawing.Font("Arial Bold", 10);
            buttonGenerateReport.Location = new System.Drawing.Point(20, 70);
            buttonGenerateReport.Size = new System.Drawing.Size(460, 30);
            buttonGenerateReport.Text = "Сгенерировать отчет";

            // Настройка метки статуса
            labelStatus.Location = new System.Drawing.Point(20, 110);
            labelStatus.Size = new System.Drawing.Size(460, 40);
            labelStatus.Font = new System.Drawing.Font("Arial", 10);
            labelStatus.ForeColor = System.Drawing.Color.Gray;
            labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Общие настройки формы
            this.Text = "Отчет JSON в PDF";
            this.Size = new System.Drawing.Size(500, 180);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
