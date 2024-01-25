using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using PDF = iTextSharp.text.pdf;
using PDFtext = iTextSharp.text;
using System.Text;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bDoc_Click(object sender, EventArgs e)
        {            
            if (CheckText())
            {
                List<string> text = new List<string>();
                text.Add($"{label1.Text} {tCity.Text}");
                text.Add("вторая");
                text.Add("asd");
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Word Document|*.docx";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(saveDialog.FileName, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                        mainPart.Document = new Document();
                        Body body = mainPart.Document.AppendChild(new Body());
                        foreach(string s in text)
                        {
                            Paragraph para = body.AppendChild(new Paragraph());
                            Run run = para.AppendChild(new Run());
                            run.AppendChild(new Text(s));
                        }                        
                    }                    
                }
            }
        }

        private bool CheckText()
        {
            if(tCity.Text.Trim().Length > 0)
            {                
                return true;
            }
            else
            {
                MessageBox.Show("Текстовое поле 1 пусто", "Ошибка");
                return false;
            }
        }

        private void bPdf_Click(object sender, EventArgs e)
        {
            if (CheckText())
            {
                List<string> text = new List<string>();
                text.Add($"{label1.Text} {tCity.Text}");
                text.Add("втораяbx");
                text.Add("asd");
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Document|*.pdf";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PDFtext.Document document = new PDFtext.Document();
                        PDF.PdfWriter writer = PDF.PdfWriter.GetInstance(document, fs);                        
                        document.Open();
                        foreach (string s in text)
                        {
                            document.Add(new PDFtext.Paragraph(s));
                        }
                        document.Close();
                    }
                }
            }
        }

        private void bCreateDocx_Click(object sender, EventArgs e)
        {
            WordProcesser wordProcesser = new WordProcesser("Z:\\dogovor.doc");
            var dictionary = new Dictionary<string, string>
            {
                {"<city>", tCity.Text.Trim()},
                {"<date>", dateTimePicker1.Value.ToShortDateString()},
                {"<arrendator_org>", tADat.Text.Trim()},
                {"<arrendator_surname>", tADatSurname.Text.Trim()},
                {"<arrendator_name>", tADatName.Text.Trim()},
                {"<arrendator_patronym>", tADatorPatronym.Text.Trim()},          
                {"<rent_org>", tADator.Text.Trim()},              
                {"<rent_surname>", tADatorSurname.Text.Trim()},
                {"<rent_name>", tADatorName.Text.Trim()},
                {"<rent_patronym>", tADatorPatronym.Text.Trim()},
            };
            wordProcesser.Process(dictionary);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
