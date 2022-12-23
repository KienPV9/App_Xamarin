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
	public partial class user_demo : ContentPage
	{
		public user_demo ()
		{
			InitializeComponent ();
            HienThiDS();
            //imgone.Source = ImageSource.FromResource("123.jpg");
            //timepicker.Time = DateTime.Now.TimeOfDay;

        }
        private void HienThiDS()
        {
            List<String> lsthang = new List<string>();
            lsthang.Add("Nam");
            lsthang.Add("Nữ");
            lsthang.Add("Khác");

            // Hiện thị danh sách, gán danh sách PK từ list
            PKSex.ItemsSource = lsthang;
        }
       
        private void BtnDang_nhap_Clicked(object sender, EventArgs e)
        {
            if (txtPassWord.Text != txtPassWord_c.Text)
            {
              
                DisplayAlert("Thông báo", "Mật khẩu xác nhận không trùng khớp. Vui lòng xem lại !", "Đóng");
                return;
            }
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtPassWord.Text))
            {
                DisplayAlert("Thông báo", "Tài khoản hoặc mật khẩu không được để trống !", "Đóng");
                return;
            }
            if (string.IsNullOrEmpty((string)PKSex.SelectedItem))
            {
                DisplayAlert("Thông báo", "Bạn chưa chọn Giới tính !", "Đóng");
                return;
            }

            if (string.IsNullOrEmpty((string)PKQuocGia.SelectedItem))
            {
                DisplayAlert("Thông báo", "Bạn chưa chọn Quốc gia !", "Đóng");
                return;
            }
           if(txtusername.Text == "KienPV")
            {
                DisplayAlert("Thông báo", $"Tài khoản " + txtusername.Text + " đã tồn tại !", "Đóng");
                    return;
            }

            DisplayAlert("Thông báo", "Tài khoản đã được tạo thành công","Đóng");
        }

        private void BtnLam_Moi_Clicked(object sender, EventArgs e)
        {
            txtPassWord.Text = string.Empty;
            txtusername.Text = string.Empty;
            txtPassWord_c.Text = string.Empty;
            PKQuocGia.SelectedItem = string.Empty;
            PKSex.SelectedItem = string.Empty;

            txtusername.Focus();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
           
        }

        private void Timepicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}