using SYSCKM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;

using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SYSCKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColaboradorPage : ContentPage
    {
        /*private const string Url = "https://localhost:44350/api/Colaborador";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Colaborador> _Colb;*/
        bool isNewItem;
        public ColaboradorPage(bool isNew = false)
        {
            InitializeComponent();
            isNewItem = isNew;
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var todoItem = (Colaborador)BindingContext;
                await App.ColaManager.SaveTaskAsync(todoItem, isNewItem);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var todoItem = (Colaborador)BindingContext;
                await App.ColaManager.DeleteTaskAsync(todoItem);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", ex.Message, "OK");
            }
        }

        async void OnCancelButtonClicked(object sender, EventArgs e)
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

        /*protected override async void OnAppearing()
        {
            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.None)
                {
                    await DisplayAlert("Mensaje", "No tiene Acceso a Internet", "OK");
                }
                else
                {
                    HttpClient client = new HttpClient();
                    string url = "http://192.168.0.3:8082/api/GetColaboradorDetails/47670";
                    Uri uri = new Uri(url);
                    string text = await client.GetStringAsync(uri);
                    await DisplayAlert("RESULTADO",text, "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR",ex.Message,"OK");
            }
            //base.OnAppearing();
            /*try
            {               
                string content = await client.GetStringAsync(Url);
                List<Colaborador> col = JsonConvert.DeserializeObject<List<Colaborador>>(content);
                _Colb = new ObservableCollection<Colaborador>(col);
                ListaColaborador.ItemsSource = _Colb;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}