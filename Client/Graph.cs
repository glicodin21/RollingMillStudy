using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Client
{
    public partial class Graph : Form
    {
        Tdata adata;
        RollingPointPairList _data; // Хранилище данных
        int _capacity = 100; // Количество отображаемых точек
        double _step = 0.001; // Параметр шага
        double _currentx = 0; // Текущее значение на графике

        public Graph()
        {
            // Создаем массив данных с ограниченной емкостью.
            // При превышении заданной ёмкости первые элементы в массиве будут удаляться
            _data = new RollingPointPairList(_capacity);
            InitializeComponent();
            PrepareGraph();
            Value(adata.aString); // Получение данных о текущем значении вывода данных
        }
        
        public void Timer_Tick(object sender, EventArgs e)
        {
            //Получаем значение
            Double Dot = 0;
            Dot = Convert.ToDouble(adata.bString);
            // Добавляем новый отсчет к данным
            _data.Add(_currentx, Dot);
            _currentx += _step;
            // Рассчитаем интервал по оси X, который нужно отобразить на графике
            double xmin = _currentx - _capacity * _step;
            double xmax = _currentx;
            GraphPane pane = ZG1.GraphPane;
            pane.XAxis.Scale.Min = xmin;
            pane.XAxis.Scale.Max = xmax;
            // Обновляем оси
            ZG1.AxisChange();
            // Обновим сам график
            ZG1.Invalidate();
        }

        // Функция получения данных 
        public void Value(String a)
        {
                adata.bString = a;
        }

        // Подготовка данных
        private void PrepareGraph()
        {
            // Получим панель для рисования
            GraphPane pane = ZG1.GraphPane;
            // Убираем горизонтальную линию по x = 0
            pane.YAxis.MajorGrid.IsZeroLine = false;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            // Выводим текст заголовка
            pane.Title.Text = "График регулирования скорости";
            // Выводим названия осей
            pane.XAxis.Title.Text = "Время, с";
            pane.YAxis.Title.Text = "Скорость, м/c";
            // Добавим кривую пока еще без каких-либо точек
            LineItem myCurve = pane.AddCurve("График", _data, Color.Blue, SymbolType.None);
            // Вызываем метод AxisChange(), чтобы обновить данные об осях
            ZG1.AxisChange();
            // Обновляем график
            ZG1.Invalidate();
        }
    }
}
