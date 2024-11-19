using Batiskaf.Properties;
using System.Drawing;

namespace Batiskaf
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ����������� �����
        /// </summary>
        /// <param name="glubina">�������</param>
        public Form1(decimal glubina)
        {
            InitializeComponent();
            Refresh();
            Height = Decimal.ToInt32(glubina+320+100+214);//������� ������ ����, ����, ���, �������� ��������� ���������
        }

        /// <summary>
        /// ���� ���� ��������� �����
        /// </summary>
        private List<Submarine> submarines = new List<Submarine>();

        /// <summary>
        /// ������ "��������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Submarine submarine = new Submarine(pult1, Width, Height - 100);
            Controls.Add(submarine);
            submarines.Add(submarine);
        }


        /// <summary>
        /// ��������� ���� � ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Azure, new Rectangle(0, 0, Width, 320));
            e.Graphics.FillRectangle(Brushes.Moccasin, new Rectangle(0, Height-100, Width, 100));
        }
    }
}
