using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SYSCKM
{
    public interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
