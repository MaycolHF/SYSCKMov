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
    public partial class ColaboradorList : ContentPage
    {
        public ColaboradorList()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                listView.ItemsSource = await App.ColaManager.GetTasksAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
        async void OnAddItemClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ColaboradorPage(true)
                {
                    BindingContext = new Colaborador
                    {
                       // Cod_Funcionario = Guid.NewGuid().ToString()
                    }
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ColaboradorPage
                {
                    BindingContext = e.SelectedItem as Colaborador
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }
    }
}