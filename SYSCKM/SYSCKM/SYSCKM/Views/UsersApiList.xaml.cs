using SYSCKM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SYSCKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersApiList : ContentPage
    {
        public UsersApiList()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                listView.ItemsSource = await App.UApiManager.GetTasksAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new UsersApiDetail(true) 
                {
                    BindingContext = new UsersApi 
                    { 

                    } 
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR",ex.Message,"OK");
            }            
        }
        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                await Navigation.PushAsync( new UsersApiDetail
                {
                    BindingContext = e.SelectedItem as UsersApi
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
    }
}