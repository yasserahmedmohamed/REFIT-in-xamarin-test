using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Refit;
using System.Threading.Tasks;

namespace AndroidProjectFirst.Classes
{
    [Headers("User-Agent: :request:")]
    interface IGitHubApi
    {
       
            [Get("/search/users?q=location:lagos")]
            Task<GitResponce.ApiResponce> GetUser();
       
    }
}