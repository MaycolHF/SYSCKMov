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
    public partial class UsersApiDetail : ContentPage
    {
        bool isNewItem;
        /*public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(UsersApiDetail));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }*/
        public UsersApiDetail(bool isNew = false)
        {
            InitializeComponent();
            isNewItem = isNew;
        }
        
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {                
                var todoItem = (UsersApi)BindingContext;
                await App.UApiManager.SaveTaskAsync(todoItem, isNewItem);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR",ex.Message,"OK");
            }
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var eliUA = (UsersApi)BindingContext;
                await App.UApiManager.DeleteTaskAsync(eliUA);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
    }
}