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

namespace AndroidProjectFirst.Classes
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using GitResponce;
    //
    //    var welcome = Welcome.FromJson(jsonString);

    namespace GitResponce
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class ApiResponce
        {
            [JsonProperty("total_count")]
            public long TotalCount { get; set; }

            [JsonProperty("incomplete_results")]
            public bool IncompleteResults { get; set; }

            [JsonProperty("items")]
            public List<Item> Items { get; set; }
        }

        public partial class Item
        {
            [JsonProperty("login")]
            public string Login { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public string NodeId { get; set; }

            [JsonProperty("avatar_url")]
            public string AvatarUrl { get; set; }

            [JsonProperty("gravatar_id")]
            public string GravatarId { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("html_url")]
            public string HtmlUrl { get; set; }

            [JsonProperty("followers_url")]
            public string FollowersUrl { get; set; }

            [JsonProperty("following_url")]
            public string FollowingUrl { get; set; }

            [JsonProperty("gists_url")]
            public string GistsUrl { get; set; }

            [JsonProperty("starred_url")]
            public string StarredUrl { get; set; }

            [JsonProperty("subscriptions_url")]
            public string SubscriptionsUrl { get; set; }

            [JsonProperty("organizations_url")]
            public string OrganizationsUrl { get; set; }

            [JsonProperty("repos_url")]
            public string ReposUrl { get; set; }

            [JsonProperty("events_url")]
            public string EventsUrl { get; set; }

            [JsonProperty("received_events_url")]
            public string ReceivedEventsUrl { get; set; }

            [JsonProperty("site_admin")]
            public bool SiteAdmin { get; set; }

            [JsonProperty("score")]
            public long Score { get; set; }
        }

       
    }

}