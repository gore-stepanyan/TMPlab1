namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.writer = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reader = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Write_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.writer.SuspendLayout();
            this.reader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.writer);
            this.tabControl1.Controls.Add(this.reader);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(299, 116);
            this.tabControl1.TabIndex = 1;
            // 
            // writer
            // 
            this.writer.Controls.Add(this.button1);
            this.writer.Controls.Add(this.label1);
            this.writer.Controls.Add(this.textBox1);
            this.writer.Location = new System.Drawing.Point(4, 22);
            this.writer.Name = "writer";
            this.writer.Padding = new System.Windows.Forms.Padding(3);
            this.writer.Size = new System.Drawing.Size(291, 90);
            this.writer.TabIndex = 0;
            this.writer.Text = "Создание";
            this.writer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество чисел для генерации массива \r\nслучайных чисел:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reader
            // 
            this.reader.Controls.Add(this.label3);
            this.reader.Controls.Add(this.Write_btn);
            this.reader.Controls.Add(this.result);
            this.reader.Controls.Add(this.Read_btn);
            this.reader.Controls.Add(this.textBox2);
            this.reader.Controls.Add(this.label2);
            this.reader.Location = new System.Drawing.Point(4, 22);
            this.reader.Name = "reader";
            this.reader.Padding = new System.Windows.Forms.Padding(3);
            this.reader.Size = new System.Drawing.Size(291, 90);
            this.reader.TabIndex = 1;
            this.reader.Text = "Поиск";
            this.reader.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(7, 318);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(97, 39);
            this.result.TabIndex = 4;
            this.result.Text = "1337";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Индекс элемента";
            // 
            // Read_btn
            // 
            this.Read_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Read_btn.Location = new System.Drawing.Point(132, 60);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(75, 23);
            this.Read_btn.TabIndex = 2;
            this.Read_btn.Text = "Найти";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // Write_btn
            // 
            this.Write_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Write_btn.Location = new System.Drawing.Point(213, 61);
            this.Write_btn.Name = "Write_btn";
            this.Write_btn.Size = new System.Drawing.Size(75, 23);
            this.Write_btn.TabIndex = 3;
            this.Write_btn.Text = "Изменить\r\n";
            this.Write_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Искомый элемент: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 118);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(321, 156);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.writer.ResumeLayout(false);
            this.writer.PerformLayout();
            this.reader.ResumeLayout(false);
            this.reader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage writer;
        private System.Windows.Forms.TabPage reader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Write_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

