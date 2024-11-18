namespace Batiskaf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            pult1 = new Pult();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pult1
            // 
            pult1.Active = false;
            pult1.BackColor = Color.Transparent;
            pult1.CurrentSubmarine = null;
            pult1.Location = new Point(100, 0);
            pult1.Name = "pult1";
            pult1.OzidanieSvazi = false;
            pult1.Size = new Size(336, 284);
            pult1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1298, 644);
            Controls.Add(button1);
            Controls.Add(pult1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion
        private Submarine submarine1;
        private Pult pult1;
        private Button button1;
    }
}
