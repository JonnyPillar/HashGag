using System.ComponentModel.DataAnnotations;

namespace HashGag.Models.ViewModels
{
    public class NavigationUserInfoView
    {
        public NavigationUserInfoView(string twitterHandel)
        {
            UserTwitterHandle = twitterHandel;
        }

        [Display(Name =  "Hello ")]
        public string UserTwitterHandle { get; set; }
    }
}