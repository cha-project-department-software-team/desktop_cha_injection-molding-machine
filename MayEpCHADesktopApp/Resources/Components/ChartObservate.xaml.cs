using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MayEpCHADesktopApp.Resources.Components
{
    /// <summary>
    /// Interaction logic for ChartObservate.xaml
    /// </summary>
    public partial class ChartObservate : UserControl, INotifyPropertyChanged
    {
        public Func<Double, string> yformatter { set; get; }
        private SeriesCollection seriesCollection;
        public SeriesCollection SeriesCollection { get => seriesCollection; set { seriesCollection = value; OnPropertyChanged(); } }
        private string[] lables;
        public string[] Lables { get => lables; set { lables = value; OnPropertyChanged(); } }
        public string Title { get => title; set { title = value;OnPropertyChanged(); }  }

        private string title;

        private ChartValues<Double> data ;
        public ChartValues<Double> Data { get => data; set { data = value; OnPropertyChanged(); } }
        private ChartValues<Double> speed;
        public ChartValues<Double> Speed { get => speed; set { speed = value; OnPropertyChanged(); } }
        
        LineSeries LineSpeed =
        new LineSeries()
        {
            Title = "SpeedRef",

            PointGeometry = DefaultGeometries.Circle,
            PointForeground = Brushes.SkyBlue,
            PointGeometrySize = 5

        };
        LineSeries LineData =
        new LineSeries()
        {
            Title = "Speed Real time",

            PointGeometry = DefaultGeometries.Circle,
            PointForeground = Brushes.SkyBlue,
            PointGeometrySize = 5

        };
        public ChartObservate()
        {
            InitializeComponent();
            Title = "Công nhân A ngày 14 tháng 4 năm 2020";
            SeriesCollection = new SeriesCollection();
            Data = new ChartValues<double>();
            Speed = new ChartValues<double>();
            Lables = new[] { "0.1", "0.2", "0.3", "0.4", "0.5" };
            yformatter = value => value.ToString();
            chart();
        }
        public void chart()
        {
            for (int i = 0; i < 4; i++)
            {
                Speed.Add(20);
            }
            Data.Add(21);
            Data.Add(19); 
            Data.Add(22);
            Data.Add(21);
            Data.Add(22);
            LineSpeed.Values = Data;
            LineData.Values = Speed;
            SeriesCollection.Add(LineData);
            SeriesCollection.Add(LineSpeed);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
