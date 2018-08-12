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
  public  class UsersTest
    {
        public string Header;
        public string subheader;
        public int image;

        public UsersTest(string Head, string sunhead, int path) {

            this.Header = Head;
            this.subheader = sunhead;
            this.image = path;
        }

    }
}