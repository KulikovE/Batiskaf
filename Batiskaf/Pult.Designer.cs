﻿namespace Batiskaf
{
    partial class Pult
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(235, 98);
            button2.Name = "button2";
            button2.Size = new Size(99, 92);
            button2.TabIndex = 1;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(130, 3);
            button1.Name = "button1";
            button1.Size = new Size(99, 92);
            button1.TabIndex = 2;
            button1.Text = "^";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(130, 196);
            button3.Name = "button3";
            button3.Size = new Size(99, 92);
            button3.TabIndex = 3;
            button3.Text = "v";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(28, 98);
            button4.Name = "button4";
            button4.Size = new Size(99, 92);
            button4.TabIndex = 4;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(91, 45);
            button5.TabIndex = 5;
            button5.Text = "связать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 206);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Скорость:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 206);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Глубина:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 238);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(51, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 238);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(50, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Pult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Pult";
            Size = new Size(357, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}