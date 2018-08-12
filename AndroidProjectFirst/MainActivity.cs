using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using AndroidProjectFirst.Classes;
using System.Collections.Generic;

using AndroidProjectFirst.Classes.GitResponce;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using Refit;

namespace AndroidProjectFirst
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        List<UsersTest> tableItems;
        ListView list_series;
        IGitHubApi gitHubApi;
        List<Classes.GitResponce.Item> users = new List<Classes.GitResponce.Item>();
        List<string> user_names = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
          
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = { new StringEnumConverter() }
            };
            gitHubApi = RestService.For<IGitHubApi>("https://api.github.com");




            list_series = FindViewById<ListView>(Resource.Id.list_series);
             tableItems = new List<UsersTest>();


            getUsers();



            list_series.ItemClick += List_series_ItemClick;
        }

        private void List_series_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, users[e.Position].Url, ToastLength.Short).Show();
            //list_series.Visibility = Android.Views.ViewStates.Gone;

        }


        private async void getUsers()
        {
            try
            {
                Classes.GitResponce.ApiResponce response = await gitHubApi.GetUser();
                users = response.Items;

                foreach (Classes.GitResponce.Item user in users)
                {
                    user_names.Add(user.Login);
                }
                list_series.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, user_names);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.StackTrace, ToastLength.Long).Show();

            }
        }
    }
}

