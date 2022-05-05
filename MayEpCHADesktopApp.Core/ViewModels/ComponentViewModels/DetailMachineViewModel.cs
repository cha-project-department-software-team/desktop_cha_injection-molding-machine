using MayEpCHADesktopApp.Core.Components;
using MayEpCHADesktopApp.Core.Services.Interfaces;
using MayEpCHADesktopApp.Core.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels
{
    public class DetailMachineViewModel : ViewModels.BaseViewModels.BaseViewModel
    {
        private IApiServices _apiServices;
       //public static DetailMachineViewModel Instance => new DetailMachineViewModel();
        private string content { get; set; }
        public string Content { get => content; set { content = value; OnPropertyChanged(); } }
        private string tag { get; set; }
        public string Tag { get => tag; set { tag = value; OnPropertyChanged(); } }

        private bool animation1;
        public bool Animation1 { get => animation1; set { animation1 = value; OnPropertyChanged(); } }

        private bool animation2;
        public bool Animation2 { get => animation2; set { animation2 = value; OnPropertyChanged(); } }
        
        public ICommand PauseCommand { get; set; }
        public DetailMachineViewModel(IApiServices apiServices) {

            Content = "Tạm dừng";
            Animation1 = true;
            Animation2 = false;
            //_apiServices = apiServices;
            PauseCommand = new RelayObjectCommand<object>((p) => { return p == null ? false : true; }, async (p) => Pause(p));
        }

        private void Pause(object p)
        {
            
            CustomMessageBox.Show((p as UserControl).Tag.ToString(), "kkk", MessageBoxButton.OKCancel);
            try
            {
                if (Content == "Tạm dừng")
                {
                   MessageBoxResult result = CustomMessageBox.Show("Bạn có chắc dừng lại thay khuôn không ??", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                   CustomMessageBox.Show("Bạn chắc chắn muốn xóa hàng này phải không?", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning); ;
                    if (result == MessageBoxResult.OK)
                    {
                        Content = "Tiếp tục";
                        Animation1 = false;
                        Animation2 = true;
                    }

                }
                else if (Content == "Tiếp tục")
                {
                    MessageBoxResult result = CustomMessageBox.Show("Bạn muốn máy hoạt động với thông số đã nhập??", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    if (result == MessageBoxResult.OK)
                    {
                        Content = "Tạm dừng";
                        Animation1 = true;
                        Animation2 = false;
                    }
                }
            }
            catch
            {

            }

            //DialogResult result = cs.ShowDialog();

             
          
            
        }
    }
}
