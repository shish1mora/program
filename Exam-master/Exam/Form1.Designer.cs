namespace Exam
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
            this.tCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDoc = new System.Windows.Forms.Button();
            this.bPdf = new System.Windows.Forms.Button();
            this.bCreateDocx = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tADat = new System.Windows.Forms.TextBox();
            this.tADator = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tADatPatronym = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tADatName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tADatSurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tADatorPatronym = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tADatorName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tADatorSurname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCity
            // 
            this.tCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCity.Location = new System.Drawing.Point(200, 11);
            this.tCity.Name = "tCity";
            this.tCity.Size = new System.Drawing.Size(214, 22);
            this.tCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bDoc
            // 
            this.bDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDoc.Location = new System.Drawing.Point(278, 455);
            this.bDoc.Name = "bDoc";
            this.bDoc.Size = new System.Drawing.Size(75, 23);
            this.bDoc.TabIndex = 2;
            this.bDoc.Text = "DocX";
            this.bDoc.UseVisualStyleBackColor = true;
            this.bDoc.Click += new System.EventHandler(this.bDoc_Click);
            // 
            // bPdf
            // 
            this.bPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPdf.Location = new System.Drawing.Point(359, 455);
            this.bPdf.Name = "bPdf";
            this.bPdf.Size = new System.Drawing.Size(75, 23);
            this.bPdf.TabIndex = 3;
            this.bPdf.Text = "PDF";
            this.bPdf.UseVisualStyleBackColor = true;
            this.bPdf.Click += new System.EventHandler(this.bPdf_Click);
            // 
            // bCreateDocx
            // 
            this.bCreateDocx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCreateDocx.Location = new System.Drawing.Point(16, 455);
            this.bCreateDocx.Name = "bCreateDocx";
            this.bCreateDocx.Size = new System.Drawing.Size(75, 23);
            this.bCreateDocx.TabIndex = 4;
            this.bCreateDocx.Text = "Create";
            this.bCreateDocx.UseVisualStyleBackColor = true;
            this.bCreateDocx.Click += new System.EventHandler(this.bCreateDocx_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tADat
            // 
            this.tADat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADat.Location = new System.Drawing.Point(200, 92);
            this.tADat.Name = "tADat";
            this.tADat.Size = new System.Drawing.Size(215, 22);
            this.tADat.TabIndex = 8;
            // 
            // tADator
            // 
            this.tADator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADator.Location = new System.Drawing.Point(200, 272);
            this.tADator.Name = "tADator";
            this.tADator.Size = new System.Drawing.Size(214, 22);
            this.tADator.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tADatPatronym);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tADatName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tADatSurname);
            this.groupBox1.Location = new System.Drawing.Point(15, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Представитель \"Арендодателя\"";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Отчество:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tADatPatronym
            // 
            this.tADatPatronym.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADatPatronym.Location = new System.Drawing.Point(185, 103);
            this.tADatPatronym.Name = "tADatPatronym";
            this.tADatPatronym.Size = new System.Drawing.Size(214, 22);
            this.tADatPatronym.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Имя:";
            // 
            // tADatName
            // 
            this.tADatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADatName.Location = new System.Drawing.Point(185, 67);
            this.tADatName.Name = "tADatName";
            this.tADatName.Size = new System.Drawing.Size(214, 22);
            this.tADatName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Фамилия:";
            // 
            // tADatSurname
            // 
            this.tADatSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADatSurname.Location = new System.Drawing.Point(185, 32);
            this.tADatSurname.Name = "tADatSurname";
            this.tADatSurname.Size = new System.Drawing.Size(214, 22);
            this.tADatSurname.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tADatorPatronym);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tADatorName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tADatorSurname);
            this.groupBox2.Location = new System.Drawing.Point(-4, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 135);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Представитель \"Арендатора\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Отчество:";
            // 
            // tADatorPatronym
            // 
            this.tADatorPatronym.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADatorPatronym.Location = new System.Drawing.Point(184, 103);
            this.tADatorPatronym.Name = "tADatorPatronym";
            this.tADatorPatronym.Size = new System.Drawing.Size(215, 22);
            this.tADatorPatronym.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Имя:";
            // 
            // tADatorName
            // 
            this.tADatorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADatorName.Location = new System.Drawing.Point(184, 67);
            this.tADatorName.Name = "tADatorName";
            this.tADatorName.Size = new System.Drawing.Size(215, 22);
            this.tADatorName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Фамилия:";
            // 
            // tADatorSurname
            // 
            this.tADatorSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tADatorSurname.Location = new System.Drawing.Point(184, 32);
            this.tADatorSurname.Name = "tADatorSurname";
            this.tADatorSurname.Size = new System.Drawing.Size(215, 22);
            this.tADatorSurname.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tADator);
            this.Controls.Add(this.tADat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCreateDocx);
            this.Controls.Add(this.bPdf);
            this.Controls.Add(this.bDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tCity);
            this.MinimumSize = new System.Drawing.Size(430, 225);
            this.Name = "Form1";
            this.Text = "Демонстрационное приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCity;
        private System.Windows.Forms.Button bDoc;
        private System.Windows.Forms.Button bPdf;
        private System.Windows.Forms.Button bCreateDocx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tADat;
        private System.Windows.Forms.TextBox tADator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tADatPatronym;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tADatName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tADatSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tADatorPatronym;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tADatorName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tADatorSurname;
    }
}

