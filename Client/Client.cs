using SimpleTCP;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Client
{
    // Структура данных для глобальных переменных
    public struct Tdata 
    {
        public string aString;
        public string bString;
        public bool Exit;
    }

    public partial class Client : Form
    {
        Tdata adata;
        object locker = new object(); // Создание объекта-заглушки потоков
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); // Объвление таймера
        SimpleTcpClient client; // Подключение библиотеки обмена

        public Client()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(RefreshLabel); // Вызов функции обновления данных на мнемосхеме с помощью таймера
            timer.Start(); 
            if (adata.aString == null) adata.aString = "0";
        }

        // Обрабатываем событие закрытие формы
        private void Client_FormClosing(Object sender, FormClosingEventArgs e)
        {
            adata.Exit = true;
        }

        // Обрабатываем событие загрузки формы
        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient
            {
                StringEncoder = Encoding.UTF8
            };
            lock (locker)
            {
                if (adata.Exit != true)
                {
                    client.DataReceived += Client_DataReceived;
                }
                else Close();
            }
        }
        
        // Получение данных c сервера
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            try
            {
                Invoke((MethodInvoker)delegate ()
                {
                    if (adata.Exit != true)
                    {
                        lock (locker)
                        {
                            adata.aString = e.MessageString.Remove(13);
                        }
                    }
                    else Thread.CurrentThread.Abort();
                });
            }
            catch (System.ObjectDisposedException)
            {
                return;
            }
        }

        // Вывод данных на мнемосхему
        public void RefreshLabel(object sender, EventArgs e)
        {
            String MSG = "0";
            lock (locker)
            {
                MSG = adata.aString;
            }
            label1.Text = MSG; 
        }

        // Обработка события нажатия на кнопку подключения
        private void ConnectClickBtn(object sender, EventArgs e)
        {
            try
            {
                client.Connect(HostTxt.Text, Convert.ToInt32(PortTxt.Text));
                StatusTxt.Text += "\nПодключение к серверу установлено.";
            }
            catch
            {
                StatusTxt.Text += "\nПодключение к серверу не удалось.";
            }
        }
        
        // Обработка события нажатия на кнопку отправки данных по толщине
        private void btnTolsh_Click(object sender, EventArgs e)
        {
            double aDouble, bDouble;
            try
            {
                Thread t1 = new Thread(delegate ()
                {
                    aDouble = Convert.ToDouble(DepthBoxTxt.Text); // Запись данных о толщине
                    String aString = "a" + Convert.ToString(aDouble); // Добавление префикса сообщению о толщине
                    bDouble = Convert.ToDouble(SourceDepthBoxTxt.Text); // Запись данных о исходной толщине
                    String bString = "b" + Convert.ToString(bDouble); // Добавление префикса сообщению об исходной толщине
                    lock (locker)
                    {
                        byte[] data = System.Text.Encoding.UTF8.GetBytes(aString); // Создания массива байт на основе сообщения
                        client.Write(data); // Отправка данных на сервер
                        Thread.Sleep(100);
                    }
                    lock (locker)
                    {
                        byte[] data2 = System.Text.Encoding.UTF8.GetBytes(bString); // Создания массива байт на основе сообщения
                        client.Write(data2); // Отправка данных на сервер
                        Thread.Sleep(100);
                    }
                });
                t1.Start();
                StatusTxt.Text += "\r\nДанные толщины отправлены";
                StatusTxt.Text += "\r\nДанные исходной толщины отправлены";
            }
            catch (FormatException)
            {
                StatusTxt.Text += "\r\nОшибка! Неверный формат ввода толщины.";
            }
            catch (Exception)
            {
                StatusTxt.Text += "\r\nНе удалось отправить данные на сервер";
            }
        }

     // Обработка события нажатия на кнопку отправки скорости
        private void SpeedBtn_Click(object sender, EventArgs e)
        {
            double cDouble;
            try
            {
                cDouble = Convert.ToDouble(SpeedBoxTxt.Text); // Запись данных о скорости
                String cString = "c" + Convert.ToString(cDouble); // Добавление префикса сообщению о скорости
                byte[] data = System.Text.Encoding.UTF8.GetBytes(cString); // Создания массива байт на основе сообщения
                client.Write(data); // Отправка данных на сервер
                StatusTxt.Text += "\r\nДанные исходной толщины отправлены";
            }
            catch (FormatException)
            {
                StatusTxt.Text += "\r\nОшибка! Неверный формат ввода исходной толщины";
            }
            catch (Exception)
            {
                StatusTxt.Text += "\r\nНе удалось отправить данные на сервер";
            }
        }

       // Обработка события изменения статусного окна
        private void StatusTxt_TextChanged(object sender, EventArgs e)
        {
            StatusTxt.ScrollBars = ScrollBars.Vertical;
        }

        // Обработка события нажатия на кнопку демонстрации графика
        private void ShowButton(object sender, EventArgs e)
        {
            Graph GraphForm = new Graph(); // Создание нового графика
            GraphForm.Show(); // Запуск демонстрации графика
            Thread t2 = new Thread(delegate ()
            {
                while (true)
                {
                    if (adata.Exit != true)
                    {
                        String MSG = "0";
                        lock (locker)
                        {
                            MSG = adata.aString;
                        }
                        GraphForm.Value(MSG); // Передача данных на график
                    }
                    else Thread.CurrentThread.Abort();
                }
            });
            t2.Start();
        }
    }
}
