using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SYSCKM
{
    public static class Constants
    {
        //http://192.168.0.3:8082/api/UsersApi{0}
        //http://localhost:63979/api/UsersApi{0}
        //http://170.231.80.84:8082/api/UsersApi{0}
        public static string RestUrl = Device.RuntimePlatform == Device.Android ? "http://192.168.0.3:8082/api/UsersApi{0}" : "http://192.168.0.3:8082/api/UsersApi{0}";
        public static string UrlStikers = Device.RuntimePlatform == Device.Android ? "http://192.168.0.3:8082/api/Stikers{0}" : "http://192.168.0.3:8082/api/Stikers{0}";
    }
}
