namespace Batiskaf
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(343, 106);
            label1.TabIndex = 0;
            label1.Text = "Глубина";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(408, 63);
            numericUpDown1.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(124, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(422, 119);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 201);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}