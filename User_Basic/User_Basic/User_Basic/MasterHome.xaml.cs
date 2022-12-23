using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace User_Basic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterHome : MasterDetailPage
    {
        public MasterHome()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterHomeMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
            if(item.Id ==0)
            {
                
                Navigation.PushAsync(new Home());

            }
            if (item.Id == 2)
            {
                Navigation.PushAsync(new Login());
            }
        }
    }
}