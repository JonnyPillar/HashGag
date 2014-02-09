using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashGag.Models.ViewModels
{
    public class NavigationBar
    {
        public NavigationUserInfoView navUserInfoView;

        public NavigationBar(string twitterHandel)
        {
            this.navUserInfoView = new NavigationUserInfoView(twitterHandel);
        }

        public NavigationUserInfoView NavUserInfoView { get; set; }
    }
}