using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace User_Basic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterHomeMaster : ContentPage
    {
        public ListView ListView;

        public MasterHomeMaster()
        {
            InitializeComponent();

            BindingContext = new MasterHomeMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterHomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterHomeMenuItem> MenuItems { get; set; }
            
            public MasterHomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterHomeMenuItem>(new[]
                {
                    new MasterHomeMenuItem { Id = 0, Title = "Trang chủ" },
                    new MasterHomeMenuItem { Id = 1, Title = "Thông tin tài khoản" },
                    new MasterHomeMenuItem { Id = 2, Title = "Đăng xuất" }

                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}