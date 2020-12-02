using SYSCKM.Models;
using SYSCKM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SYSCKM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnColaborador_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new ColaboradorList());
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "OK");
            }
        }

        private void btnUserApi_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new UsersApiList());
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "OK");
            }
        }

        private async void btnLecturaSti_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new LecturaStikers()
                {
                    BindingContext = new Stikers
                    {

                    }
                });
                //Navigation.PushAsync(new LecturaStikers());
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
    }
}
