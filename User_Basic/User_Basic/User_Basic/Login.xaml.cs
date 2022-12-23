using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;

//using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;

namespace User_Basic
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        HttpClient client = new HttpClient();
        string url = URL.url + "api/CheckLogin";
		public Login ()
		{
			InitializeComponent ();
            // set biding bằng C#. nhưng hơi phức tạp
            //Poke = new Pokemon { name = "PiKachu", type = "Normal" };
            //lb1.SetBinding(Label.TextProperty, new Binding() { Source = Poke, Path = "name" });
            // tính từ trên -> lấy từ từ
            //lb1.BindingContext = Poke; -> tương tự như trên
            //lb2.BindingContext = Poke;

            // Gọi đến x:name của stacklayout để gán cho tất cả label. k cần phải set cho từng cái 1
            //MyStack.BindingContext = Poke;

        }
        //string strcon = $"Data Source=KienPV;Integrated Security=True";
        //SqlConnection sqlcon = null;
        //async public void Check_user()
        
            //sqlcon = new SqlConnection(strcon);

            //if (sqlcon.State == System.Data.ConnectionState.Closed)

            //    {

            //      sqlcon.Open();
            //      DisplayAlert("Thông báo", "Kết nối thành công", "Đóng");
            //    }
            //string user = TxtUser_Login.Text.ToString();
            //var json = JsonConvert.SerializeObject(user);
            //var noidung = new StringContent(json, Encoding.UTF8, "application/CheckLogin");
            //await client.PostAsync(URL.url + "api/CheckLogin");
            //await DisplayAlert("Thông báo", "OK", "Đóng");


        

      

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MasterHome());

            //if (TxtUser_Login.Text == "KienPv" && TxtPass_Login.Text == "123")

            //{
            //    //Check_user();
            //    Navigation.PushAsync(new MasterHome());
            //}
            //else
            //{
            //    DisplayAlert("Thông báo", "Tài khoản hoặc mật khẩu không chính xác !", "Đóng");
            //}
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new user_demo());
        }
    }
}