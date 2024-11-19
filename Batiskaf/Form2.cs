using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batiskaf
{
    /// <summary>
    /// Класс формы для глубины
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Кнопка "Пуск"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(numericUpDown1.Value);
            this.Hide();
            form1.ShowDialog();
            this.Close();
            

        }
    }
}
