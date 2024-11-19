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
        /// Флаг для связи
        /// </summary>
        public bool OzidanieSvazi { get; set; } = false;

        /// <summary>
        /// Активность пульта
        /// </summary>
        public bool Active { get; set; } = false;

        /// <summary>
        /// Флаг для активации DataBinding (ложь, когда лодка не привязана)
        /// </summary>
        bool bind;

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
        /// Нажатие на кнопку "Связать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            OzidanieSvazi = true;
            if (bind)
            {
                textBox2.DataBindings.Clear();
                textBox1.DataBindings.Clear();
                bind = false;
            }
        }

        /// <summary>
        /// Метод для связи со свойствами текущей подводной лодки (срабатывает после нажатия на кнопку связать и клика по подводной лодки)
        /// </summary>
        public void Bind()
        {
            if (!bind)
            {
                textBox2.DataBindings.Add("Text", CurrentSubmarine, "Speed");
                textBox1.DataBindings.Add("Text", CurrentSubmarine, "Glubina");
                bind = true;
            }
        }

        /// <summary>
        /// Кнопка движения вправо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (Active && !OzidanieSvazi)
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
            if (Active && !OzidanieSvazi)
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
            if (Active && !OzidanieSvazi)
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
            if (Active && !OzidanieSvazi)
            {
                CurrentSubmarine.SubLeft -= CurrentSubmarine.Acceleration;
            }
        }
    }
}
