using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace User_Basic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            // xử lý tính tổng
            string So_1 = "" ,So_2 ="";
            double Tong = 0, so_t1 = 0, so_t2 = 0;
            So_1 = TxtSo_thu_1.Text;
            So_2 = TxtSo_Thu_2.Text;

           
            if(!double.TryParse(So_1,out so_t1))

            {
                DisplayAlert("Thông báo", "Bạn cần nhập dạng số", "Đóng");
                TxtSo_thu_1.Focus();
                return;
            }
            if (!double.TryParse(So_2, out so_t2))

            {
                DisplayAlert("Thông báo", "Bạn cần nhập dạng số", "Đóng");
                TxtSo_Thu_2.Focus();
                return;
            }
            Tong = so_t1 + so_t2;

            DisplayAlert("Kế quả", "Kết quả của phép tính là: " + Tong.ToString(), "Đóng");
            TxtSo_thu_1.IsEnabled = false;
            TxtSo_Thu_2.IsEnabled = false;

        }

        private void BtnRefresh_Clicked(object sender, EventArgs e)
        {
            TxtSo_thu_1.Text = string.Empty;
            TxtSo_Thu_2.Text = string.Empty;
            TxtSo_thu_1.IsEnabled = true;
            TxtSo_Thu_2.IsEnabled = true;
            TxtSo_thu_1.Focus();
        }
    }
}
