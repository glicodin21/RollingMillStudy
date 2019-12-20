using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Server
{
    // Структура данных для глобальных переменных
    public struct Tdata
    {
        public bool exit;
        public double D, SD, S;
        public string EX1;
    }

    public partial class Server : Form
    {
        Tdata adata;
        object locker = new object(); // Создание объекта-заглушки потоков
        SimpleTcpServer server; // Подключение библиотеки обмена

        // Создания общих переменных для математических преобразований
        int N = 1;
        double[] X1 = new double[50000];
        double[] X2 = new double[50000];
        double[] Y = new double[50000];
        double[] Un = new double[50000];
        
        public Server()
        {
            InitializeComponent();
        }

        // Обрабатываем событие закрытие формы
        private void Server_FormClosing(Object sender, FormClosingEventArgs e)
        {
            server.Stop();
            adata.exit = true;
        }

        // Обработка события загрузки сервера
        private void Server_Load(object sender, EventArgs e)
        {
            double D = 0;
            double SD = 0;
            double S = 0;
            lock (locker)
            {
                adata.D = 0;
                adata.SD = 0;
                adata.S = 0;
            }
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //вход
            server.StringEncoder = Encoding.UTF8;
            Thread t = new Thread(delegate ()
            {
                server.DataReceived += Server_DataReceived;
            });
            t.Start();
            Thread m = new Thread(delegate ()
            {
                while (true)
                {
                    if (adata.exit != true)
                    {
                        X1[0] = 0; X2[0] = 0; Un[0] = 0; Y[0] = 0; // Создания переменных для математических преобразований
                        lock (locker)
                        {
                            D = adata.D;
                            SD = adata.SD;
                            S = adata.S;
                        }
                        Math(D, SD, S); // Вызов математической функции
                        N++;
                        if (N == 49997) // Условие сброса математического счетчика
                        {
                            N = 0;
                        }
                    }
                    else break;
                }
            });
            m.Start();
        }

        // Функция приема данных с клиента
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            double Depth, SourceDepth, Speed;
            DepthTxt.Invoke((MethodInvoker)delegate ()
            {
                String aString = Encoding.UTF8.GetString(e.Data); // Декодирование полученного сообщения
                if (aString != null)
                {
                    if (aString[0] == 'a') // Распределение типов данных на основе префиксного дополнения
                    {
                        DepthTxt.Text = aString.Trim('a'); // Подрезка префиксного дополнения
                        Depth = Convert.ToDouble(aString.Trim('a')); // Подрезка префиксного дополнения в локальной переменной
                        lock (locker)
                        {
                            adata.D = Depth; // Передача данных в глобальную переменную
                        }
                    }
                    if (aString[0] == 'b') // Распределение типов данных на основе префиксного дополнения
                    {
                        SourceDepthTxt.Text = aString.Trim('b'); // Подрезка префиксного дополнения
                        SourceDepth = Convert.ToDouble(aString.Trim('b')); // Подрезка префиксного дополнения в локальной переменной
                        lock (locker)
                        {
                            adata.SD = SourceDepth; // Передача данных в глобальную переменную
                        }
                    }
                    if (aString[0] == 'c') // Распределение типов данных на основе префиксного дополнения
                    {
                        SpeedTxt.Text = aString.Trim('c'); // Подрезка префиксного дополнения
                        Speed = Convert.ToDouble(aString.Trim('c')); // Подрезка префиксного дополнения в локальной переменной
                        lock (locker)
                        {
                            adata.S = Speed; // Передача данных в глобальную переменную
                        }
                    }
                }
            });

            Thread s = new Thread(delegate ()
            {
                while (true)
                {
                    if (adata.exit != true)
                    {
                        lock (locker)
                        {
                            try
                            {
                                server.BroadcastLine(adata.EX1); // Отправка результатов математических преобразований с сервера на клиент
                            }
                            catch (Exception)
                            {
                                return;
                            }
                            
                        }
                        Thread.Sleep(10);
                    }
                    else break;
                }
            });
            s.Start();
        }

        //Обработка события нажатия на кнопку включения сервера
        private void btnStart_Click(object sender, EventArgs e)
        {
            StatusTxt.Text = "Сервер активен.";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(HostTxt.Text);
            server.Start(ip, Convert.ToInt32(PortTxt.Text));
        }
        
        // Обработка события нажатия на кнопку выключения сервера
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                StatusTxt.Text = "Сервер остановлен.";
                Close();
                adata.exit = true;
            }
        }

        // Функция математических преобразований
        public void Math(double D, double SD, double S)
        {
            if (adata.exit != true)
            {
                double t = 0.0001; // Шаг
                double h = 0; // Разность между исходной и фактической толщиной
                lock (locker)
                {
                    h = D - SD;
                }
                X1[N + 1] = (36.11 * X2[N] - 14560165 * h / 1000) * t + X1[N];
                Y[N] = X1[N] * 0.605;
                Un[N + 1] = ((S - X1[N]) * 0.01 - Un[N]) * 10520.5 * t + Un[N];
                X2[N + 2] = (-91.55 * X1[N + 1] - 58.14 * X2[N + 1] + 140.845 * (1.3789 * (S - X1[N + 1]) + 45.41 * (S - X1[N + 1])) + Un[N]) * t + X2[N + 1];
                lock (locker)
                {
                    adata.EX1 = Convert.ToString(Y[N]); // Вывод результатов математических преобразований в глобальную переменную
                }
            }
        }
    }
}