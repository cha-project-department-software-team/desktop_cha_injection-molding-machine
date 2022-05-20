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
            Title = "Cycle Standard",

            PointGeometry = DefaultGeometries.Circle,
            PointForeground = Brushes.SkyBlue,
            PointGeometrySize = 5

        };
        LineSeries LineData =
        new LineSeries()
        {
            Title = "Cycle Injection",

            PointGeometry = DefaultGeometries.Circle,
            PointForeground = Brushes.SkyBlue,
            PointGeometrySize = 5

        };
        public ChartObservate()
        {
            InitializeComponent();
            Title = "Nhân viên Lê Thanh Đạt ngày 18 tháng 6 năm 2022";
            SeriesCollection = new SeriesCollection();
            Data = new ChartValues<double>();
            Speed = new ChartValues<double>();
          Lables = new string[10] ;
            
        //    yformatter = value => value.ToString();
            chart();
        }
        public void chart()
        {
            for (int i = 0; i < 19; i++)
            {
                Speed.Add(30);
            }
            Data.Add(31);
            Data.Add(29.5); 
            Data.Add(30);
            Data.Add(30);
            Data.Add(29.9);
            Data.Add(29.9);
            Data.Add(29.9);
            Data.Add(30);
            Data.Add(30);
            Data.Add(29.8);
            Data.Add(29.9);
            Data.Add(29.7);
            Data.Add(30);
            Data.Add(30);
            Data.Add(30);
            Data.Add(30.2);
            Data.Add(29.9);
            Data.Add(30);
            Data.Add(30);



            LineSpeed.Values = Data;
            LineData.Values = Speed;
            SeriesCollection.Add(LineData);
            SeriesCollection.Add(LineSpeed);
            Lables[0] = "5";
            Lables[1] = "5";
            Lables[2] = "5";
            Lables[3] = "5";
            Lables[4] = "5";
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
