using System.Security.Principal;
using System.Web.Security;

namespace HashGag.Utils
{
    public class CookieUtil
    {
        public static void SetUserAuthCookie(string userTwitterHandel)
        {
            FormsAuthentication.SetAuthCookie(userTwitterHandel, true);
        }

        public static string GetUserFromAuthCookie(IPrincipal user)
        {
            string twitterHandle = string.Empty;
            twitterHandle = user.Identity.Name;
            return twitterHandle;
        }

        public static void SignUserOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}