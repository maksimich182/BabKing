namespace BabKing
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
            this.tbResourceFileDir = new System.Windows.Forms.TextBox();
            this.btChooseResourceFile = new System.Windows.Forms.Button();
            this.tbResultFileDir = new System.Windows.Forms.TextBox();
            this.btChooseResultFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbBlockLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCoding = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btDecoding = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResourceFileDecode = new System.Windows.Forms.TextBox();
            this.btChooseResultFileDecode = new System.Windows.Forms.Button();
            this.tbResultFileDecode = new System.Windows.Forms.TextBox();
            this.btChooseResourceFileDecode = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btGetRandom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbResourceFileRnd = new System.Windows.Forms.TextBox();
            this.btChooseResultFileRnd = new System.Windows.Forms.Button();
            this.tbResultFileRnd = new System.Windows.Forms.TextBox();
            this.btChooseResourceFileRnd = new System.Windows.Forms.Button();
            this.tbRndLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbResourceFileDir
            // 
            this.tbResourceFileDir.Location = new System.Drawing.Point(104, 6);
            this.tbResourceFileDir.Name = "tbResourceFileDir";
            this.tbResourceFileDir.Size = new System.Drawing.Size(260, 20);
            this.tbResourceFileDir.TabIndex = 0;
            // 
            // btChooseResourceFile
            // 
            this.btChooseResourceFile.Location = new System.Drawing.Point(370, 6);
            this.btChooseResourceFile.Name = "btChooseResourceFile";
            this.btChooseResourceFile.Size = new System.Drawing.Size(25, 20);
            this.btChooseResourceFile.TabIndex = 1;
            this.btChooseResourceFile.Text = "...";
            this.btChooseResourceFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btChooseResourceFile.UseVisualStyleBackColor = true;
            this.btChooseResourceFile.Click += new System.EventHandler(this.btChooseResourceFile_Click);
            // 
            // tbResultFileDir
            // 
            this.tbResultFileDir.Location = new System.Drawing.Point(104, 32);
            this.tbResultFileDir.Name = "tbResultFileDir";
            this.tbResultFileDir.Size = new System.Drawing.Size(260, 20);
            this.tbResultFileDir.TabIndex = 0;
            // 
            // btChooseResultFile
            // 
            this.btChooseResultFile.Location = new System.Drawing.Point(370, 32);
            this.btChooseResultFile.Name = "btChooseResultFile";
            this.btChooseResultFile.Size = new System.Drawing.Size(25, 19);
            this.btChooseResultFile.TabIndex = 2;
            this.btChooseResultFile.Text = "...";
            this.btChooseResultFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btChooseResultFile.UseVisualStyleBackColor = true;
            this.btChooseResultFile.Click += new System.EventHandler(this.btChooseResultFile_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 118);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbBlockLength);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btCoding);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbResourceFileDir);
            this.tabPage1.Controls.Add(this.btChooseResultFile);
            this.tabPage1.Controls.Add(this.tbResultFileDir);
            this.tabPage1.Controls.Add(this.btChooseResourceFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кодер";
            // 
            // tbBlockLength
            // 
            this.tbBlockLength.Location = new System.Drawing.Point(104, 63);
            this.tbBlockLength.Name = "tbBlockLength";
            this.tbBlockLength.Size = new System.Drawing.Size(40, 20);
            this.tbBlockLength.TabIndex = 7;
            this.tbBlockLength.Text = "63";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Длина блока";
            // 
            // btCoding
            // 
            this.btCoding.Location = new System.Drawing.Point(320, 66);
            this.btCoding.Name = "btCoding";
            this.btCoding.Size = new System.Drawing.Size(75, 23);
            this.btCoding.TabIndex = 5;
            this.btCoding.Text = "Кодировать";
            this.btCoding.UseVisualStyleBackColor = true;
            this.btCoding.Click += new System.EventHandler(this.btCoding_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Файл результат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Файл данных";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btDecoding);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbResourceFileDecode);
            this.tabPage2.Controls.Add(this.btChooseResultFileDecode);
            this.tabPage2.Controls.Add(this.tbResultFileDecode);
            this.tabPage2.Controls.Add(this.btChooseResourceFileDecode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Декодер";
            // 
            // btDecoding
            // 
            this.btDecoding.Location = new System.Drawing.Point(300, 66);
            this.btDecoding.Name = "btDecoding";
            this.btDecoding.Size = new System.Drawing.Size(94, 23);
            this.btDecoding.TabIndex = 12;
            this.btDecoding.Text = "Декодировать";
            this.btDecoding.UseVisualStyleBackColor = true;
            this.btDecoding.Click += new System.EventHandler(this.btDecoding_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Файл результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Файл данных";
            // 
            // tbResourceFileDecode
            // 
            this.tbResourceFileDecode.Location = new System.Drawing.Point(103, 6);
            this.tbResourceFileDecode.Name = "tbResourceFileDecode";
            this.tbResourceFileDecode.Size = new System.Drawing.Size(260, 20);
            this.tbResourceFileDecode.TabIndex = 6;
            // 
            // btChooseResultFileDecode
            // 
            this.btChooseResultFileDecode.Location = new System.Drawing.Point(369, 32);
            this.btChooseResultFileDecode.Name = "btChooseResultFileDecode";
            this.btChooseResultFileDecode.Size = new System.Drawing.Size(25, 19);
            this.btChooseResultFileDecode.TabIndex = 9;
            this.btChooseResultFileDecode.Text = "...";
            this.btChooseResultFileDecode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btChooseResultFileDecode.UseVisualStyleBackColor = true;
            this.btChooseResultFileDecode.Click += new System.EventHandler(this.btChooseResultFileDecode_Click);
            // 
            // tbResultFileDecode
            // 
            this.tbResultFileDecode.Location = new System.Drawing.Point(103, 32);
            this.tbResultFileDecode.Name = "tbResultFileDecode";
            this.tbResultFileDecode.Size = new System.Drawing.Size(260, 20);
            this.tbResultFileDecode.TabIndex = 7;
            // 
            // btChooseResourceFileDecode
            // 
            this.btChooseResourceFileDecode.Location = new System.Drawing.Point(369, 6);
            this.btChooseResourceFileDecode.Name = "btChooseResourceFileDecode";
            this.btChooseResourceFileDecode.Size = new System.Drawing.Size(25, 20);
            this.btChooseResourceFileDecode.TabIndex = 8;
            this.btChooseResourceFileDecode.Text = "...";
            this.btChooseResourceFileDecode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btChooseResourceFileDecode.UseVisualStyleBackColor = true;
            this.btChooseResourceFileDecode.Click += new System.EventHandler(this.btChooseResourceFileDecode_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tbRndLength);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btGetRandom);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tbResourceFileRnd);
            this.tabPage3.Controls.Add(this.btChooseResultFileRnd);
            this.tabPage3.Controls.Add(this.tbResultFileRnd);
            this.tabPage3.Controls.Add(this.btChooseResourceFileRnd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(411, 92);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Случайность";
            // 
            // btGetRandom
            // 
            this.btGetRandom.Location = new System.Drawing.Point(320, 60);
            this.btGetRandom.Name = "btGetRandom";
            this.btGetRandom.Size = new System.Drawing.Size(75, 23);
            this.btGetRandom.TabIndex = 11;
            this.btGetRandom.Text = "Генерация";
            this.btGetRandom.UseVisualStyleBackColor = true;
            this.btGetRandom.Click += new System.EventHandler(this.btGetRandom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Файл результат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Файл данных";
            // 
            // tbResourceFileRnd
            // 
            this.tbResourceFileRnd.Location = new System.Drawing.Point(104, 9);
            this.tbResourceFileRnd.Name = "tbResourceFileRnd";
            this.tbResourceFileRnd.Size = new System.Drawing.Size(260, 20);
            this.tbResourceFileRnd.TabIndex = 5;
            // 
            // btChooseResultFileRnd
            // 
            this.btChooseResultFileRnd.Location = new System.Drawing.Point(370, 35);
            this.btChooseResultFileRnd.Name = "btChooseResultFileRnd";
            this.btChooseResultFileRnd.Size = new System.Drawing.Size(25, 19);
            this.btChooseResultFileRnd.TabIndex = 8;
            this.btChooseResultFileRnd.Text = "...";
            this.btChooseResultFileRnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btChooseResultFileRnd.UseVisualStyleBackColor = true;
            this.btChooseResultFileRnd.Click += new System.EventHandler(this.btChooseResultFileRnd_Click);
            // 
            // tbResultFileRnd
            // 
            this.tbResultFileRnd.Location = new System.Drawing.Point(104, 35);
            this.tbResultFileRnd.Name = "tbResultFileRnd";
            this.tbResultFileRnd.Size = new System.Drawing.Size(260, 20);
            this.tbResultFileRnd.TabIndex = 6;
            // 
            // btChooseResourceFileRnd
            // 
            this.btChooseResourceFileRnd.Location = new System.Drawing.Point(370, 9);
            this.btChooseResourceFileRnd.Name = "btChooseResourceFileRnd";
            this.btChooseResourceFileRnd.Size = new System.Drawing.Size(25, 20);
            this.btChooseResourceFileRnd.TabIndex = 7;
            this.btChooseResourceFileRnd.Text = "...";
            this.btChooseResourceFileRnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btChooseResourceFileRnd.UseVisualStyleBackColor = true;
            this.btChooseResourceFileRnd.Click += new System.EventHandler(this.btChooseResourceFileRnd_Click);
            // 
            // tbRndLength
            // 
            this.tbRndLength.Location = new System.Drawing.Point(101, 62);
            this.tbRndLength.Name = "tbRndLength";
            this.tbRndLength.Size = new System.Drawing.Size(40, 20);
            this.tbRndLength.TabIndex = 13;
            this.tbRndLength.Text = "64";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Длина блока";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 125);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BabKing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbResourceFileDir;
        private System.Windows.Forms.Button btChooseResourceFile;
        private System.Windows.Forms.TextBox tbResultFileDir;
        private System.Windows.Forms.Button btChooseResultFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btCoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btDecoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResourceFileDecode;
        private System.Windows.Forms.Button btChooseResultFileDecode;
        private System.Windows.Forms.TextBox tbResultFileDecode;
        private System.Windows.Forms.Button btChooseResourceFileDecode;
        private System.Windows.Forms.TextBox tbBlockLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbResourceFileRnd;
        private System.Windows.Forms.Button btChooseResultFileRnd;
        private System.Windows.Forms.TextBox tbResultFileRnd;
        private System.Windows.Forms.Button btChooseResourceFileRnd;
        private System.Windows.Forms.Button btGetRandom;
        private System.Windows.Forms.TextBox tbRndLength;
        private System.Windows.Forms.Label label8;
    }
}

