using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batiskaf
{

    /// <summary>
    /// Подводная лодка
    /// </summary>
    public partial class Submarine : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Пульт привязанный к лодке
        /// </summary>
        private Pult pult;

        /// <summary>
        /// Изменение координат по оси X
        /// </summary>
        public int SubUp { get; set; } = 0;
        /// <summary>
        /// Изменение координат по оси Y
        /// </summary>
        public int SubLeft { get; set; } = 0;
        
        /// <summary>
        /// Ускорение
        /// </summary>
        public int Acceleration {  get; set; } = 5;
        /// <summary>
        /// Скорость
        /// </summary>
        double speed = 0;
        /// <summary>
        /// Глубина
        /// </summary>
        double glubina = 0;

        /// <summary>
        /// Свойство для скорости
        /// </summary>
        public double Speed { get { return speed; } set {speed = value; OnPropertyChanged(); } }
        /// <summary>
        /// Свойство для глубины
        /// </summary>
        public double Glubina { get { return glubina; } set { glubina = value; OnPropertyChanged(); } }

        /// <summary>
        /// Замедление
        /// </summary>
        const int slowDown = 4;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Ширина и высота формы
        /// </summary>
        int width, height;

        /// <summary>
        /// Конструктор лодки
        /// </summary>
        /// <param name="pult">Пульт, используемый на форме</param>
        /// <param name="Width">Ширина формы</param>
        /// <param name="Height">Высота формы</param>
        public Submarine(Pult pult, int Width, int Height)
        {
            InitializeComponent();
            this.pult = pult;
            DoubleBuffered = true;
            width = Width;
            height = Height;
            BackgroundImage = Image.FromFile("батискаф.png");
            Location = new Point(12, 300);
        }


        /// <summary>
        /// Срабатывание таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pult.Active)
            {
                Top += SubUp;
                Left += SubLeft;
                if (SubUp > 0)
                {
                    SubUp = Math.Max(SubUp - slowDown, 0);
                }
                else
                {
                    SubUp = Math.Min(SubUp + slowDown, 0);
                }
                if(SubLeft > 0)
                {
                    SubLeft = Math.Max(SubLeft - slowDown, 0);
                }
                else
                {
                    SubLeft = Math.Min(SubLeft + slowDown, 0);
                }
                
                if (Top < 299) { SubUp = 0; 
                    Top = 300; }
                if (Left < 1) { SubLeft = 0;
                Left = 0;}
                if (Left > width-this.Width-10)
                {
                    SubLeft = 0;
                    Left = width-this.Width-10;
                }
                if (Top > height-this.Height)
                {
                    SubUp = 0;
                    Top = height-this.Height;
                }
                
                
                Speed = Math.Sqrt(SubUp * SubUp + SubLeft * SubLeft);
                glubina = Top - 300;
            }
        }


        /// <summary>
        /// Нажатие на подводную лодку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submarine_Click(object sender, EventArgs e)
        {
            if (pult.OzidanieSvazi)
            {
                pult.OzidanieSvazi = false;
                if (pult.CurrentSubmarine != null)
                {
                    pult.CurrentSubmarine.BackgroundImage = Image.FromFile("батискаф.png");
                }
                pult.CurrentSubmarine = this;
                BackgroundImage = Image.FromFile("батискаф1.png");
                pult.Active = true;
                pult.Bind();
            }
        }
    }
}
