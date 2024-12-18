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
    /// Пользовательский элемент управления для пульта
    /// </summary>
    public partial class Pult : UserControl
    {

        /// <summary>
        /// Активность пульта
        /// </summary>
        public bool Active { get; set; } = false;


        /// <summary>
        /// Конструктор для пульта
        /// </summary>
        public Pult()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Поле для лодки, привязанной к пульту
        /// </summary>
        private Submarine currentSubmarine;


        /// <summary>
        /// Свойство для доступа к полю для лодки, привязанной к пульту
        /// </summary>
        public Submarine CurrentSubmarine { get { return currentSubmarine; } set { currentSubmarine = value; } }



        /// <summary>
        /// Метод для связи со свойствами текущей подводной лодки (срабатывает после нажатия на кнопку связать и клика по подводной лодке)
        /// </summary>
        public void Bind()
        {
           
                textBox2.DataBindings.Add("Text", CurrentSubmarine, "Speed");
                textBox1.DataBindings.Add("Text", CurrentSubmarine, "Glubina");
           
        }

        public void ClearBind()
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
        }

        /// <summary>
        /// Кнопка движения вправо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                CurrentSubmarine.SubLeft += CurrentSubmarine.Acceleration;
            }
        }


        /// <summary>
        /// Кнопка движения влево
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Active )
            {
                CurrentSubmarine.SubUp -= CurrentSubmarine.Acceleration;
            }
        }


        /// <summary>
        /// Кнопка движения вниз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                CurrentSubmarine.SubUp += CurrentSubmarine.Acceleration;
            }
        }


        /// <summary>
        /// Кнопка движения вверх
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (Active )
            {
                CurrentSubmarine.SubLeft -= CurrentSubmarine.Acceleration;
            }
        }
    }
}
