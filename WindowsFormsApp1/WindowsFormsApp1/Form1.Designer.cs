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
            this.Open = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Write_btn = new System.Windows.Forms.Button();
            this.Read_btn = new System.Windows.Forms.Button();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PageNumLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(146, 81);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(96, 23);
            this.Open.TabIndex = 4;
            this.Open.Text = "Открыть ";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(6, 81);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(122, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Сгенерировать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество чисел для генерации \r\nмассива случайных чисел:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.Location = new System.Drawing.Point(87, 147);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Искомый элемент: ";
            // 
            // Write_btn
            // 
            this.Write_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Write_btn.Location = new System.Drawing.Point(167, 147);
            this.Write_btn.Name = "Write_btn";
            this.Write_btn.Size = new System.Drawing.Size(93, 23);
            this.Write_btn.TabIndex = 3;
            this.Write_btn.Text = "Изменить\r\n";
            this.Write_btn.UseVisualStyleBackColor = true;
            this.Write_btn.Click += new System.EventHandler(this.Write_btn_Click);
            // 
            // Read_btn
            // 
            this.Read_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Read_btn.Location = new System.Drawing.Point(6, 146);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(75, 23);
            this.Read_btn.TabIndex = 2;
            this.Read_btn.Text = "Найти";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexTextBox.Location = new System.Drawing.Point(6, 50);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(194, 22);
            this.IndexTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Индекс элемента, отсчитанный от 0:";
            // 
            // PageNumLabel
            // 
            this.PageNumLabel.AutoSize = true;
            this.PageNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNumLabel.Location = new System.Drawing.Point(9, 107);
            this.PageNumLabel.Name = "PageNumLabel";
            this.PageNumLabel.Size = new System.Drawing.Size(210, 16);
            this.PageNumLabel.TabIndex = 7;
            this.PageNumLabel.Text = "Номер загруженной страницы:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.Open);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание/Открытие файла";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IndexTextBox);
            this.groupBox2.Controls.Add(this.PageNumLabel);
            this.groupBox2.Controls.Add(this.Read_btn);
            this.groupBox2.Controls.Add(this.Remove);
            this.groupBox2.Controls.Add(this.Write_btn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 190);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с массивом";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TaMP1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Write_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IndexTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label PageNumLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

