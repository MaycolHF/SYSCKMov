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
    public partial class LecturaStikers : ContentPage
    {
        public LecturaStikers()
        {
            InitializeComponent();
        }        
        protected override void OnAppearing()
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            base.OnAppearing();
        }

        private async void btnBuscar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var todoItem = (Stikers)BindingContext;
                listView.ItemsSource = await App.StkManager.GetTasksAsync(todoItem);
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR",ex.Message,"OK");
            }
        }
    }
}