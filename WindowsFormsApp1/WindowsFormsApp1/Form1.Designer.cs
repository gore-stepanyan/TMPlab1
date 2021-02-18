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
            this.random_flag = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.writer = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reader = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Write_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.result = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.writer.SuspendLayout();
            this.reader.SuspendLayout();
            this.SuspendLayout();
            // 
            // random_flag
            // 
            this.random_flag.AutoSize = true;
            this.random_flag.Location = new System.Drawing.Point(6, 6);
            this.random_flag.Name = "random_flag";
            this.random_flag.Size = new System.Drawing.Size(85, 17);
            this.random_flag.TabIndex = 0;
            this.random_flag.Text = "Рандомные";
            this.random_flag.UseVisualStyleBackColor = true;
            this.random_flag.CheckedChanged += new System.EventHandler(this.Random_flag_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.writer);
            this.tabControl1.Controls.Add(this.reader);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 389);
            this.tabControl1.TabIndex = 1;
            // 
            // writer
            // 
            this.writer.Controls.Add(this.label1);
            this.writer.Controls.Add(this.textBox1);
            this.writer.Controls.Add(this.random_flag);
            this.writer.Location = new System.Drawing.Point(4, 22);
            this.writer.Name = "writer";
            this.writer.Padding = new System.Windows.Forms.Padding(3);
            this.writer.Size = new System.Drawing.Size(440, 363);
            this.writer.TabIndex = 0;
            this.writer.Text = "Запись";
            this.writer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // reader
            // 
            this.reader.Controls.Add(this.result);
            this.reader.Controls.Add(this.listView1);
            this.reader.Controls.Add(this.textBox2);
            this.reader.Controls.Add(this.label2);
            this.reader.Location = new System.Drawing.Point(4, 22);
            this.reader.Name = "reader";
            this.reader.Padding = new System.Windows.Forms.Padding(3);
            this.reader.Size = new System.Drawing.Size(440, 363);
            this.reader.TabIndex = 1;
            this.reader.Text = "Чтение";
            this.reader.UseVisualStyleBackColor = true;
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
            this.Read_btn.Location = new System.Drawing.Point(304, 407);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(75, 23);
            this.Read_btn.TabIndex = 2;
            this.Read_btn.Text = "Открыть";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // Write_btn
            // 
            this.Write_btn.Location = new System.Drawing.Point(385, 407);
            this.Write_btn.Name = "Write_btn";
            this.Write_btn.Size = new System.Drawing.Size(75, 23);
            this.Write_btn.TabIndex = 3;
            this.Write_btn.Text = "Сохранить";
            this.Write_btn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(288, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(146, 350);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 442);
            this.Controls.Add(this.Write_btn);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.tabControl1);
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

        private System.Windows.Forms.CheckBox random_flag;
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
        private System.Windows.Forms.ListView listView1;
    }
}

