using SYSCKM.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SYSCKM
{
    public partial class App : Application
    {
        public static ColaboradorManager ColaManager { get; private set; }
        public static UserApiManager UApiManager { get; private set; }
        public static StikersManager StkManager { get; private set; }

        public App()
        {
            InitializeComponent();

            ColaManager = new ColaboradorManager(new ColaboradorService());
            UApiManager = new UserApiManager(new UserApiService());
            StkManager = new StikersManager(new StikersService());
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
