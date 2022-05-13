using MayEpCHADesktopApp.Core.Services.Communication.ModelMQTT;
using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MachineInformationDetail.xaml
    /// </summary>
    public partial class MachineInformationDetail : UserControl, INotifyPropertyChanged
    {

        public MachineInformationDetail()
        {
            
            InitializeComponent();

        }
        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register("Status", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("Không hoạt động"));

        public SolidColorBrush StatusBackground
        {
            get { return (SolidColorBrush)GetValue(StatusBackgroundProperty); }
            set { SetValue(StatusBackgroundProperty, value); OnPropertyChanged(); }
        }
        public static readonly DependencyProperty StatusBackgroundProperty =
         DependencyProperty.Register("StatusBackground", typeof(SolidColorBrush), typeof(MachineInformationDetail), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));

        public string Mode
        {
            get { return (string)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("Bán tự động"));
        public string ContentBt
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("ContentBt", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("Tạm dừng"));


        public bool Animation1
        {
            get { return (bool)GetValue(Animation1Property); }
            set { SetValue(Animation1Property, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty Animation1Property =
            DependencyProperty.Register("Animation1", typeof(bool), typeof(MachineInformationDetail), new PropertyMetadata(true));
        public bool Animation2
        {
            get { return (bool)GetValue(Animation2Property); }
            set { SetValue(Animation2Property, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty Animation2Property =
            DependencyProperty.Register("Animation2", typeof(bool), typeof(MachineInformationDetail), new PropertyMetadata(false));


        public ObservableCollection<EventMachine> ListEvent
        {
            get { return (ObservableCollection<EventMachine>)GetValue(listEventProperty); }
            set { SetValue(listEventProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty listEventProperty =
            DependencyProperty.Register("ListEvent", typeof(ObservableCollection<EventMachine>), typeof(MachineInformationDetail));
        public string MachineName
        {
            get { return (string)GetValue(MachineNameProperty); }
            set { SetValue(MachineNameProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty MachineNameProperty =
            DependencyProperty.Register("MachineName", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("M24", OnChangeNameMachine));

        public string MoldCode
        {
            get { return (string)GetValue(MoldCodeProperty); }
            set { SetValue(MoldCodeProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty MoldCodeProperty =
            DependencyProperty.Register("MoldCode", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("Mold"));


        public string ProductCode
        {
            get { return (string)GetValue(ProductCodeProperty); }
            set { SetValue(ProductCodeProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty ProductCodeProperty =
            DependencyProperty.Register("ProductCode", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("ProductId"));

        public string CycleStandard
        {
            get { return (string)GetValue(CycleStandardProperty); }
            set { SetValue(CycleStandardProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty CycleStandardProperty =
            DependencyProperty.Register("CycleStandard", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("50"));
        public string RealCycle
        {
            get { return (string)GetValue(RealCycleProperty); }
            set { SetValue(RealCycleProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty RealCycleProperty =
            DependencyProperty.Register("RealCycle", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("32.5"));

        public string CountProduct
        {
            get { return (string)GetValue(CountProductProperty); }
            set { SetValue(CountProductProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty CountProductProperty =
            DependencyProperty.Register("CountProduct", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("3kg"));


        private static void OnChangeNameMachine(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MachineInformationDetail mc = d as MachineInformationDetail;
              mc.Tag = e.NewValue.ToString();
             

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //màu trạng thái
        public SolidColorBrush BackgroundMachineDetail
        {
            get { return (SolidColorBrush)GetValue(BackgroundMachineDetailProperty); }
            set { SetValue(BackgroundMachineDetailProperty, value); OnPropertyChanged(); }
        }
        public static readonly DependencyProperty BackgroundMachineDetailProperty =
         DependencyProperty.Register("BackgroundMachineDetail", typeof(SolidColorBrush), typeof(MachineInformationDetail), new PropertyMetadata((SolidColorBrush)new BrushConverter().ConvertFrom("#96D6FF")));
        ///tạm dừng
        public static readonly RoutedEvent ClickEventPause =
    EventManager.RegisterRoutedEvent(nameof(ClickPause), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MachineInformationDetail));

        public event RoutedEventHandler ClickPause
        {
            add { AddHandler(ClickEventPause, value); }
            remove { RemoveHandler(ClickEventPause, value); }
        }
        /// <summary>
        /// /////
        /// </summary>
        public static readonly RoutedEvent ClickEventContinue =
            EventManager.RegisterRoutedEvent(nameof(ClickContinue), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MachineInformationDetail));

        public event RoutedEventHandler ClickContinue
        {
            add { AddHandler(ClickEventContinue, value); }
            remove { RemoveHandler(ClickEventContinue, value); }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
      
                        RaiseEvent(new RoutedEventArgs(ClickEventContinue));           
            

        }
    }
}
