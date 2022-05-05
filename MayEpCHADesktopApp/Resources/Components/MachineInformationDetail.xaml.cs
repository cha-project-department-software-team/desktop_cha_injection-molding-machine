using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;
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
    /// Interaction logic for MachineInformationDetail.xaml
    /// </summary>
    public partial class MachineInformationDetail : UserControl, INotifyPropertyChanged {
      

        public MachineInformationDetail()
        {
            
            InitializeComponent();
           
           // this.DataContext = CustomDataContext;

        }
        /// <summary>
        /// 
        public object CustomDataContext
        {
            get { return (object)GetValue(CustomDataContextProperty); }
            set { SetValue(CustomDataContextProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty CustomDataContextProperty =
            DependencyProperty.Register("CustomDataContext", typeof(object), typeof(MachineInformationDetail),new PropertyMetadata("",OnChangeModel));
        /// </summary>
                private static void OnChangeModel(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
         //   MachineInformationDetail mc = d as MachineInformationDetail;
          //  mc.DataContext =(object)e.NewValue;
            
             //e.NewValue.ToString()

        }
    public string MachineName
        {
            get { return (string)GetValue(MachineNameProperty); }
            set { SetValue(MachineNameProperty, value); OnPropertyChanged(); }
        }

        public static readonly DependencyProperty MachineNameProperty =
            DependencyProperty.Register("MachineName", typeof(string), typeof(MachineInformationDetail), new PropertyMetadata("M24", OnChangeNameMachine));


        /// <summary>
        /// /sử lí Tag
        /// 
        /// </summary>
        
        
        private static void OnChangeNameMachine(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MachineInformationDetail mc = d as MachineInformationDetail;
              mc.Tag = e.NewValue.ToString();
             //e.NewValue.ToString()

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
