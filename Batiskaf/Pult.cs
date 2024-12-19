using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
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
            Right();
        }

        private void Right()
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
            Up();
        }

        private void Up()
        {
            if (Active)
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
            Down();
        }

        private void Down()
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
            Left();
        }

        private void Left()
        {
            if (Active)
            {
                CurrentSubmarine.SubLeft -= CurrentSubmarine.Acceleration;
            }
        }

        UdpClient udpServer;
        IPEndPoint remoteEndPoint;
        private void Pult_Load(object sender, EventArgs e)
        {
            udpServer = new UdpClient();
            udpServer.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            // Определяем конечную точку для прослушивания (любой IP-адрес и порт 11000)
            udpServer.Client.Bind(new IPEndPoint(IPAddress.Any, 1105));
            remoteEndPoint = new IPEndPoint(IPAddress.Any, 1105);

            Thread thread = new Thread(UDPServ);
            thread.Start();

            Task.Run(() => {
                while (true)
                { if (Running == false) { udpServer.Close(); } } });
        }
        public bool Running { get; set; } = true;
        private void UDPServ() 
        {
            try
            {
                while (Running)
                {
                    // Получаем данные от клиента
                    byte[] receivedBytes = udpServer.Receive(ref remoteEndPoint);
                    string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

                    // Выводим полученное сообщение в консоль
                    if (receivedMessage == "1")
                    {
                        Up();
                    }
                    if (receivedMessage == "2")
                    {
                        Right();
                    }
                    if (receivedMessage == "3")
                    {
                        Down();
                    }
                    if (receivedMessage == "4")
                    {
                        Left();
                    }
                    if (receivedMessage == "5") { 
                        if (Form1.submarines.Count > 1)
                        {
                            Random random = new Random();
                            int numberSub = random.Next(0, Form1.submarines.Count);
                            Invoke(() => Form1.submarines[numberSub].ViborBatiskaf());
                        }
                    }
                    //if (receivedMessage == "6")
                    //{
                    //    Invoke(() =>
                    //    {
                    //        Submarine submarine = new Submarine(this, Width, Height - 100);
                    //        Controls.Add(submarine);
                    //        Form1.submarines.Add(submarine);
                    //    });
                    //}
                }
            }
            catch(SocketException) { }
        }
    }
}
