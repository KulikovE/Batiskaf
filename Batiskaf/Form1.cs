using Batiskaf.Properties;
using System.Drawing;

namespace Batiskaf
{
    public partial class Form1 : Form
    {
        public Form1(decimal glubina)
        {
            InitializeComponent();
            Refresh();
            Height = Decimal.ToInt32(glubina+320+100+214);//глубина самого моря, небо, дно, смешение координат батискафа
        }

        private List<Submarine> submarines = new List<Submarine>();
        private void button1_Click(object sender, EventArgs e)
        {
            Submarine submarine = new Submarine(pult1, Width, Height - 100);
            submarine.BackgroundImage = Image.FromFile(@"батискаф.png");
            submarine.Location = new Point(12, 300);
            submarine.MaximumSize = new Size(315, 234);
            submarine.MinimumSize = new Size(315, 234);
            submarine.Name = "submarine1";
            submarine.Size = new Size(315, 234);
            submarine.BringToFront();
            Controls.Add(submarine);
            submarines.Add(submarine);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Azure, new Rectangle(0, 0, Width, 320));
            e.Graphics.FillRectangle(Brushes.Moccasin, new Rectangle(0, Height-100, Width, 100));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
