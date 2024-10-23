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
    public partial class Submarine : UserControl
    {
        private Image backgroundImage;
        public Submarine()
        {
            InitializeComponent();
            DoubleBuffered = true;
            LoadBackgroundImage();
        }


        private void LoadBackgroundImage()
        {
            try
            {
                backgroundImage = Image.FromFile("батискаф.png"); // Убедитесь, что путь к изображению правильный
                Graphics gr = CreateGraphics();
                gr.DrawImage(backgroundImage, new Rectangle(0, 0, this.Width, this.Height));
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }
        public Image BackgroundImage
        {
            get { return backgroundImage; }
            set { backgroundImage = value; //Invalidate();
                                           }
        }

    }
}
