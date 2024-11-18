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
    public partial class Pult : UserControl
    {
        public bool OzidanieSvazi { get; set; } = false;
        public bool Active { get; set; } = false;
        bool bind;
        public Pult()
        {
            InitializeComponent();
           

        }
        private Submarine currentSubmarine;

        public Submarine CurrentSubmarine { get { return currentSubmarine; } set { currentSubmarine = value; } }

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

        public void Bind()
        {
            if (!bind)
            {
                textBox2.DataBindings.Add("Text", CurrentSubmarine, "Speed");
                textBox1.DataBindings.Add("Text", CurrentSubmarine, "Glubina");
                bind = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                CurrentSubmarine.SubLeft += CurrentSubmarine.Acceleration;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                CurrentSubmarine.SubUp -= CurrentSubmarine.Acceleration;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                CurrentSubmarine.SubUp += CurrentSubmarine.Acceleration;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Active)
            {
                CurrentSubmarine.SubLeft -= CurrentSubmarine.Acceleration;
            }
        }
    }
}
